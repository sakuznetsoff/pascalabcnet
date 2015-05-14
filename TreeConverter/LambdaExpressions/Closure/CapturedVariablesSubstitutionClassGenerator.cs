﻿using System;
using System.Collections.Generic;
using System.Linq;
using PascalABCCompiler.SemanticTree;
using PascalABCCompiler.SyntaxTree;
using PascalABCCompiler.TreeConverter;
using PascalABCCompiler.TreeRealization;

namespace TreeConverter.LambdaExpressions.Closure
{
    internal class CapturedVariablesSubstitutionClassGenerator
    {
        private readonly CapturedVariablesTreeNode _capturedVariablesRootTreeNode;
        private readonly Dictionary<int, ScopeClassDefinition> _capturedVarsClassDefs;
        private readonly List<CapturedVariablesTreeNodeLambdaScope> _lambdasToBeAddedAsMethods;
        private const string GeneratedClassPrefix = "<>local_variables_class_";
        private const string GeneratedUpperClassPrefix = "<>local_variables_class_UPPER_";
        private static int _generatedClassCounter; 
        private static int _generatedUpperClassCounter;
        private readonly Dictionary<SubstitutionKey, dot_node> _substitutions;

        public static void Reset()
        {
            _generatedClassCounter = 0;
            _generatedUpperClassCounter = 0;
        }

        public class VariableSubstitutionsInfo
        {
            public Dictionary<int, ScopeClassDefinition> GeneratedScopeClassesInfo
            {
                get;
                set;
            }

            public Dictionary<SubstitutionKey, dot_node> SubstitutionsInfo
            {
                get;
                set;
            }

            public List<CapturedVariablesTreeNodeLambdaScope> LambdasToBeAddedAsMethods
            {
                get;
                set;
            }

            public Dictionary<string, Tuple<string, class_field, semantic_node>> ConvertingClassNonPublicMembersMapping
            {
                get; set;
            }
        }

        public class ScopeClassDefinition
        {
            private const string GeneratedSubstitutingFieldPrefix = "<>local_variables_"; //это поле для того, чтобы заменять в текущем блоке, где захватывались переменные, левую часть dot_node
            private static int _generatedSubstitutingFieldCounter;

            public syntax_tree_node CorrespondingSyntaxTreeNode
            {
                get;
                private set;
            }

            public type_declaration ClassDeclaration
            {
                get;
                private set;
            }
            
            private string _generatedSubstitutingFieldName;
            public string GeneratedSubstitutingFieldName
            {
                get {
                    return _generatedSubstitutingFieldName ??
                           (_generatedSubstitutingFieldName =
                            GeneratedSubstitutingFieldPrefix + _generatedSubstitutingFieldCounter++);
                }
            }

            private string _generatedUpperClassFieldName;
            public string GeneratedUpperClassFieldName
            {
                get
                {
                    return _generatedUpperClassFieldName ??
                           (_generatedUpperClassFieldName =
                            GeneratedUpperClassPrefix + _generatedUpperClassCounter++);
                }
            }

            private var_statement _generatedVarStatementForScope;
            public var_statement GeneratedVarStatementForScope
            {
                get
                {
                    if (_generatedVarStatementForScope == null)
                    {
                        var newVarDefSyntaxTreeNode =
                            SyntaxTreeBuilder.BuildSimpleVarDef(GeneratedSubstitutingFieldName, ClassDeclaration.type_name.name);

                        newVarDefSyntaxTreeNode.inital_value =
                            new new_expr(SyntaxTreeBuilder.BuildSimpleType(ClassDeclaration.type_name.name),
                                         new expression_list(), null);

                        _generatedVarStatementForScope = new var_statement(newVarDefSyntaxTreeNode);
                    }

                    return _generatedVarStatementForScope;
                }
            }

            public assign AssignNodeForUpperClassFieldInitialization
            {
                get; 
                set;
            }

            public CapturedVariablesTreeNode CorrespondingTreeNode { get; private set; }

            public ScopeClassDefinition(syntax_tree_node syntaxTreeNode,
                                        type_declaration classDeclaration,
                                        CapturedVariablesTreeNode correspondingTreeNode,
                                        string generatedSubstitutingFieldName = null)
            {
                CorrespondingSyntaxTreeNode = syntaxTreeNode;
                ClassDeclaration = classDeclaration;
                _generatedSubstitutingFieldName = generatedSubstitutingFieldName;
                CorrespondingTreeNode = correspondingTreeNode;
            }
        }

        public CapturedVariablesSubstitutionClassGenerator(CapturedVariablesTreeNode capturedVariablesRootTreeNode)
        {
            _capturedVariablesRootTreeNode = capturedVariablesRootTreeNode;
            _capturedVarsClassDefs = new Dictionary<int, ScopeClassDefinition>();
            _substitutions = new Dictionary<SubstitutionKey, dot_node>();
            _lambdasToBeAddedAsMethods = new List<CapturedVariablesTreeNodeLambdaScope>();
        }

        private string GeneratedClassName
        {
            get
            {
                return GeneratedClassPrefix + _generatedClassCounter++;
            }
        }

        private void VisitCapturedVar(CapturedVariablesTreeNode scope, CapturedVariablesTreeNode.CapturedSymbolInfo symbolInfo)
        {
            var varName = ((IVAriableDefinitionNode)symbolInfo.SymbolInfo.sym_info).name.ToLower(); //TODO: !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            var isSelfWordInClass = scope is CapturedVariablesTreeNodeClassScope && varName == compiler_string_consts.self_word;

            for (var k = 0; k < symbolInfo.ReferencingLambdas.Count; k++)
            {
                var referencingLambda = symbolInfo.ReferencingLambdas[k];
                if (scope != referencingLambda.ParentNode)
                {
                    var upperScopesStack = new Stack<CapturedVariablesTreeNode>();
                    var crawlUpScope = referencingLambda.ParentNode;

                    while (crawlUpScope != scope)
                    {
                        upperScopesStack.Push(crawlUpScope);
                        crawlUpScope = crawlUpScope.ParentNode;
                    }

                    var upperScopeWhereVarsAreCaptured = scope;
                    var upperScopeWhereVarsAreCapturedClass =
                        _capturedVarsClassDefs[upperScopeWhereVarsAreCaptured.ScopeIndex].ClassDeclaration;

                    var substKey = new SubstitutionKey(varName, symbolInfo.SyntaxTreeNodeWithVarDeclaration,
                                                       scope.CorrespondingSyntaxTreeNode);
                    if (!_substitutions.ContainsKey(substKey))
                    {
                        _substitutions.Add(substKey,
                                           new dot_node(
                                               new ident(
                                                   _capturedVarsClassDefs[upperScopeWhereVarsAreCaptured.ScopeIndex]
                                                       .GeneratedSubstitutingFieldName), new ident(varName)));
                    }

                    while (upperScopesStack.Count != 0)
                    {
                        var foundScopeWhereVarsWereCaptured = false;
                        while (upperScopesStack.Count != 0 && !foundScopeWhereVarsWereCaptured)
                        {
                            if (
                                upperScopesStack.Peek()
                                                .VariablesDefinedInScope.Exists(var => var.ReferencingLambdas.Count > 0))
                            {
                                foundScopeWhereVarsWereCaptured = true;
                            }
                            else
                            {
                                var curScope = upperScopesStack.Pop();

                                if (upperScopeWhereVarsAreCaptured == scope &&
                                    upperScopeWhereVarsAreCaptured is CapturedVariablesTreeNodeClassScope)
                                {
                                    continue;
                                }

                                substKey = new SubstitutionKey(varName, symbolInfo.SyntaxTreeNodeWithVarDeclaration,
                                                               curScope.CorrespondingSyntaxTreeNode);

                                dot_node dotnode;

                                if (upperScopeWhereVarsAreCaptured != scope)
                                {
                                    dotnode =
                                        new dot_node(
                                            new ident(
                                                _capturedVarsClassDefs[upperScopeWhereVarsAreCaptured.ScopeIndex]
                                                    .GeneratedSubstitutingFieldName),
                                            new ident(
                                                _capturedVarsClassDefs[upperScopeWhereVarsAreCaptured.ScopeIndex]
                                                    .GeneratedUpperClassFieldName));

                                    var nodeForDotNodeCalc = upperScopeWhereVarsAreCaptured.ParentNode;
                                    while (nodeForDotNodeCalc != scope)
                                    {
                                        if (_capturedVarsClassDefs.ContainsKey(nodeForDotNodeCalc.ScopeIndex) &&
                                            _capturedVarsClassDefs[nodeForDotNodeCalc.ScopeIndex]
                                                .AssignNodeForUpperClassFieldInitialization != null)
                                        {
                                            dotnode = new dot_node(dotnode,
                                                                   new ident(
                                                                       _capturedVarsClassDefs[
                                                                           nodeForDotNodeCalc.ScopeIndex]
                                                                           .GeneratedUpperClassFieldName));
                                        }

                                        nodeForDotNodeCalc = nodeForDotNodeCalc.ParentNode;
                                    }
                                    if (!isSelfWordInClass)
                                    {
                                        dotnode = new dot_node(dotnode, new ident(varName));
                                    }
                                }
                                else
                                {
                                    dotnode = new dot_node(new ident(
                                                               _capturedVarsClassDefs[
                                                                   upperScopeWhereVarsAreCaptured.ScopeIndex]
                                                                   .GeneratedSubstitutingFieldName),
                                                           new ident(varName));
                                }

                                if (!_substitutions.ContainsKey(substKey))
                                {
                                    _substitutions.Add(substKey, dotnode);
                                }
                            }
                        }

                        if (foundScopeWhereVarsWereCaptured)
                        {
                            var nextNodeWhereVarsAreCaptured = upperScopesStack.Pop();
                            if (!_capturedVarsClassDefs.ContainsKey(nextNodeWhereVarsAreCaptured.ScopeIndex))
                            {
                                var classDef = SyntaxTreeBuilder.BuildClassDefinition(true);
                                var typeDeclaration = new type_declaration(GeneratedClassName, classDef);
                                _capturedVarsClassDefs.Add(nextNodeWhereVarsAreCaptured.ScopeIndex,
                                                           new ScopeClassDefinition(
                                                               nextNodeWhereVarsAreCaptured.CorrespondingSyntaxTreeNode,
                                                               typeDeclaration,
                                                               nextNodeWhereVarsAreCaptured));
                            }

                            var nextNodeWhereVarsAreCapturedClass =
                                (class_definition)
                                _capturedVarsClassDefs[nextNodeWhereVarsAreCaptured.ScopeIndex].ClassDeclaration
                                                                                               .type_def;

                            if (
                                _capturedVarsClassDefs[nextNodeWhereVarsAreCaptured.ScopeIndex]
                                    .AssignNodeForUpperClassFieldInitialization == null)
                            {
                                var fieldType =
                                    SyntaxTreeBuilder.BuildSimpleType(upperScopeWhereVarsAreCapturedClass.type_name.name);
                                var field =
                                    SyntaxTreeBuilder.BuildClassFieldsSection(
                                        new List<ident>
                                            {
                                                new ident(
                                            _capturedVarsClassDefs[nextNodeWhereVarsAreCaptured.ScopeIndex]
                                                .GeneratedUpperClassFieldName)
                                            },
                                        new List<type_definition> {fieldType});

                                nextNodeWhereVarsAreCapturedClass.body.Add(field);

                                _capturedVarsClassDefs[nextNodeWhereVarsAreCaptured.ScopeIndex]
                                    .AssignNodeForUpperClassFieldInitialization =
                                    new assign(
                                        new dot_node(
                                            new ident(
                                                _capturedVarsClassDefs[nextNodeWhereVarsAreCaptured.ScopeIndex]
                                                    .GeneratedSubstitutingFieldName),
                                            new ident(
                                                _capturedVarsClassDefs[nextNodeWhereVarsAreCaptured.ScopeIndex]
                                                    .GeneratedUpperClassFieldName)),
                                        new ident(
                                            _capturedVarsClassDefs[upperScopeWhereVarsAreCaptured.ScopeIndex]
                                                .GeneratedSubstitutingFieldName));
                            }

                            substKey = new SubstitutionKey(varName, symbolInfo.SyntaxTreeNodeWithVarDeclaration,
                                                           nextNodeWhereVarsAreCaptured.CorrespondingSyntaxTreeNode);

                            var dot =
                                new dot_node(
                                    new ident(
                                        _capturedVarsClassDefs[nextNodeWhereVarsAreCaptured.ScopeIndex]
                                            .GeneratedSubstitutingFieldName),
                                    new ident(
                                        _capturedVarsClassDefs[nextNodeWhereVarsAreCaptured.ScopeIndex]
                                            .GeneratedUpperClassFieldName));

                            var nodeForDotNodeCalculation = nextNodeWhereVarsAreCaptured.ParentNode;
                            while (nodeForDotNodeCalculation != scope)
                            {
                                if (_capturedVarsClassDefs.ContainsKey(nodeForDotNodeCalculation.ScopeIndex) &&
                                    _capturedVarsClassDefs[nodeForDotNodeCalculation.ScopeIndex]
                                        .AssignNodeForUpperClassFieldInitialization != null)
                                {
                                    dot = new dot_node(dot,
                                                       new ident(
                                                           _capturedVarsClassDefs[nodeForDotNodeCalculation.ScopeIndex]
                                                               .GeneratedUpperClassFieldName));
                                }

                                nodeForDotNodeCalculation = nodeForDotNodeCalculation.ParentNode;
                            }

                            if (!isSelfWordInClass)
                            {
                                dot = new dot_node(dot, new ident(varName));
                            }

                            if (!_substitutions.ContainsKey(substKey))
                            {
                                _substitutions.Add(substKey, dot);
                            }

                            upperScopeWhereVarsAreCaptured = nextNodeWhereVarsAreCaptured;
                            upperScopeWhereVarsAreCapturedClass =
                                _capturedVarsClassDefs[upperScopeWhereVarsAreCaptured.ScopeIndex].ClassDeclaration;
                        }
                    }

                    //TODO: Nested Lambdas
                    if (!(upperScopeWhereVarsAreCaptured == scope &&
                          upperScopeWhereVarsAreCaptured is CapturedVariablesTreeNodeClassScope))
                    {
                        if (upperScopeWhereVarsAreCaptured != scope)
                        {
                            var dotnode1 = new dot_node(
                                new ident(compiler_string_consts.self_word),
                                new ident(
                                    _capturedVarsClassDefs[upperScopeWhereVarsAreCaptured.ScopeIndex]
                                        .GeneratedUpperClassFieldName));

                            if (upperScopeWhereVarsAreCaptured != scope)
                            {
                                var nodeForDotNodeCalc = upperScopeWhereVarsAreCaptured.ParentNode;
                                while (nodeForDotNodeCalc != scope)
                                {
                                    if (_capturedVarsClassDefs.ContainsKey(nodeForDotNodeCalc.ScopeIndex) &&
                                        _capturedVarsClassDefs[nodeForDotNodeCalc.ScopeIndex]
                                            .AssignNodeForUpperClassFieldInitialization != null)
                                    {
                                        dotnode1 = new dot_node(dotnode1,
                                                                new ident(
                                                                    _capturedVarsClassDefs[nodeForDotNodeCalc.ScopeIndex]
                                                                        .GeneratedUpperClassFieldName));
                                    }

                                    nodeForDotNodeCalc = nodeForDotNodeCalc.ParentNode;
                                }
                            }

                            if (!isSelfWordInClass)
                            {
                                var classScope = scope as CapturedVariablesTreeNodeClassScope;
                                if (classScope != null)
                                {
                                    Tuple<string, class_field, semantic_node> publicProperty;
                                    if (classScope.NonPublicMembersNamesMapping.TryGetValue(varName, out publicProperty))
                                    {
                                        dotnode1 = new dot_node(dotnode1, new ident(publicProperty.Item1));
                                    }
                                    else
                                    {
                                        dotnode1 = new dot_node(dotnode1, new ident(varName));
                                    }
                                }
                                else
                                {
                                    dotnode1 = new dot_node(dotnode1, new ident(varName));
                                }
                            }
                            AddReferencesToIdentInLambda(referencingLambda.ChildNodes[0], varName,
                                                         symbolInfo.SyntaxTreeNodeWithVarDeclaration, dotnode1);
                        }
                    }
                    if (!referencingLambda.ScopeIndexOfClassWhereLambdaWillBeAddedAsMethod.HasValue ||
                        upperScopeWhereVarsAreCaptured.ScopeIndex >
                        referencingLambda.ScopeIndexOfClassWhereLambdaWillBeAddedAsMethod)
                    {
                        referencingLambda.ScopeIndexOfClassWhereLambdaWillBeAddedAsMethod =
                            upperScopeWhereVarsAreCaptured.ScopeIndex;
                    }
                }
                else
                {
                    if (!_capturedVarsClassDefs.ContainsKey(scope.ScopeIndex))
                    {
                        var classDef = SyntaxTreeBuilder.BuildClassDefinition(true);
                        var typeDeclaration = new type_declaration(GeneratedClassName, classDef);
                        _capturedVarsClassDefs.Add(scope.ScopeIndex,
                                                   new ScopeClassDefinition(
                                                       scope.CorrespondingSyntaxTreeNode,
                                                       typeDeclaration,
                                                       scope));
                    }

                    var substKey = new SubstitutionKey(varName, symbolInfo.SyntaxTreeNodeWithVarDeclaration,
                                                       scope.CorrespondingSyntaxTreeNode);
                    if (!_substitutions.ContainsKey(substKey))
                    {
                        if (!isSelfWordInClass)
                        {
                            string propertyName = null;

                            var classScope = scope as CapturedVariablesTreeNodeClassScope;
                            if (classScope != null)
                            {
                                Tuple<string, class_field, semantic_node> publicProperty;
                                if (classScope.NonPublicMembersNamesMapping.TryGetValue(varName, out publicProperty))
                                {
                                    propertyName = publicProperty.Item1;
                                }
                            }

                            _substitutions.Add(substKey,
                                               new dot_node(
                                                   new ident(
                                                       _capturedVarsClassDefs[scope.ScopeIndex]
                                                           .GeneratedSubstitutingFieldName), new ident(propertyName ?? varName)));
                        }
                    }

                    if (!referencingLambda.ScopeIndexOfClassWhereLambdaWillBeAddedAsMethod.HasValue ||
                        scope.ScopeIndex > referencingLambda.ScopeIndexOfClassWhereLambdaWillBeAddedAsMethod)
                    {
                        referencingLambda.ScopeIndexOfClassWhereLambdaWillBeAddedAsMethod = scope.ScopeIndex;
                    }
                }

                if (!_lambdasToBeAddedAsMethods.Contains(referencingLambda))
                {
                    _lambdasToBeAddedAsMethods.Add(referencingLambda);
                }
            }
        }

        private void AddReferencesToIdentInLambda(CapturedVariablesTreeNode scope, string varName, syntax_tree_node syntaxTreeNodeWithVarDeclaration, dot_node substDotNode)
        {
            //TODO: Nested Lambdas

            for (var i = 0; i < scope.ChildNodes.Count; i++)
            {
                if (!(scope.ChildNodes[i] is CapturedVariablesTreeNodeLambdaScope)) // Вложенные лямбды пока не рассматриваем
                {
                    var substKey = new SubstitutionKey(varName, syntaxTreeNodeWithVarDeclaration,
                                                       scope.ChildNodes[i].CorrespondingSyntaxTreeNode);

                    if (!_substitutions.ContainsKey(substKey))
                    {
                        _substitutions.Add(substKey, substDotNode);
                    }

                    AddReferencesToIdentInLambda(scope.ChildNodes[i], varName, syntaxTreeNodeWithVarDeclaration,
                                                 substDotNode);
                }
            }
        }
        
        private void VisitTreeAndBuildClassDefinitions(CapturedVariablesTreeNode currentNode)
        {
            var variablesFromThisScopeWhichWereCaptured = currentNode
                .VariablesDefinedInScope
                .Where(var => var.ReferencingLambdas.Count > 0)
                .ToList();

            if (variablesFromThisScopeWhichWereCaptured.Count > 0)
            {
                if (currentNode is CapturedVariablesTreeNodeClassScope)
                {
                    if (!_capturedVarsClassDefs.ContainsKey(currentNode.ScopeIndex))
                    {
                        var classDef = SyntaxTreeBuilder.BuildClassDefinition(true);
                        var typeDeclaration = new type_declaration(((CapturedVariablesTreeNodeClassScope)currentNode).ClassName, classDef);
                        _capturedVarsClassDefs.Add(currentNode.ScopeIndex,
                                                   new ScopeClassDefinition(currentNode.CorrespondingSyntaxTreeNode,
                                                                            typeDeclaration,
                                                                            currentNode,
                                                                            compiler_string_consts.self_word));
                    }
                }
                else
                {
                    if (!_capturedVarsClassDefs.ContainsKey(currentNode.ScopeIndex))
                    {
                        var classDef = SyntaxTreeBuilder.BuildClassDefinition(true);
                        var typeDeclaration = new type_declaration(GeneratedClassName, classDef);
                        _capturedVarsClassDefs.Add(currentNode.ScopeIndex,
                                                   new ScopeClassDefinition(currentNode.CorrespondingSyntaxTreeNode,
                                                                            typeDeclaration,
                                                                            currentNode));
                    }

                    // TODO: тут предусматривать разные случаи

                    var vars = variablesFromThisScopeWhichWereCaptured
                        .Select(field => field.SymbolInfo.sym_info as IVAriableDefinitionNode)
                        .ToList();

                    var fieldNames = vars
                        .Select(var => new ident(var.name))
                        .ToList();

                    var fieldTypes = vars
                        .Select(var => SyntaxTreeBuilder.BuildSemanticType(var.type))
                        .ToList();

                    var classFields = SyntaxTreeBuilder.BuildClassFieldsSection(fieldNames, fieldTypes);

                    ((class_definition) _capturedVarsClassDefs[currentNode.ScopeIndex].ClassDeclaration.type_def).body
                                                                                                                 .Add(
                                                                                                                     classFields);

                    if (currentNode is CapturedVariablesTreeNodeProcedureScope)
                    {
                        var constructorSection = SyntaxTreeBuilder.BuildSimpleConstructorSection(fieldNames,
                                                                                                 fieldNames.Select(
                                                                                                     id =>
                                                                                                     new ident("_" +
                                                                                                               id.name))
                                                                                                           .ToList(),
                                                                                                 fieldTypes);
                        ((class_definition) _capturedVarsClassDefs[currentNode.ScopeIndex].ClassDeclaration.type_def)
                            .body.Add(constructorSection);
                    }
                }

                foreach (var capturedVar in variablesFromThisScopeWhichWereCaptured)
                {
                    VisitCapturedVar(currentNode, capturedVar);
                }
            }

            foreach (CapturedVariablesTreeNode childNode in currentNode.ChildNodes)
            {
                VisitTreeAndBuildClassDefinitions(childNode);
            }

            if (variablesFromThisScopeWhichWereCaptured.Count > 0)
            {
                // TODO: тут предусматривать разные случаи
                var vars = variablesFromThisScopeWhichWereCaptured
                    .Select(x =>
                            new
                            {
                                IVarDefinitionNode = x.SymbolInfo.sym_info as IVAriableDefinitionNode,
                                VarDeclNode = x.SyntaxTreeNodeWithVarDeclaration
                            })
                    .Where(x => x.IVarDefinitionNode != null)
                    .ToList();

                foreach (var var in vars)
                {
                    foreach (CapturedVariablesTreeNode childNode in currentNode.ChildNodes)
                    {
                        RewriteReferencesForNodesThatAreChildNodesToThoseThatContainCapturedVariable(childNode, var.IVarDefinitionNode.name, var.VarDeclNode);
                    }
                }
            }
        }

        private void RewriteReferencesForNodesThatAreChildNodesToThoseThatContainCapturedVariable(CapturedVariablesTreeNode node, string varName, syntax_tree_node nodeWithVarDecl)
        {
            if (!(node is CapturedVariablesTreeNodeBlockScope || 
                  node is CapturedVariablesTreeNodeForScope || 
                  node is CapturedVariablesTreeNodeForEachScope)) // Добавляем ссылки только для скоупов-блоков и циклов, потому что остальные случаи должны были уже быть рассмотрены (когда эти случаи буду реализованы)
            {
                return;
            }

            var substKey = new SubstitutionKey(varName, nodeWithVarDecl, node.CorrespondingSyntaxTreeNode);
            if (!_substitutions.ContainsKey(substKey))
            {
                var parentNode = node.ParentNode;
                var isReferenceFound = false;
                SubstitutionKey parentSubstKey = null;

                while (parentNode != null && !isReferenceFound)
                {
                    parentSubstKey = new SubstitutionKey(varName, nodeWithVarDecl, parentNode.CorrespondingSyntaxTreeNode);
                    if (_substitutions.ContainsKey(parentSubstKey))
                    {
                        isReferenceFound = true;
                    }
                    else
                    {
                        parentNode = parentNode.ParentNode;
                    }
                }
                
                if (isReferenceFound)
                {
                    _substitutions.Add(substKey, _substitutions[parentSubstKey]);
                }

            }
            foreach (CapturedVariablesTreeNode childNode in node.ChildNodes)
            {
                RewriteReferencesForNodesThatAreChildNodesToThoseThatContainCapturedVariable(childNode, varName, nodeWithVarDecl);
            }
        }

        public VariableSubstitutionsInfo GenerateSubstitutions()
        {
            VisitTreeAndBuildClassDefinitions(_capturedVariablesRootTreeNode);

            return new VariableSubstitutionsInfo
                {
                    GeneratedScopeClassesInfo = _capturedVarsClassDefs,
                    SubstitutionsInfo = _substitutions,
                    LambdasToBeAddedAsMethods = _lambdasToBeAddedAsMethods,
                    ConvertingClassNonPublicMembersMapping = _capturedVariablesRootTreeNode is CapturedVariablesTreeNodeClassScope ? 
                        ((CapturedVariablesTreeNodeClassScope)_capturedVariablesRootTreeNode).NonPublicMembersNamesMapping : null
                };
        }
    }
}