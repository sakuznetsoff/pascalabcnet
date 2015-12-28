// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  MAINCOMPUTER
// DateTime: 29.07.2010 22:24:20
// UserName: JCommander
// Input file <oberon00.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using PascalABCCompiler.SyntaxTree;
using PascalABCCompiler.Errors;
using PascalABCCompiler.Oberon00Parser;

namespace GPPGParserScanner
{
public enum Tokens {
    error=1,EOF=2,ID=3,STRING_CONST=4,INTNUM=5,REALNUM=6,
    LONGINTNUM=7,TRUE=8,FALSE=9,CHAR_CONST=10,PLUS=11,MINUS=12,
    MULT=13,DIVIDE=14,AND=15,OR=16,LT=17,GT=18,
    LE=19,GE=20,EQ=21,NE=22,DIV=23,MOD=24,
    NOT=25,ASSIGN=26,SEMICOLUMN=27,LPAREN=28,RPAREN=29,COLUMN=30,
    COMMA=31,COLON=32,EXCLAMATION=33,LBRACE=34,RBRACE=35,DOUBLEPOINT=36,
    IF=37,THEN=38,ELSE=39,BEGIN=40,END=41,WHILE=42,
    DO=43,MODULE=44,CONST=45,VAR=46,INVISIBLE=47,PROCEDURE=48,
    ODD=49,UMINUS=50,UPLUS=51};

public struct ValueType
{ 
		public bool bVal;  
		public string sVal; 
		public int iVal; 
		public long lVal;								// Длинное целое
		public char cVal;
		public double rVal;
		public pascal_set_constant sc;					// Константа - множество
		public named_type_reference ntr;				// Именованное определение типа
		public ident_list il;							// Список идентификаторов
		public ident id;								// Идентификатор
		public var_def_statement vds;					// Описание переменных
		public variable_definitions vdss;				// Секция описания переменных
		public expression ex;							// Выражение
		public expression_list el;						// Список выражений
		public block bl;								// Программный блок
		public statement st;							// Оператор
		public statement_list sl;						// Список операторов
		public declaration decsec;						// Описание
		public declarations decl;						// Список описаний
		public Operators op;							
		public simple_const_definition scd;				// Определение константы
		public consts_definitions_list cdl;				// Список описаний констант		
		public procedure_definition pd;					// Описание процедуры
	}
// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

public class GPPGParser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from oberon00.y
// Эти объявления добавляются в класс GPPGParser, представляющий собой парсер, генерируемый системой gppg
    public syntax_tree_node root; // Корневой узел синтаксического дерева 
    public GPPGParser(AbstractScanner<ValueType, LexLocation> scanner) : base(scanner) { }
  // End verbatim content from oberon00.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[83];
  private static State[] states = new State[150];
  private static string[] nonTerms = new string[] {
      "module", "ident", "IDList", "type", "SetConstant", "SetElemList", "expr", 
      "ConstExpr", "SetElem", "Assignment", "IfStatement", "WhileStatement", 
      "WriteStatement", "Statement", "EmptyStatement", "ProcCallStatement", "StatementSequence", 
      "Declarations", "DeclarationsSect", "VarDecl", "VarDeclarations", "VarDeclarationsSect", 
      "ConstDecl", "ConstDeclarations", "ConstDeclarationsSect", "ProcedureDeclarationSect", 
      "mainblock", "factparams", "maybevar", "$accept", "maybeformalparams", 
      "maybereturn", "FPList", "FPSect", };

  static GPPGParser() {
    states[0] = new State(new int[]{44,3,47,148},new int[]{-1,1});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{3,9},new int[]{-2,4});
    states[4] = new State(new int[]{27,5});
    states[5] = new State(-71,new int[]{-27,6,-18,10});
    states[6] = new State(new int[]{3,9},new int[]{-2,7});
    states[7] = new State(new int[]{31,8});
    states[8] = new State(-2);
    states[9] = new State(-4);
    states[10] = new State(new int[]{40,11,46,104,45,117,48,127},new int[]{-19,102,-22,103,-25,116,-26,126});
    states[11] = new State(new int[]{3,9,37,82,42,92,33,98,41,-47,27,-47},new int[]{-17,12,-14,90,-10,16,-2,17,-11,81,-12,91,-13,97,-16,100,-15,101});
    states[12] = new State(new int[]{41,13,27,14});
    states[13] = new State(-5);
    states[14] = new State(new int[]{3,9,37,82,42,92,33,98,41,-47,27,-47,39,-47},new int[]{-14,15,-10,16,-2,17,-11,81,-12,91,-13,97,-16,100,-15,101});
    states[15] = new State(-55);
    states[16] = new State(-48);
    states[17] = new State(new int[]{26,18,28,75});
    states[18] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,19,-2,48,-5,65});
    states[19] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46,41,-39,27,-39,39,-39});
    states[20] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,21,-2,48,-5,65});
    states[21] = new State(new int[]{11,-24,12,-24,13,24,14,26,23,28,24,30,15,32,16,-24,21,-24,22,-24,17,-24,19,-24,18,-24,20,-24,41,-24,27,-24,39,-24,29,-24,36,-24,35,-24,30,-24,38,-24,43,-24,2,-24});
    states[22] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,23,-2,48,-5,65});
    states[23] = new State(new int[]{11,-25,12,-25,13,24,14,26,23,28,24,30,15,32,16,-25,21,-25,22,-25,17,-25,19,-25,18,-25,20,-25,41,-25,27,-25,39,-25,29,-25,36,-25,35,-25,30,-25,38,-25,43,-25,2,-25});
    states[24] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,25,-2,48,-5,65});
    states[25] = new State(new int[]{11,-26,12,-26,13,-26,14,-26,23,28,24,30,15,-26,16,-26,21,-26,22,-26,17,-26,19,-26,18,-26,20,-26,41,-26,27,-26,39,-26,29,-26,36,-26,35,-26,30,-26,38,-26,43,-26,2,-26});
    states[26] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,27,-2,48,-5,65});
    states[27] = new State(new int[]{11,-27,12,-27,13,-27,14,-27,23,28,24,30,15,-27,16,-27,21,-27,22,-27,17,-27,19,-27,18,-27,20,-27,41,-27,27,-27,39,-27,29,-27,36,-27,35,-27,30,-27,38,-27,43,-27,2,-27});
    states[28] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,29,-2,48,-5,65});
    states[29] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46,41,-28,27,-28,39,-28,29,-28,36,-28,35,-28,30,-28,38,-28,43,-28,2,-28});
    states[30] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,31,-2,48,-5,65});
    states[31] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46,41,-29,27,-29,39,-29,29,-29,36,-29,35,-29,30,-29,38,-29,43,-29,2,-29});
    states[32] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,33,-2,48,-5,65});
    states[33] = new State(new int[]{11,-30,12,-30,13,-30,14,-30,23,28,24,30,15,-30,16,-30,21,-30,22,-30,17,-30,19,-30,18,-30,20,-30,41,-30,27,-30,39,-30,29,-30,36,-30,35,-30,30,-30,38,-30,43,-30,2,-30});
    states[34] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,35,-2,48,-5,65});
    states[35] = new State(new int[]{11,-31,12,-31,13,24,14,26,23,28,24,30,15,32,16,-31,21,-31,22,-31,17,-31,19,-31,18,-31,20,-31,41,-31,27,-31,39,-31,29,-31,36,-31,35,-31,30,-31,38,-31,43,-31,2,-31});
    states[36] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,37,-2,48,-5,65});
    states[37] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,-32,22,-32,17,-32,19,-32,18,-32,20,-32,41,-32,27,-32,39,-32,29,-32,36,-32,35,-32,30,-32,38,-32,43,-32,2,-32});
    states[38] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,39,-2,48,-5,65});
    states[39] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,-33,22,-33,17,-33,19,-33,18,-33,20,-33,41,-33,27,-33,39,-33,29,-33,36,-33,35,-33,30,-33,38,-33,43,-33,2,-33});
    states[40] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,41,-2,48,-5,65});
    states[41] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,-34,22,-34,17,-34,19,-34,18,-34,20,-34,41,-34,27,-34,39,-34,29,-34,36,-34,35,-34,30,-34,38,-34,43,-34,2,-34});
    states[42] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,43,-2,48,-5,65});
    states[43] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,-35,22,-35,17,-35,19,-35,18,-35,20,-35,41,-35,27,-35,39,-35,29,-35,36,-35,35,-35,30,-35,38,-35,43,-35,2,-35});
    states[44] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,45,-2,48,-5,65});
    states[45] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,-36,22,-36,17,-36,19,-36,18,-36,20,-36,41,-36,27,-36,39,-36,29,-36,36,-36,35,-36,30,-36,38,-36,43,-36,2,-36});
    states[46] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,47,-2,48,-5,65});
    states[47] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,-37,22,-37,17,-37,19,-37,18,-37,20,-37,41,-37,27,-37,39,-37,29,-37,36,-37,35,-37,30,-37,38,-37,43,-37,2,-37});
    states[48] = new State(-12);
    states[49] = new State(-13);
    states[50] = new State(-14);
    states[51] = new State(-15);
    states[52] = new State(-16);
    states[53] = new State(-17);
    states[54] = new State(-18);
    states[55] = new State(-19);
    states[56] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,57,-2,48,-5,65});
    states[57] = new State(new int[]{11,-20,12,-20,13,-20,14,-20,23,28,24,30,15,-20,16,-20,21,-20,22,-20,17,-20,19,-20,18,-20,20,-20,41,-20,27,-20,39,-20,29,-20,36,-20,35,-20,30,-20,38,-20,43,-20,2,-20});
    states[58] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,59,-2,48,-5,65});
    states[59] = new State(new int[]{11,-21,12,-21,13,-21,14,-21,23,28,24,30,15,-21,16,-21,21,-21,22,-21,17,-21,19,-21,18,-21,20,-21,41,-21,27,-21,39,-21,29,-21,36,-21,35,-21,30,-21,38,-21,43,-21,2,-21});
    states[60] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,61,-2,48,-5,65});
    states[61] = new State(new int[]{29,62,11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46});
    states[62] = new State(-22);
    states[63] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,64,-2,48,-5,65});
    states[64] = new State(new int[]{11,-23,12,-23,13,-23,14,-23,23,28,24,30,15,-23,16,-23,21,-23,22,-23,17,-23,19,-23,18,-23,20,-23,41,-23,27,-23,39,-23,29,-23,36,-23,35,-23,30,-23,38,-23,43,-23,2,-23});
    states[65] = new State(-38);
    states[66] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66,35,-9,30,-9},new int[]{-6,67,-9,74,-7,71,-2,48,-5,65});
    states[67] = new State(new int[]{35,68,30,69});
    states[68] = new State(-6);
    states[69] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-9,70,-7,71,-2,48,-5,65});
    states[70] = new State(-8);
    states[71] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46,36,72,35,-10,30,-10});
    states[72] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,73,-2,48,-5,65});
    states[73] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46,35,-11,30,-11});
    states[74] = new State(-7);
    states[75] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-28,76,-7,80,-2,48,-5,65});
    states[76] = new State(new int[]{29,77,30,78});
    states[77] = new State(-46);
    states[78] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,79,-2,48,-5,65});
    states[79] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46,29,-45,30,-45});
    states[80] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46,29,-44,30,-44});
    states[81] = new State(-49);
    states[82] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,83,-2,48,-5,65});
    states[83] = new State(new int[]{38,84,11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46});
    states[84] = new State(new int[]{3,9,37,82,42,92,33,98,41,-47,39,-47,27,-47},new int[]{-17,85,-14,90,-10,16,-2,17,-11,81,-12,91,-13,97,-16,100,-15,101});
    states[85] = new State(new int[]{41,86,39,87,27,14});
    states[86] = new State(-40);
    states[87] = new State(new int[]{3,9,37,82,42,92,33,98,41,-47,27,-47},new int[]{-17,88,-14,90,-10,16,-2,17,-11,81,-12,91,-13,97,-16,100,-15,101});
    states[88] = new State(new int[]{41,89,27,14});
    states[89] = new State(-41);
    states[90] = new State(-54);
    states[91] = new State(-50);
    states[92] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,93,-2,48,-5,65});
    states[93] = new State(new int[]{43,94,11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46});
    states[94] = new State(new int[]{3,9,37,82,42,92,33,98,41,-47,27,-47},new int[]{-17,95,-14,90,-10,16,-2,17,-11,81,-12,91,-13,97,-16,100,-15,101});
    states[95] = new State(new int[]{41,96,27,14});
    states[96] = new State(-42);
    states[97] = new State(-51);
    states[98] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,99,-2,48,-5,65});
    states[99] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46,41,-43,27,-43,39,-43});
    states[100] = new State(-52);
    states[101] = new State(-53);
    states[102] = new State(-72);
    states[103] = new State(-68);
    states[104] = new State(new int[]{3,9},new int[]{-21,105,-20,115,-3,107,-2,114});
    states[105] = new State(new int[]{3,9,40,-67,46,-67,45,-67,48,-67},new int[]{-20,106,-3,107,-2,114});
    states[106] = new State(-61);
    states[107] = new State(new int[]{32,108,30,112});
    states[108] = new State(new int[]{3,111},new int[]{-4,109});
    states[109] = new State(new int[]{27,110});
    states[110] = new State(-59);
    states[111] = new State(-56);
    states[112] = new State(new int[]{3,9},new int[]{-2,113});
    states[113] = new State(-58);
    states[114] = new State(-57);
    states[115] = new State(-60);
    states[116] = new State(-69);
    states[117] = new State(new int[]{3,9},new int[]{-24,118,-23,125,-2,120});
    states[118] = new State(new int[]{3,9,40,-66,46,-66,45,-66,48,-66},new int[]{-23,119,-2,120});
    states[119] = new State(-65);
    states[120] = new State(new int[]{21,121});
    states[121] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-8,122,-7,124,-2,48,-5,65});
    states[122] = new State(new int[]{27,123});
    states[123] = new State(-62);
    states[124] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46,27,-63});
    states[125] = new State(-64);
    states[126] = new State(-70);
    states[127] = new State(new int[]{3,9},new int[]{-2,128});
    states[128] = new State(new int[]{28,137,30,-74,27,-74},new int[]{-31,129});
    states[129] = new State(new int[]{30,135,27,-76},new int[]{-32,130});
    states[130] = new State(new int[]{27,131});
    states[131] = new State(-71,new int[]{-27,132,-18,10});
    states[132] = new State(new int[]{3,9},new int[]{-2,133});
    states[133] = new State(new int[]{27,134});
    states[134] = new State(-73);
    states[135] = new State(new int[]{3,111},new int[]{-4,136});
    states[136] = new State(-77);
    states[137] = new State(new int[]{46,146,3,-81},new int[]{-33,138,-34,147,-29,142});
    states[138] = new State(new int[]{29,139,27,140});
    states[139] = new State(-75);
    states[140] = new State(new int[]{46,146,3,-81},new int[]{-34,141,-29,142});
    states[141] = new State(-79);
    states[142] = new State(new int[]{3,9},new int[]{-3,143,-2,114});
    states[143] = new State(new int[]{32,144,30,112});
    states[144] = new State(new int[]{3,111},new int[]{-4,145});
    states[145] = new State(-80);
    states[146] = new State(-82);
    states[147] = new State(-78);
    states[148] = new State(new int[]{3,9,5,49,7,50,6,51,8,52,9,53,10,54,4,55,12,56,11,58,28,60,25,63,34,66},new int[]{-7,149,-2,48,-5,65});
    states[149] = new State(new int[]{11,20,12,22,13,24,14,26,23,28,24,30,15,32,16,34,21,36,22,38,17,40,19,42,18,44,20,46,2,-3});

    rules[1] = new Rule(-30, new int[]{-1,2});
    rules[2] = new Rule(-1, new int[]{44,-2,27,-27,-2,31});
    rules[3] = new Rule(-1, new int[]{47,-7});
    rules[4] = new Rule(-2, new int[]{3});
    rules[5] = new Rule(-27, new int[]{-18,40,-17,41});
    rules[6] = new Rule(-5, new int[]{34,-6,35});
    rules[7] = new Rule(-6, new int[]{-9});
    rules[8] = new Rule(-6, new int[]{-6,30,-9});
    rules[9] = new Rule(-6, new int[]{});
    rules[10] = new Rule(-9, new int[]{-7});
    rules[11] = new Rule(-9, new int[]{-7,36,-7});
    rules[12] = new Rule(-7, new int[]{-2});
    rules[13] = new Rule(-7, new int[]{5});
    rules[14] = new Rule(-7, new int[]{7});
    rules[15] = new Rule(-7, new int[]{6});
    rules[16] = new Rule(-7, new int[]{8});
    rules[17] = new Rule(-7, new int[]{9});
    rules[18] = new Rule(-7, new int[]{10});
    rules[19] = new Rule(-7, new int[]{4});
    rules[20] = new Rule(-7, new int[]{12,-7});
    rules[21] = new Rule(-7, new int[]{11,-7});
    rules[22] = new Rule(-7, new int[]{28,-7,29});
    rules[23] = new Rule(-7, new int[]{25,-7});
    rules[24] = new Rule(-7, new int[]{-7,11,-7});
    rules[25] = new Rule(-7, new int[]{-7,12,-7});
    rules[26] = new Rule(-7, new int[]{-7,13,-7});
    rules[27] = new Rule(-7, new int[]{-7,14,-7});
    rules[28] = new Rule(-7, new int[]{-7,23,-7});
    rules[29] = new Rule(-7, new int[]{-7,24,-7});
    rules[30] = new Rule(-7, new int[]{-7,15,-7});
    rules[31] = new Rule(-7, new int[]{-7,16,-7});
    rules[32] = new Rule(-7, new int[]{-7,21,-7});
    rules[33] = new Rule(-7, new int[]{-7,22,-7});
    rules[34] = new Rule(-7, new int[]{-7,17,-7});
    rules[35] = new Rule(-7, new int[]{-7,19,-7});
    rules[36] = new Rule(-7, new int[]{-7,18,-7});
    rules[37] = new Rule(-7, new int[]{-7,20,-7});
    rules[38] = new Rule(-7, new int[]{-5});
    rules[39] = new Rule(-10, new int[]{-2,26,-7});
    rules[40] = new Rule(-11, new int[]{37,-7,38,-17,41});
    rules[41] = new Rule(-11, new int[]{37,-7,38,-17,39,-17,41});
    rules[42] = new Rule(-12, new int[]{42,-7,43,-17,41});
    rules[43] = new Rule(-13, new int[]{33,-7});
    rules[44] = new Rule(-28, new int[]{-7});
    rules[45] = new Rule(-28, new int[]{-28,30,-7});
    rules[46] = new Rule(-16, new int[]{-2,28,-28,29});
    rules[47] = new Rule(-15, new int[]{});
    rules[48] = new Rule(-14, new int[]{-10});
    rules[49] = new Rule(-14, new int[]{-11});
    rules[50] = new Rule(-14, new int[]{-12});
    rules[51] = new Rule(-14, new int[]{-13});
    rules[52] = new Rule(-14, new int[]{-16});
    rules[53] = new Rule(-14, new int[]{-15});
    rules[54] = new Rule(-17, new int[]{-14});
    rules[55] = new Rule(-17, new int[]{-17,27,-14});
    rules[56] = new Rule(-4, new int[]{3});
    rules[57] = new Rule(-3, new int[]{-2});
    rules[58] = new Rule(-3, new int[]{-3,30,-2});
    rules[59] = new Rule(-20, new int[]{-3,32,-4,27});
    rules[60] = new Rule(-21, new int[]{-20});
    rules[61] = new Rule(-21, new int[]{-21,-20});
    rules[62] = new Rule(-23, new int[]{-2,21,-8,27});
    rules[63] = new Rule(-8, new int[]{-7});
    rules[64] = new Rule(-24, new int[]{-23});
    rules[65] = new Rule(-24, new int[]{-24,-23});
    rules[66] = new Rule(-25, new int[]{45,-24});
    rules[67] = new Rule(-22, new int[]{46,-21});
    rules[68] = new Rule(-19, new int[]{-22});
    rules[69] = new Rule(-19, new int[]{-25});
    rules[70] = new Rule(-19, new int[]{-26});
    rules[71] = new Rule(-18, new int[]{});
    rules[72] = new Rule(-18, new int[]{-18,-19});
    rules[73] = new Rule(-26, new int[]{48,-2,-31,-32,27,-27,-2,27});
    rules[74] = new Rule(-31, new int[]{});
    rules[75] = new Rule(-31, new int[]{28,-33,29});
    rules[76] = new Rule(-32, new int[]{});
    rules[77] = new Rule(-32, new int[]{30,-4});
    rules[78] = new Rule(-33, new int[]{-34});
    rules[79] = new Rule(-33, new int[]{-33,27,-34});
    rules[80] = new Rule(-34, new int[]{-29,-3,32,-4});
    rules[81] = new Rule(-29, new int[]{});
    rules[82] = new Rule(-29, new int[]{46});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 2: // module -> MODULE, ident, SEMICOLUMN, mainblock, ident, COMMA
{
		if (ValueStack[ValueStack.Depth-5].id.name != ValueStack[ValueStack.Depth-2].id.name)
			PT.AddError("Имя " + ValueStack[ValueStack.Depth-2].id.name + " должно совпадать с именем модуля " + ValueStack[ValueStack.Depth-5].id.name, LocationStack[LocationStack.Depth-2]);
		
		// Подключение стандартного модуля Oberon00System, написанного на PascalABC.NET
		var ul = new uses_list("Oberon00System");
		
		// Формирование модуля основной программы (используется фабричный метод вместо конструктора)
		root = program_module.create(ValueStack[ValueStack.Depth-5].id, ul, ValueStack[ValueStack.Depth-3].bl, CurrentLocationSpan);
    }
        break;
      case 3: // module -> INVISIBLE, expr
{ // Для Intellisense
		root = ValueStack[ValueStack.Depth-1].ex;
	}
        break;
      case 4: // ident -> ID
{
		CurrentSemanticValue.id = new ident(ValueStack[ValueStack.Depth-1].sVal,CurrentLocationSpan); 
	}
        break;
      case 5: // mainblock -> Declarations, BEGIN, StatementSequence, END
{
		CurrentSemanticValue.bl = new block(ValueStack[ValueStack.Depth-4].decl, ValueStack[ValueStack.Depth-2].sl, CurrentLocationSpan);
	}
        break;
      case 6: // SetConstant -> LBRACE, SetElemList, RBRACE
{
		CurrentSemanticValue.sc = ValueStack[ValueStack.Depth-2].sc;
	}
        break;
      case 7: // SetElemList -> SetElem
{
		CurrentSemanticValue.sc = new pascal_set_constant();
		CurrentSemanticValue.sc.Add(ValueStack[ValueStack.Depth-1].ex);
	}
        break;
      case 8: // SetElemList -> SetElemList, COLUMN, SetElem
{
		CurrentSemanticValue.sc = ValueStack[ValueStack.Depth-3].sc;
		CurrentSemanticValue.sc.Add(ValueStack[ValueStack.Depth-1].ex);
	}
        break;
      case 9: // SetElemList -> /* empty */
{
		CurrentSemanticValue.sc = new pascal_set_constant();
	}
        break;
      case 11: // SetElem -> expr, DOUBLEPOINT, expr
{
		CurrentSemanticValue.ex = new diapason_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex);
	}
        break;
      case 12: // expr -> ident
{
		CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-1].id;
	}
        break;
      case 13: // expr -> INTNUM
{ 
		CurrentSemanticValue.ex = new int32_const(ValueStack[ValueStack.Depth-1].iVal,CurrentLocationSpan); 		
	}
        break;
      case 14: // expr -> LONGINTNUM
{
		CurrentSemanticValue.ex = new int64_const(ValueStack[ValueStack.Depth-1].lVal, CurrentLocationSpan); 		
	}
        break;
      case 15: // expr -> REALNUM
{
		CurrentSemanticValue.ex = new double_const(ValueStack[ValueStack.Depth-1].rVal, CurrentLocationSpan);
	}
        break;
      case 16: // expr -> TRUE
{
		CurrentSemanticValue.ex = new bool_const(true,CurrentLocationSpan);
	}
        break;
      case 17: // expr -> FALSE
{
		CurrentSemanticValue.ex = new bool_const(false,CurrentLocationSpan);
	}
        break;
      case 18: // expr -> CHAR_CONST
{
		CurrentSemanticValue.ex = new char_const(ValueStack[ValueStack.Depth-1].cVal, CurrentLocationSpan);
	}
        break;
      case 19: // expr -> STRING_CONST
{
		CurrentSemanticValue.ex = new string_const(ValueStack[ValueStack.Depth-1].sVal, CurrentLocationSpan);
	}
        break;
      case 20: // expr -> MINUS, expr
{
		CurrentSemanticValue.ex = new un_expr(ValueStack[ValueStack.Depth-1].ex,Operators.Minus,CurrentLocationSpan);
	}
        break;
      case 21: // expr -> PLUS, expr
{
		CurrentSemanticValue.ex = new un_expr(ValueStack[ValueStack.Depth-1].ex,Operators.Plus,CurrentLocationSpan);
	}
        break;
      case 22: // expr -> LPAREN, expr, RPAREN
{CurrentSemanticValue.ex = ValueStack[ValueStack.Depth-2].ex;}
        break;
      case 23: // expr -> NOT, expr
{
		CurrentSemanticValue.ex = new un_expr(ValueStack[ValueStack.Depth-1].ex,Operators.LogicalNOT,CurrentLocationSpan);
	}
        break;
      case 24: // expr -> expr, PLUS, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.Plus,CurrentLocationSpan);
	}
        break;
      case 25: // expr -> expr, MINUS, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.Minus,CurrentLocationSpan);
	}
        break;
      case 26: // expr -> expr, MULT, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.Multiplication,CurrentLocationSpan);
	}
        break;
      case 27: // expr -> expr, DIVIDE, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.Division,CurrentLocationSpan);
	}
        break;
      case 28: // expr -> expr, DIV, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, Operators.IntegerDivision, CurrentLocationSpan);
	}
        break;
      case 29: // expr -> expr, MOD, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex, ValueStack[ValueStack.Depth-1].ex, Operators.ModulusRemainder, CurrentLocationSpan);
	}
        break;
      case 30: // expr -> expr, AND, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.LogicalAND,CurrentLocationSpan);
	}
        break;
      case 31: // expr -> expr, OR, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.LogicalOR,CurrentLocationSpan);
	}
        break;
      case 32: // expr -> expr, EQ, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.Equal,CurrentLocationSpan);
	}
        break;
      case 33: // expr -> expr, NE, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.NotEqual,CurrentLocationSpan);
	}
        break;
      case 34: // expr -> expr, LT, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.Less,CurrentLocationSpan);
	}
        break;
      case 35: // expr -> expr, LE, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.LessEqual,CurrentLocationSpan);
	}
        break;
      case 36: // expr -> expr, GT, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.Greater,CurrentLocationSpan);
	}
        break;
      case 37: // expr -> expr, GE, expr
{
		CurrentSemanticValue.ex = new bin_expr(ValueStack[ValueStack.Depth-3].ex,ValueStack[ValueStack.Depth-1].ex,Operators.GreaterEqual,CurrentLocationSpan);
	}
        break;
      case 39: // Assignment -> ident, ASSIGN, expr
{
		CurrentSemanticValue.st = new assign(ValueStack[ValueStack.Depth-3].id, ValueStack[ValueStack.Depth-1].ex, Operators.Assignment, CurrentLocationSpan);
	}
        break;
      case 40: // IfStatement -> IF, expr, THEN, StatementSequence, END
{
		CurrentSemanticValue.st = new if_node(ValueStack[ValueStack.Depth-4].ex, ValueStack[ValueStack.Depth-2].sl, null, CurrentLocationSpan);
	}
        break;
      case 41: // IfStatement -> IF, expr, THEN, StatementSequence, ELSE, StatementSequence, END
{
		CurrentSemanticValue.st = new if_node(ValueStack[ValueStack.Depth-6].ex, ValueStack[ValueStack.Depth-4].sl, ValueStack[ValueStack.Depth-2].sl, CurrentLocationSpan);
	}
        break;
      case 42: // WhileStatement -> WHILE, expr, DO, StatementSequence, END
{
		CurrentSemanticValue.st = new while_node(ValueStack[ValueStack.Depth-4].ex, ValueStack[ValueStack.Depth-2].sl, WhileCycleType.While, CurrentLocationSpan);
	}
        break;
      case 43: // WriteStatement -> EXCLAMATION, expr
{
		expression_list el = new expression_list(ValueStack[ValueStack.Depth-1].ex);
		method_call mc = new method_call(el);
		mc.dereferencing_value = new ident("print");
		CurrentSemanticValue.st = mc;
	}
        break;
      case 44: // factparams -> expr
{
		CurrentSemanticValue.el = new expression_list(ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan);
	}
        break;
      case 45: // factparams -> factparams, COLUMN, expr
{
		ValueStack[ValueStack.Depth-3].el.Add(ValueStack[ValueStack.Depth-1].ex,CurrentLocationSpan);
		CurrentSemanticValue.el = ValueStack[ValueStack.Depth-3].el;
	}
        break;
      case 46: // ProcCallStatement -> ident, LPAREN, factparams, RPAREN
{
		CurrentSemanticValue.st = new method_call(ValueStack[ValueStack.Depth-4].id,ValueStack[ValueStack.Depth-2].el,CurrentLocationSpan);
	}
        break;
      case 47: // EmptyStatement -> /* empty */
{
		CurrentSemanticValue.st = new empty_statement();		
	}
        break;
      case 54: // StatementSequence -> Statement
{
		CurrentSemanticValue.sl = new statement_list(ValueStack[ValueStack.Depth-1].st,CurrentLocationSpan);
	}
        break;
      case 55: // StatementSequence -> StatementSequence, SEMICOLUMN, Statement
{
		ValueStack[ValueStack.Depth-3].sl.Add(ValueStack[ValueStack.Depth-1].st,CurrentLocationSpan);
		CurrentSemanticValue.sl = ValueStack[ValueStack.Depth-3].sl;
	}
        break;
      case 56: // type -> ID
{
		CurrentSemanticValue.ntr = new named_type_reference(PT.InternalTypeName(ValueStack[ValueStack.Depth-1].sVal), CurrentLocationSpan);
	}
        break;
      case 57: // IDList -> ident
{
		CurrentSemanticValue.il=new ident_list(ValueStack[ValueStack.Depth-1].id,CurrentLocationSpan);
		
	}
        break;
      case 58: // IDList -> IDList, COLUMN, ident
{
		ValueStack[ValueStack.Depth-3].il.Add(ValueStack[ValueStack.Depth-1].id,CurrentLocationSpan);
		CurrentSemanticValue.il = ValueStack[ValueStack.Depth-3].il;
	}
        break;
      case 59: // VarDecl -> IDList, COLON, type, SEMICOLUMN
{
	  CurrentSemanticValue.vds  = new var_def_statement(ValueStack[ValueStack.Depth-4].il,ValueStack[ValueStack.Depth-2].ntr,null,definition_attribute.None,false,CurrentLocationSpan);
	}
        break;
      case 60: // VarDeclarations -> VarDecl
{
		CurrentSemanticValue.vdss = new variable_definitions(ValueStack[ValueStack.Depth-1].vds,CurrentLocationSpan);
	}
        break;
      case 61: // VarDeclarations -> VarDeclarations, VarDecl
{
		ValueStack[ValueStack.Depth-2].vdss.Add(ValueStack[ValueStack.Depth-1].vds,CurrentLocationSpan);
		CurrentSemanticValue.vdss = ValueStack[ValueStack.Depth-2].vdss;
	}
        break;
      case 62: // ConstDecl -> ident, EQ, ConstExpr, SEMICOLUMN
{
		CurrentSemanticValue.scd = new simple_const_definition(ValueStack[ValueStack.Depth-4].id,ValueStack[ValueStack.Depth-2].ex,CurrentLocationSpan);
	}
        break;
      case 64: // ConstDeclarations -> ConstDecl
{
		CurrentSemanticValue.cdl = new consts_definitions_list(ValueStack[ValueStack.Depth-1].scd,CurrentLocationSpan);
	}
        break;
      case 65: // ConstDeclarations -> ConstDeclarations, ConstDecl
{
		ValueStack[ValueStack.Depth-2].cdl.Add(ValueStack[ValueStack.Depth-1].scd,CurrentLocationSpan); 
		CurrentSemanticValue.cdl = ValueStack[ValueStack.Depth-2].cdl;
	}
        break;
      case 66: // ConstDeclarationsSect -> CONST, ConstDeclarations
{
		CurrentSemanticValue.cdl = ValueStack[ValueStack.Depth-1].cdl;
		CurrentSemanticValue.cdl.source_context = CurrentLocationSpan;
	}
        break;
      case 67: // VarDeclarationsSect -> VAR, VarDeclarations
{
		CurrentSemanticValue.vdss = ValueStack[ValueStack.Depth-1].vdss;
		CurrentSemanticValue.vdss.source_context = CurrentLocationSpan;
	}
        break;
      case 68: // DeclarationsSect -> VarDeclarationsSect
{
		CurrentSemanticValue.decsec = ValueStack[ValueStack.Depth-1].vdss;
	}
        break;
      case 69: // DeclarationsSect -> ConstDeclarationsSect
{
		CurrentSemanticValue.decsec = ValueStack[ValueStack.Depth-1].cdl;
	}
        break;
      case 70: // DeclarationsSect -> ProcedureDeclarationSect
{
		CurrentSemanticValue.decsec = ValueStack[ValueStack.Depth-1].pd;
	}
        break;
      case 71: // Declarations -> /* empty */
{
	  CurrentSemanticValue.decl = new declarations();
	}
        break;
      case 72: // Declarations -> Declarations, DeclarationsSect
{
		if (ValueStack[ValueStack.Depth-1].decsec != null)
			ValueStack[ValueStack.Depth-2].decl.Add(ValueStack[ValueStack.Depth-1].decsec);
		CurrentSemanticValue.decl = ValueStack[ValueStack.Depth-2].decl;
		CurrentSemanticValue.decl.source_context = CurrentLocationSpan;			// Необходимо показать место в программе, т.к. невно это не сделано
										// (например, в конструкторе)
	}
        break;
      case 73: // ProcedureDeclarationSect -> PROCEDURE, ident, maybeformalparams, maybereturn, 
               //                             SEMICOLUMN, mainblock, ident, SEMICOLUMN
{
	
	}
        break;
      case 74: // maybeformalparams -> /* empty */
{
		//$$ = null;
	}
        break;
      case 75: // maybeformalparams -> LPAREN, FPList, RPAREN
{
		//$$ = $2;
	}
        break;
      case 76: // maybereturn -> /* empty */
{
		
	}
        break;
      case 77: // maybereturn -> COLUMN, type
{
	
	}
        break;
      case 78: // FPList -> FPSect
{
	
	}
        break;
      case 79: // FPList -> FPList, SEMICOLUMN, FPSect
{
	
	}
        break;
      case 80: // FPSect -> maybevar, IDList, COLON, type
{
	
	}
        break;
      case 81: // maybevar -> /* empty */
{
		CurrentSemanticValue.bVal = false;
	}
        break;
      case 82: // maybevar -> VAR
{
		CurrentSemanticValue.bVal = true;
	}
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
