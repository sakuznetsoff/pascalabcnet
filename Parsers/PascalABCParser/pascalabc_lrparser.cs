
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using PascalABCCompiler.SyntaxTree;
using PascalABCCompiler.Errors;
using PascalABCCompiler.PascalABCParser.Errors;
using PascalABCCompiler.ParserTools;

using PascalABCCompiler.Preprocessor2;

namespace PascalABCCompiler.PascalABCParser
{
    public partial class GPBParser_PascalABC : GPBParser
    {
        public Preprocessor2.Preprocessor2 prepr;
        internal SourceContextMap scm;
        public bool build_tree_for_brackets = false;
        private Stack NodesStack;
        private SyntaxError error;

        Stream GrammarStream;

        public GPBParser_PascalABC(Stream stream, GoldParser.Grammar grammar, Preprocessor2.Preprocessor2 prepr1)
            : base(grammar)
        {
            prepr = prepr1;

        	GrammarStream = stream;
        	parsertools = new pascalabc_parsertools();
        }

        public GPBParser_PascalABC(Stream stream, Preprocessor2.Preprocessor2 prepr1)
            : base(stream)
        {
            prepr = prepr1;
            
            GrammarStream = stream;
            parsertools = new pascalabc_parsertools();
        }

        public object Parse(string source)
        {
            NodesStack = new Stack();
            LRParser = new GoldParser.Parser(new StringReader(source), LanguageGrammar);
            parsertools.parser  = LRParser;
            LRParser.TrimReductions = true;
            try
            {
                while (true)
                {
                    switch (LRParser.Parse())
                    {
                        case GoldParser.ParseMessage.LexicalError:
                            errors.Add(new TokenReadError(this));
                            LRParser.PopInputToken();
                            if (errors.Count >= max_errors)
                                return null;
                            break;

                        //sdes nugno vesti chtoto vrode steka poslednix oshibok. podumat
                        case GoldParser.ParseMessage.SyntaxError:
                            GoldParser.Symbol sym = LRParser.PopInputToken();
                            error = new PABCNETUnexpectedToken(this);
                            //error = new UnexpectedToken(this, parsertools.symbol_collection_to_string(this.LRParser.GetExpectedTokens()));
                            if (sym.SymbolType == GoldParser.SymbolType.End && errors.Count > 0)
                                return null;
                            errors.Add(error);
                            if (errors.Count >= max_errors)
                                return null;
                            break;
                        case GoldParser.ParseMessage.Reduction:
                            LRParser.TokenSyntaxNode = CreateNonTerminalObject(LRParser.ReductionRule.Index);
                            if ((LRParser.TokenSyntaxNode as syntax_tree_node) != null)
                                prev_node = LRParser.TokenSyntaxNode;
                            break;

                        case GoldParser.ParseMessage.Accept:
                            return LRParser.TokenSyntaxNode;

                        case GoldParser.ParseMessage.TokenRead:
                            LRParser.TokenSyntaxNode = CreateTerminalObject(LRParser.TokenSymbol.Index);
                            break;

                        case GoldParser.ParseMessage.InternalError:
                            errors.Add(new CompilerInternalError("PascalABCParser", new Exception("ParseMessage.InternalError")));
                            return null;

                        case GoldParser.ParseMessage.NotLoadedError:
                            errors.Add(new CompilerInternalError("PascalABCParser", new Exception("ParseMessage.NotLoadedError")));
                            return null;

                        case GoldParser.ParseMessage.CommentError:
                            errors.Add(new UnexpectedToken(this, "(EOF)"));
                            return null;
                            
                        case GoldParser.ParseMessage.CommentBlockRead:
                            {
                                /*
                                compiler_directive cd = new compiler_directive();
                                cd.source_context = parsertools.GetTokenSourceContext(this.LRParser);
                                string comment = this.LRParser.CommentText;
                                cd.Name = new token_info(comment);
                                cd.Directive = new token_info(comment);
                                cd.source_context = new SourceContext(cd.source_context,parsertools.GetTokenSourceContext(this.LRParser));
                                if (cd.Directive.text[0] == '{' && cd.Directive.text[1] == '$')
                                    this.errors.Add(new Preprocessor_2.Errors.SyntaxErrorInDirective(cd.source_context.FileName, cd.source_context, cd.Directive.text));
                                    
                                this.CompilerDirectives.Add(cd);
                                */
                                                                                                                                         
                            } break;

                        case GoldParser.ParseMessage.CommentLineRead:
                            {
                                 /* 
                                 compiler_directive cd = new compiler_directive();
                                 cd.source_context = parsertools.GetTokenSourceContext(this.LRParser);
                                 string comment = this.LRParser.CommentText;
                                 cd.Name = new token_info(comment);
                                 cd.Directive = new token_info(comment);
                                 cd.source_context = new SourceContext(cd.source_context.begin_position.line_num, cd.source_context.begin_position.column_num, cd.source_context.end_position.line_num, cd.source_context.end_position.column_num + comment.Length - Environment.NewLine.Length);
                                 this.CompilerDirectives.Add(cd); 
                                 */
                            } break;

                    }
                }
            }
            catch (GoldParser.UnexpectedEOFinParseCommentBlock)
            {
                throw new TokenReadError(this);
            }
            catch (Exception e)
            {
                if (errors.Count > 0)
                    return null;
                else
                    throw;
            }

        }

        ////////////////////////////////////tasha_16.04.2010
        /// SSM ������� �� pascalabc_lparser_rules ����, �.�. ��� partial �����, � �� ����� �������������� �������������. ������ �������� ����
        int lambda_num = 0;
        List<function_lambda_definition> pascalABC_lambda_definitions = new List<function_lambda_definition>();
        List<var_def_statement> pascalABC_var_statements = new List<var_def_statement>();
        List<type_declaration> pascalABC_type_declarations = new List<type_declaration>();
        procedure_definition lambda(function_lambda_definition _function_lambda_definition)
        {
            procedure_definition _func_def = new procedure_definition();
            method_name _method_name1 = new method_name(null,null, new SyntaxTree.ident(_function_lambda_definition.lambda_name), null);
            parsertools.create_source_context(_method_name1, _method_name1.meth_name, _method_name1.meth_name);
            function_header _function_header1 = new function_header();

            object rt1 = new object();
            _function_header1.name = _method_name1;
            if (_function_header1.name.meth_name is template_type_name)
            {
                _function_header1.template_args = (_function_header1.name.meth_name as template_type_name).template_args;
                ident id = new ident(_function_header1.name.meth_name.name);
                parsertools.create_source_context(id, _function_header1.name.meth_name, _function_header1.name.meth_name);
                _function_header1.name.meth_name = id;
            }

            SyntaxTree.formal_parameters fps = new PascalABCCompiler.SyntaxTree.formal_parameters();
            _function_header1.parameters = _function_lambda_definition.formal_parameters;//fps;

            /*SyntaxTree.named_type_reference _named_type_reference = new SyntaxTree.named_type_reference();
            SyntaxTree.ident idtype = new SyntaxTree.ident("object");
            _named_type_reference.source_context = idtype.source_context;
            _named_type_reference.names.Add(idtype);
            rt1 = _named_type_reference;
            _function_header1.return_type = (SyntaxTree.type_definition)_named_type_reference;*/
            _function_header1.return_type = _function_lambda_definition.return_type;

            _function_header1.of_object = false;
            _function_header1.class_keyword = false;
            token_info _token_info = new token_info("function");
            _token_info.source_context = parsertools.GetTokenSourceContext();
            parsertools.create_source_context(_function_header1, _token_info, _token_info);

            SyntaxTree.block _block1 = new SyntaxTree.block(null, null);
            SyntaxTree.statement_list sl1 = new SyntaxTree.statement_list();
            sl1.subnodes.Add(_function_lambda_definition.proc_body);
            _block1.program_code = sl1;
            _func_def.proc_header = _function_header1;
            _func_def.proc_body = (SyntaxTree.proc_block)_block1;
            if (_function_lambda_definition.defs != null)
            {
                if (((block)_func_def.proc_body).defs == null)
                    ((block)_func_def.proc_body).defs = new declarations();
                for (int l = 0; l < _function_lambda_definition.defs.Count; l++)
                    ((block)_func_def.proc_body).defs.defs.Add(_function_lambda_definition.defs[l] as procedure_definition);
            }
            _function_lambda_definition.proc_definition = _func_def;
            parsertools.create_source_context(_func_def, _function_header1, _function_header1);
            return _func_def;
        }
        public function_lambda_definition find_pascalABC_lambda_name(string name)
        {
            int i = 0;
            while (i < pascalABC_lambda_definitions.Count && (pascalABC_lambda_definitions[i] == null || ((function_lambda_definition)pascalABC_lambda_definitions[i]).lambda_name != name))
                i++;
            if (i < pascalABC_lambda_definitions.Count)
                return (function_lambda_definition)pascalABC_lambda_definitions[i];
            else
                return null;
        }
        public var_def_statement find_var_statements(string name)
        {
            int i = pascalABC_var_statements.Count - 1;
            bool b = false;
            while (!b && i >= 0)
            {
                var_def_statement vds = (var_def_statement)pascalABC_var_statements[i];
                int j = 0;
                while (j < vds.vars.idents.Count &&
                    vds.vars.idents[j].name != name)
                    j++;
                if (j < vds.vars.idents.Count)
                    b = true;
                else
                    i--;
            }
            if (i >= 0 && i < pascalABC_var_statements.Count &&
                ((var_def_statement)pascalABC_var_statements[i]).vars_type != null)
                return (var_def_statement)pascalABC_var_statements[i];
            else
                return null;
        }
        public ident func_decl_lambda(object lr0, object lr2)
        {
            statement_list _statement_list = (statement_list)lr2;
            expression_list _expression_list = new expression_list();
            ident_list _i_l = new ident_list();
            formal_parameters _formal_parameters = new formal_parameters();
            if (lr0 != null)
            {
                List<object> ar = (List<object>)lr0;
                for (int i = 0; i < ar.Count; i++)
                    if (ar[i] is ident)
                        _i_l.idents.Add((ident)ar[i]);
                    else
                        _i_l.idents.Add(((var_def_statement)ar[i]).vars.idents[0]);

                for (int i = 0; i < _i_l.idents.Count; i++)
                    _expression_list.expressions.Add(_i_l.idents[i]);

                for (int i = 0; i < ar.Count; i++)
                {
                    ident_list _ident_list = new ident_list();
                    ident id = _i_l.idents[i];
                    _ident_list.idents.Add(id);
                    string name_param = id.name;
                    typed_parameters _typed_parameters = null;
                    int k = 0;
                    {
                        named_type_reference _named_type_reference = new named_type_reference();
                        type_definition t_d = new type_definition();
                        if (ar[i] is ident)
                        {
                            ident idtype = new ident("object");
                            _named_type_reference.names.Add(idtype);
                            t_d = (type_definition)_named_type_reference;
                        }
                        else
                        {
                            t_d = ((var_def_statement)ar[i]).vars_type;
                        }
                        _typed_parameters = new typed_parameters(_ident_list, t_d, parametr_kind.none, null);
                        parsertools.create_source_context(_typed_parameters, _ident_list, t_d);

                    }
                    _formal_parameters.params_list.Add(_typed_parameters);
                }
            }
            //////////////////////////
            named_type_reference _named_type_reference1 = new named_type_reference();
            ident idtype1 = new ident("object");
            _named_type_reference1.source_context = idtype1.source_context;
            _named_type_reference1.names.Add(idtype1);
            /////////////////////////////
            lambda_num++;
            function_lambda_definition _procedure_definition = new function_lambda_definition();
            _procedure_definition.formal_parameters = _formal_parameters;
            _procedure_definition.return_type = (type_definition)_named_type_reference1;
            _procedure_definition.ident_list = _i_l;
            _procedure_definition.proc_body = null;
            _procedure_definition.parameters = _expression_list;
            _procedure_definition.lambda_name = "__lambda__" + lambda_num;
            //new function_lambda_definition(_formal_parameters, (type_definition)_named_type_reference1, _i_l, null, _expression_list, "lambda" + lambda_num);
            object rt = _i_l;
            _procedure_definition.proc_body = _statement_list;

            //////////////////////////////vnutrennie lambda
            if (_procedure_definition.defs == null)
                _procedure_definition.defs = new List<declaration>();
            while (pascalABC_lambda_definitions.Count > 0 && pascalABC_lambda_definitions[pascalABC_lambda_definitions.Count - 1] != null)
            {
                _procedure_definition.defs.Add(lambda((function_lambda_definition)pascalABC_lambda_definitions[pascalABC_lambda_definitions.Count - 1]));
                pascalABC_lambda_definitions.RemoveAt(pascalABC_lambda_definitions.Count - 1);
            }
            if (pascalABC_lambda_definitions.Count > 0 && pascalABC_lambda_definitions[pascalABC_lambda_definitions.Count - 1] == null)
                pascalABC_lambda_definitions.RemoveAt(pascalABC_lambda_definitions.Count - 1);
            pascalABC_lambda_definitions.Add(_procedure_definition);
            ///////////////////////////////////////////////
            parsertools.create_source_context(_procedure_definition, _expression_list, rt);
            ident _name = new ident(_procedure_definition.lambda_name);
            if (lr0 != null)
                _name.source_context = _i_l.idents[0].source_context;
            return _name;
        }

        public List<object> ident_list11(object lr1, object lr3)
        {
            List<object> ar = (List<object>)lr3;
            ar.Insert(0, lr1);
            return ar;
        }

        public List<object> ident_list12(object lr0)
        {
            List<object> ar = new List<object>();
            ar.Add(lr0);
            return ar;
        }

        public List<object> ident_list21(object lr0, object lr2)
        {
            List<object> ar = (List<object>)lr0;
            ar.Add(lr2);
            return ar;
        }

        public List<object> ident_list13(object lr1, object lr3, object lr5)
        {
            List<object> ar = (List<object>)lr5;
            //named_type_reference n_t_r = (named_type_reference)lr3;
            var_def_statement vds = new var_def_statement();
            vds.vars = new ident_list();
            vds.vars.idents.Add((ident)lr1);
            vds.vars_type = (type_definition)lr3;//n_t_r;
            ar.Insert(0, vds);
            return ar;
        }

        public List<object> ident_list14(object lr1, object lr3)
        {
            List<object> ar = new List<object>();
            //named_type_reference n_t_r = (named_type_reference)lr3;
            var_def_statement vds = new var_def_statement();
            vds.vars = new ident_list();
            vds.vars.idents.Add((ident)lr1);
            vds.vars_type = (type_definition)lr3;
            ar.Add(vds);
            return ar;
        }

        public void add_lambda_to_program_block(block _block)
        {
            //tasha 16.04.2010 
            if (pascalABC_lambda_definitions.Count > 0)
            {
                if (_block.defs == null)
                    _block.defs = new declarations();
                for (int i = 0; i < pascalABC_lambda_definitions.Count; i++)
                    _block.defs.defs.Add(lambda((function_lambda_definition)pascalABC_lambda_definitions[i]));
                pascalABC_lambda_definitions.Clear();
            }
        }

        public void add_lambda(object lr1, procedure_definition _procedure_definition)
        {
            if (pascalABC_lambda_definitions.Count > 0)//tasha 16.04.2010
            {
                block _block = (block)lr1;
                if (_block.defs == null)
                    _block.defs = new declarations();
                for (int i = 0; i < pascalABC_lambda_definitions.Count; i++)
                    _block.defs.defs.Add(lambda((function_lambda_definition)pascalABC_lambda_definitions[i]));
                pascalABC_lambda_definitions.Clear();
                _procedure_definition.proc_body = (proc_block)_block;
            }
            else
                //////////////////////////tasha 16.04.2010
                _procedure_definition.proc_body = (proc_block)lr1;
        }

        public void for_assignment(object lr0, object lr2)
        {
            if (lr0 is ident && lr2 is ident && ((ident)lr2).name.Contains("__lambda__"))
            {
                string type_name = "";
                var_def_statement vds = find_var_statements(((ident)lr0).name);
                if (vds != null)
                    type_name = ((named_type_reference)vds.vars_type).names[0].name;
                if (type_name != "")
                {
                    int ii = 0;
                    while (ii < pascalABC_type_declarations.Count &&
                        ((type_declaration)pascalABC_type_declarations[ii]).type_name.name != type_name)
                        ii++;
                    if (ii < pascalABC_type_declarations.Count)
                    {
                        type_definition td = ((type_declaration)pascalABC_type_declarations[ii]).type_def;
                        function_lambda_definition fld = find_pascalABC_lambda_name(((ident)lr2).name);
                        fld.return_type = ((function_header)td).return_type;
                        for (int k = 0; k < fld.formal_parameters.params_list.Count && k < ((function_header)td).parameters.params_list.Count; k++)
                            fld.formal_parameters.params_list[k].vars_type = ((function_header)td).parameters.params_list[k].vars_type;
                    }
                    pascalABC_var_statements.Remove(vds);
                }
            }
        }

    }

}
