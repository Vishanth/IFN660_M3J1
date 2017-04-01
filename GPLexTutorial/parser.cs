// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  DESKTOP-VKITI27
// DateTime: 4/1/2017 11:20:17 AM
// UserName: Juan Camilo
// Input file <parser.y - 3/28/2017 5:45:22 PM>

// options: lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace GPLexTutorial
{
public enum Tokens {
    error=127,EOF=128,NUMBER=129,IDENT=130,FLOATLITERAL=131,STRINGLITERAL=132,
    BOOL=133,ABSTRACT=134,ASSERT=135,BOOLEAN=136,BREAK=137,BYTE=138,
    CASE=139,CATCH=140,CHAR=141,CLASS=142,CONST=143,CONTINUE=144,
    DEFAULT=145,DO=146,DOUBLE=147,ELSE=148,ENUM=149,EXTENDS=150,
    FINAL=151,FINALLY=152,FLOAT=153,FOR=154,IF=155,GOTO=156,
    IMPLEMENTS=157,IMPORT=158,INSTANCEOF=159,INT=160,INTERFACE=161,LONG=162,
    NATIVE=163,NEW=164,PACKAGE=165,PRIVATE=166,PROTECTED=167,PUBLIC=168,
    RETURN=169,SHORT=170,STATIC=171,STRICTFP=172,SUPER=173,SWITCH=174,
    SYNCHRONIZED=175,THIS=176,THROW=177,THROWS=178,TRANSIENT=179,TRY=180,
    VOID=181,VOLATILE=182,WHILE=183,IntegerLiteral=184,CharacterLiteral=185,NULL=186,
    OPERATOR=187,TRUE=188,FALSE=189,EndOfLineComment=190,TraditionalComment=191};

public struct ValueType
#line 4 "parser.y"
{
    public int num;
    public string name;
    public float floatValue;
    public string stringValue;
    public bool boolValue;
}
#line default
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[184];
  private static State[] states = new State[242];
  private static string[] nonTerms = new string[] {
      "CompilationUnit", "$accept", "PackageDeclarations", "ImportDeclarations", 
      "TypeDeclarations", "PackageDeclaration", "PackageModifiers", "ColonSeparatedIdents", 
      "PackageModifier", "Annotation", "Annotations", "NormalAnnotation", "MarkerAnnotation", 
      "SingleElementAnnotation", "ImportDeclaration", "SingleTypeImportDeclaration", 
      "TypeImportOnDemandDeclaration", "SingleStaticImportDeclaration", "StaticImportOnDemandDeclaration", 
      "TypeDeclaration", "ClassDeclaration", "InterfaceDeclaration", "NormalClassDeclaration", 
      "EnumDeclaration", "ClassModifiers", "TypeParameters", "Superclasses", 
      "Superinterfaces", "ClassBody", "Superclass", "ClassType", "TypeArguments", 
      "ClassOrInterfaceType", "InterfaceType", "InterfaceTypeList", "ComaSeparatedInterfaceTypeList", 
      "ClassModifier", "ClassBodyDeclarations", "ClassBodyDeclaration", "ClassMemberDeclaration", 
      "MethodDeclaration", "MethodModifiers", "MethodHeader", "MethodBody", "Result", 
      "MethodDeclarator", "Throws", "Identifier", "FormalParameterList", "Dims", 
      "Block", "BlockStatements", "BlockStatement", "LocalVariableDeclarationStatement", 
      "Statement", "StatementWithoutTrailingSubstatement", "ExpressionStatement", 
      "StatementExpression", "Assignment", "LeftHandSide", "AssignmentOperator", 
      "Expression", "ExpressionName", "AssignmentExpression", "ConditionalExpression", 
      "ConditionalOrExpression", "ConditionalAndExpression", "InclusiveOrExpression", 
      "ExclusiveOrExpression", "AndExpression", "EqualityExpression", "RalationalExpression", 
      "ShiftExpression", "AddictiveExpression", "MultiplicativeExpression", "UnaryExpression", 
      "UnaryExpressionNotPlusMinus", "PodtfixExpression", "Primary", "PrimaryNoNewArray", 
      "Literal", "LocalVariableDeclaration", "VariableModifiers", "UnannType", 
      "VariableDeclaratorList", "UnannPrimitiveType", "NumericType", "IntegralType", 
      "VariableDeclarator", "VariableDeclarators", "VariableDeclaratorId", "VariableInitializer", 
      "EnumBody", "NormalInterfaceDeclaration", "AnnotationTypeDeclaration", 
      "InterfaceModifiers", "ExtendsInterfaces", "InterfaceBody", "AnnotationTypeBody", 
      "InterfaceModifier", "MethodModifier", "TypeName", "PackageOrTypeName", 
      "FormalParameters", "LastFormalParameter", "FormalParameter", "UnannReferenceType", 
      "UnannArrayType", "UnannClassOrInterfaceType", "UnannClassType", "DimsPost", 
      };

  static Parser() {
    states[0] = new State(new int[]{165,-9,158,-5,168,-5,167,-5,166,-5,134,-5,171,-5,151,-5,142,-5,149,-5,161,-5,64,-5,128,-5},new int[]{-1,1,-3,3,-6,229,-7,231,-9,239,-10,241,-12,56,-13,57,-14,58});
    states[1] = new State(new int[]{128,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{158,210,168,-25,167,-25,166,-25,134,-25,171,-25,151,-25,142,-25,149,-25,161,-25,64,-25,128,-25},new int[]{-4,4,-15,207,-16,209,-17,226,-18,227,-19,228});
    states[4] = new State(new int[]{168,175,167,176,166,177,134,178,171,179,151,174,142,-56,149,-56,161,-143,64,-143,128,-32},new int[]{-5,5,-20,6,-21,8,-23,9,-25,10,-37,167,-24,180,-22,181,-94,182,-96,183,-100,199,-95,206});
    states[5] = new State(-2);
    states[6] = new State(new int[]{168,175,167,176,166,177,134,178,171,179,151,174,128,-30,142,-56,149,-56,161,-143,64,-143},new int[]{-5,7,-20,6,-21,8,-23,9,-25,10,-37,167,-24,180,-22,181,-94,182,-96,183,-100,199,-95,206});
    states[7] = new State(-31);
    states[8] = new State(-33);
    states[9] = new State(-35);
    states[10] = new State(new int[]{142,11,149,161});
    states[11] = new State(new int[]{130,12});
    states[12] = new State(-138,new int[]{-26,13});
    states[13] = new State(new int[]{150,158,157,-40,123,-40,168,-40,167,-40,166,-40,134,-40,171,-40,151,-40,142,-40,149,-40,161,-40,64,-40,128,-40},new int[]{-27,14,-30,156});
    states[14] = new State(new int[]{157,140,123,-48,168,-48,167,-48,166,-48,134,-48,171,-48,151,-48,142,-48,149,-48,161,-48,64,-48,128,-48},new int[]{-28,15});
    states[15] = new State(new int[]{123,17,168,-64,167,-64,166,-64,134,-64,171,-64,151,-64,142,-64,149,-64,161,-64,64,-64,128,-64},new int[]{-29,16});
    states[16] = new State(-37);
    states[17] = new State(new int[]{168,134,167,135,166,136,134,137,171,138,59,139,181,-151,125,-67},new int[]{-38,18,-39,20,-40,22,-41,23,-42,24,-101,132});
    states[18] = new State(new int[]{125,19});
    states[19] = new State(-63);
    states[20] = new State(new int[]{168,134,167,135,166,136,134,137,171,138,59,139,125,-65,181,-151},new int[]{-38,21,-39,20,-40,22,-41,23,-42,24,-101,132});
    states[21] = new State(-66);
    states[22] = new State(-68);
    states[23] = new State(-69);
    states[24] = new State(new int[]{181,131},new int[]{-43,25,-45,108});
    states[25] = new State(new int[]{123,28,59,107},new int[]{-44,26,-51,27});
    states[26] = new State(-71);
    states[27] = new State(-76);
    states[28] = new State(new int[]{130,59,132,60,138,-112,170,-112,160,-112,162,-112,141,-112},new int[]{-52,29,-53,31,-54,33,-82,34,-83,36,-55,76,-56,77,-57,78,-58,79,-59,81,-60,82,-63,105,-48,106});
    states[29] = new State(new int[]{125,30});
    states[30] = new State(-78);
    states[31] = new State(new int[]{130,59,132,60,125,-80,138,-112,170,-112,160,-112,162,-112,141,-112},new int[]{-52,32,-53,31,-54,33,-82,34,-83,36,-55,76,-56,77,-57,78,-58,79,-59,81,-60,82,-63,105,-48,106});
    states[32] = new State(-79);
    states[33] = new State(-81);
    states[34] = new State(new int[]{59,35});
    states[35] = new State(-110);
    states[36] = new State(new int[]{138,64,170,65,160,66,162,67,141,68,130,59,132,60},new int[]{-84,37,-86,61,-87,62,-88,63,-107,69,-108,70,-109,71,-110,73,-48,74});
    states[37] = new State(new int[]{130,59,132,60},new int[]{-85,38,-89,39,-91,41,-48,44});
    states[38] = new State(-111);
    states[39] = new State(-121,new int[]{-90,40});
    states[40] = new State(-122);
    states[41] = new State(new int[]{61,42,59,-124});
    states[42] = new State(-130,new int[]{-92,43});
    states[43] = new State(-125);
    states[44] = new State(new int[]{61,-126,59,-126,41,-126,138,-126,170,-126,160,-126,162,-126,141,-126,130,-126,132,-126,44,-126,91,-13},new int[]{-50,45,-11,46,-10,54,-12,56,-13,57,-14,58});
    states[45] = new State(-127);
    states[46] = new State(new int[]{91,47});
    states[47] = new State(new int[]{93,48});
    states[48] = new State(new int[]{91,-13,61,-183,59,-183,41,-183,138,-183,170,-183,160,-183,162,-183,141,-183,130,-183,132,-183,44,-183,123,-183},new int[]{-111,49,-11,50,-10,54,-12,56,-13,57,-14,58});
    states[49] = new State(-180);
    states[50] = new State(new int[]{91,51});
    states[51] = new State(new int[]{93,52});
    states[52] = new State(new int[]{61,-181,59,-181,41,-181,138,-181,170,-181,160,-181,162,-181,141,-181,130,-181,132,-181,44,-181,123,-181,91,-13},new int[]{-111,53,-11,50,-10,54,-12,56,-13,57,-14,58});
    states[53] = new State(-182);
    states[54] = new State(-11,new int[]{-11,55,-10,54,-12,56,-13,57,-14,58});
    states[55] = new State(-12);
    states[56] = new State(-14);
    states[57] = new State(-15);
    states[58] = new State(-16);
    states[59] = new State(-128);
    states[60] = new State(-177);
    states[61] = new State(-113);
    states[62] = new State(-114);
    states[63] = new State(-115);
    states[64] = new State(-116);
    states[65] = new State(-117);
    states[66] = new State(-118);
    states[67] = new State(-119);
    states[68] = new State(-120);
    states[69] = new State(-172);
    states[70] = new State(-173);
    states[71] = new State(new int[]{130,-129,132,-129,91,-13},new int[]{-50,72,-11,46,-10,54,-12,56,-13,57,-14,58});
    states[72] = new State(-174);
    states[73] = new State(-175);
    states[74] = new State(-46,new int[]{-32,75});
    states[75] = new State(-176);
    states[76] = new State(-82);
    states[77] = new State(-83);
    states[78] = new State(-84);
    states[79] = new State(new int[]{59,80});
    states[80] = new State(-85);
    states[81] = new State(-86);
    states[82] = new State(new int[]{187,104},new int[]{-61,83});
    states[83] = new State(new int[]{184,103},new int[]{-62,84,-64,85,-65,86,-66,87,-67,88,-68,89,-69,90,-70,91,-71,92,-72,93,-73,94,-74,95,-75,96,-76,97,-77,98,-78,99,-79,100,-80,101,-81,102});
    states[84] = new State(-87);
    states[85] = new State(-91);
    states[86] = new State(-92);
    states[87] = new State(-93);
    states[88] = new State(-94);
    states[89] = new State(-95);
    states[90] = new State(-96);
    states[91] = new State(-97);
    states[92] = new State(-98);
    states[93] = new State(-99);
    states[94] = new State(-100);
    states[95] = new State(-101);
    states[96] = new State(-102);
    states[97] = new State(-103);
    states[98] = new State(-104);
    states[99] = new State(-105);
    states[100] = new State(-106);
    states[101] = new State(-107);
    states[102] = new State(-108);
    states[103] = new State(-109);
    states[104] = new State(-90);
    states[105] = new State(-88);
    states[106] = new State(-89);
    states[107] = new State(-77);
    states[108] = new State(new int[]{130,59,132,60},new int[]{-46,109,-48,111});
    states[109] = new State(-74,new int[]{-47,110});
    states[110] = new State(-72);
    states[111] = new State(new int[]{40,112});
    states[112] = new State(-112,new int[]{-49,113,-104,116,-106,122,-83,127,-105,130});
    states[113] = new State(new int[]{41,114});
    states[114] = new State(new int[]{123,-129,59,-129,91,-13},new int[]{-50,115,-11,46,-10,54,-12,56,-13,57,-14,58});
    states[115] = new State(-73);
    states[116] = new State(new int[]{44,117});
    states[117] = new State(-112,new int[]{-105,118,-83,119});
    states[118] = new State(-165);
    states[119] = new State(new int[]{138,64,170,65,160,66,162,67,141,68,130,59,132,60},new int[]{-84,120,-86,61,-87,62,-88,63,-107,69,-108,70,-109,71,-110,73,-48,74});
    states[120] = new State(new int[]{130,59,132,60},new int[]{-91,121,-48,44});
    states[121] = new State(-167);
    states[122] = new State(new int[]{44,-168,138,-112,170,-112,160,-112,162,-112,141,-112,130,-112,132,-112},new int[]{-104,123,-106,122,-83,124});
    states[123] = new State(-169);
    states[124] = new State(new int[]{138,64,170,65,160,66,162,67,141,68,130,59,132,60},new int[]{-84,125,-86,61,-87,62,-88,63,-107,69,-108,70,-109,71,-110,73,-48,74});
    states[125] = new State(new int[]{130,59,132,60},new int[]{-91,126,-48,44});
    states[126] = new State(-170);
    states[127] = new State(new int[]{138,64,170,65,160,66,162,67,141,68,130,59,132,60},new int[]{-84,128,-86,61,-87,62,-88,63,-107,69,-108,70,-109,71,-110,73,-48,74});
    states[128] = new State(new int[]{130,59,132,60},new int[]{-91,129,-48,44});
    states[129] = new State(new int[]{138,-170,170,-170,160,-170,162,-170,141,-170,130,-170,132,-170,44,-170,41,-167});
    states[130] = new State(-166);
    states[131] = new State(-75);
    states[132] = new State(new int[]{168,134,167,135,166,136,134,137,171,138,181,-149},new int[]{-42,133,-101,132});
    states[133] = new State(-150);
    states[134] = new State(-152);
    states[135] = new State(-153);
    states[136] = new State(-154);
    states[137] = new State(-155);
    states[138] = new State(-156);
    states[139] = new State(-70);
    states[140] = new State(-13,new int[]{-35,141,-34,142,-31,147,-11,148,-10,54,-12,56,-13,57,-14,58,-33,151});
    states[141] = new State(-47);
    states[142] = new State(new int[]{44,144,46,-45,123,-52,168,-52,167,-52,166,-52,134,-52,171,-52,151,-52,142,-52,149,-52,161,-52,64,-52,128,-52},new int[]{-36,143});
    states[143] = new State(-49);
    states[144] = new State(-13,new int[]{-34,145,-31,147,-11,148,-10,54,-12,56,-13,57,-14,58,-33,151});
    states[145] = new State(new int[]{44,144,123,-50,168,-50,167,-50,166,-50,134,-50,171,-50,151,-50,142,-50,149,-50,161,-50,64,-50,128,-50,46,-45},new int[]{-36,146});
    states[146] = new State(-51);
    states[147] = new State(new int[]{44,-53,123,-53,168,-53,167,-53,166,-53,134,-53,171,-53,151,-53,142,-53,149,-53,161,-53,64,-53,128,-53,46,-44});
    states[148] = new State(new int[]{130,149});
    states[149] = new State(-46,new int[]{-32,150});
    states[150] = new State(-42);
    states[151] = new State(new int[]{46,152});
    states[152] = new State(-13,new int[]{-11,153,-10,54,-12,56,-13,57,-14,58});
    states[153] = new State(new int[]{130,154});
    states[154] = new State(-46,new int[]{-32,155});
    states[155] = new State(-43);
    states[156] = new State(new int[]{150,158,157,-38,123,-38,168,-38,167,-38,166,-38,134,-38,171,-38,151,-38,142,-38,149,-38,161,-38,64,-38,128,-38},new int[]{-27,157,-30,156});
    states[157] = new State(-39);
    states[158] = new State(-13,new int[]{-31,159,-11,148,-10,54,-12,56,-13,57,-14,58,-33,151,-34,160});
    states[159] = new State(new int[]{150,-41,157,-41,123,-41,168,-41,167,-41,166,-41,134,-41,171,-41,151,-41,142,-41,149,-41,161,-41,64,-41,128,-41,46,-44});
    states[160] = new State(-45);
    states[161] = new State(new int[]{130,162});
    states[162] = new State(new int[]{157,140,123,-48},new int[]{-28,163});
    states[163] = new State(new int[]{123,165},new int[]{-93,164});
    states[164] = new State(-131);
    states[165] = new State(new int[]{125,166});
    states[166] = new State(-132);
    states[167] = new State(new int[]{168,169,167,170,166,171,134,172,171,173,151,174,142,-54,149,-54},new int[]{-25,168,-37,167});
    states[168] = new State(-55);
    states[169] = new State(-57);
    states[170] = new State(-58);
    states[171] = new State(-59);
    states[172] = new State(-60);
    states[173] = new State(-61);
    states[174] = new State(-62);
    states[175] = new State(new int[]{168,-57,167,-57,166,-57,134,-57,171,-57,151,-57,142,-57,149,-57,161,-144,64,-144});
    states[176] = new State(new int[]{168,-58,167,-58,166,-58,134,-58,171,-58,151,-58,142,-58,149,-58,161,-145,64,-145});
    states[177] = new State(new int[]{168,-59,167,-59,166,-59,134,-59,171,-59,151,-59,142,-59,149,-59,161,-146,64,-146});
    states[178] = new State(new int[]{168,-60,167,-60,166,-60,134,-60,171,-60,151,-60,142,-60,149,-60,161,-147,64,-147});
    states[179] = new State(new int[]{168,-61,167,-61,166,-61,134,-61,171,-61,151,-61,142,-61,149,-61,161,-148,64,-148});
    states[180] = new State(-36);
    states[181] = new State(-34);
    states[182] = new State(-133);
    states[183] = new State(new int[]{161,184,64,193});
    states[184] = new State(new int[]{130,185});
    states[185] = new State(-138,new int[]{-26,186});
    states[186] = new State(new int[]{150,191},new int[]{-97,187});
    states[187] = new State(new int[]{123,189},new int[]{-98,188});
    states[188] = new State(-135);
    states[189] = new State(new int[]{125,190});
    states[190] = new State(-140);
    states[191] = new State(-13,new int[]{-35,192,-34,142,-31,147,-11,148,-10,54,-12,56,-13,57,-14,58,-33,151});
    states[192] = new State(-139);
    states[193] = new State(new int[]{161,194});
    states[194] = new State(new int[]{130,195});
    states[195] = new State(new int[]{123,197},new int[]{-99,196});
    states[196] = new State(-136);
    states[197] = new State(new int[]{125,198});
    states[198] = new State(-137);
    states[199] = new State(new int[]{168,201,167,202,166,203,134,204,171,205,161,-141,64,-141},new int[]{-96,200,-100,199});
    states[200] = new State(-142);
    states[201] = new State(-144);
    states[202] = new State(-145);
    states[203] = new State(-146);
    states[204] = new State(-147);
    states[205] = new State(-148);
    states[206] = new State(-134);
    states[207] = new State(new int[]{158,210,168,-23,167,-23,166,-23,134,-23,171,-23,151,-23,142,-23,149,-23,161,-23,64,-23,128,-23},new int[]{-4,208,-15,207,-16,209,-17,226,-18,227,-19,228});
    states[208] = new State(-24);
    states[209] = new State(-26);
    states[210] = new State(new int[]{171,218,130,225},new int[]{-102,211,-103,213});
    states[211] = new State(new int[]{59,212});
    states[212] = new State(-157);
    states[213] = new State(new int[]{46,214});
    states[214] = new State(new int[]{42,215,130,217});
    states[215] = new State(new int[]{59,216});
    states[216] = new State(-158);
    states[217] = new State(new int[]{59,-162,46,-164});
    states[218] = new State(new int[]{130,225},new int[]{-102,219,-103,221});
    states[219] = new State(new int[]{59,220});
    states[220] = new State(-159);
    states[221] = new State(new int[]{46,222});
    states[222] = new State(new int[]{42,223,130,217});
    states[223] = new State(new int[]{59,224});
    states[224] = new State(-160);
    states[225] = new State(new int[]{59,-161,46,-163});
    states[226] = new State(-27);
    states[227] = new State(-28);
    states[228] = new State(-29);
    states[229] = new State(new int[]{158,-3,168,-3,167,-3,166,-3,134,-3,171,-3,151,-3,142,-3,149,-3,161,-3,64,-3,128,-3,165,-9},new int[]{-3,230,-6,229,-7,231,-9,239,-10,241,-12,56,-13,57,-14,58});
    states[230] = new State(-4);
    states[231] = new State(new int[]{165,232});
    states[232] = new State(new int[]{130,233});
    states[233] = new State(new int[]{46,236,59,-19},new int[]{-8,234});
    states[234] = new State(new int[]{59,235});
    states[235] = new State(-6);
    states[236] = new State(new int[]{130,237});
    states[237] = new State(new int[]{46,236,59,-17},new int[]{-8,238});
    states[238] = new State(-18);
    states[239] = new State(-7,new int[]{-7,240,-9,239,-10,241,-12,56,-13,57,-14,58});
    states[240] = new State(-8);
    states[241] = new State(-10);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,128});
    rules[2] = new Rule(-1, new int[]{-3,-4,-5});
    rules[3] = new Rule(-3, new int[]{-6});
    rules[4] = new Rule(-3, new int[]{-6,-3});
    rules[5] = new Rule(-3, new int[]{});
    rules[6] = new Rule(-6, new int[]{-7,165,130,-8,59});
    rules[7] = new Rule(-7, new int[]{-9});
    rules[8] = new Rule(-7, new int[]{-9,-7});
    rules[9] = new Rule(-7, new int[]{});
    rules[10] = new Rule(-9, new int[]{-10});
    rules[11] = new Rule(-11, new int[]{-10});
    rules[12] = new Rule(-11, new int[]{-10,-11});
    rules[13] = new Rule(-11, new int[]{});
    rules[14] = new Rule(-10, new int[]{-12});
    rules[15] = new Rule(-10, new int[]{-13});
    rules[16] = new Rule(-10, new int[]{-14});
    rules[17] = new Rule(-8, new int[]{46,130});
    rules[18] = new Rule(-8, new int[]{46,130,-8});
    rules[19] = new Rule(-8, new int[]{});
    rules[20] = new Rule(-12, new int[]{});
    rules[21] = new Rule(-13, new int[]{});
    rules[22] = new Rule(-14, new int[]{});
    rules[23] = new Rule(-4, new int[]{-15});
    rules[24] = new Rule(-4, new int[]{-15,-4});
    rules[25] = new Rule(-4, new int[]{});
    rules[26] = new Rule(-15, new int[]{-16});
    rules[27] = new Rule(-15, new int[]{-17});
    rules[28] = new Rule(-15, new int[]{-18});
    rules[29] = new Rule(-15, new int[]{-19});
    rules[30] = new Rule(-5, new int[]{-20});
    rules[31] = new Rule(-5, new int[]{-20,-5});
    rules[32] = new Rule(-5, new int[]{});
    rules[33] = new Rule(-20, new int[]{-21});
    rules[34] = new Rule(-20, new int[]{-22});
    rules[35] = new Rule(-21, new int[]{-23});
    rules[36] = new Rule(-21, new int[]{-24});
    rules[37] = new Rule(-23, new int[]{-25,142,130,-26,-27,-28,-29});
    rules[38] = new Rule(-27, new int[]{-30});
    rules[39] = new Rule(-27, new int[]{-30,-27});
    rules[40] = new Rule(-27, new int[]{});
    rules[41] = new Rule(-30, new int[]{150,-31});
    rules[42] = new Rule(-31, new int[]{-11,130,-32});
    rules[43] = new Rule(-31, new int[]{-33,46,-11,130,-32});
    rules[44] = new Rule(-33, new int[]{-31});
    rules[45] = new Rule(-33, new int[]{-34});
    rules[46] = new Rule(-32, new int[]{});
    rules[47] = new Rule(-28, new int[]{157,-35});
    rules[48] = new Rule(-28, new int[]{});
    rules[49] = new Rule(-35, new int[]{-34,-36});
    rules[50] = new Rule(-36, new int[]{44,-34});
    rules[51] = new Rule(-36, new int[]{44,-34,-36});
    rules[52] = new Rule(-36, new int[]{});
    rules[53] = new Rule(-34, new int[]{-31});
    rules[54] = new Rule(-25, new int[]{-37});
    rules[55] = new Rule(-25, new int[]{-37,-25});
    rules[56] = new Rule(-25, new int[]{});
    rules[57] = new Rule(-37, new int[]{168});
    rules[58] = new Rule(-37, new int[]{167});
    rules[59] = new Rule(-37, new int[]{166});
    rules[60] = new Rule(-37, new int[]{134});
    rules[61] = new Rule(-37, new int[]{171});
    rules[62] = new Rule(-37, new int[]{151});
    rules[63] = new Rule(-29, new int[]{123,-38,125});
    rules[64] = new Rule(-29, new int[]{});
    rules[65] = new Rule(-38, new int[]{-39});
    rules[66] = new Rule(-38, new int[]{-39,-38});
    rules[67] = new Rule(-38, new int[]{});
    rules[68] = new Rule(-39, new int[]{-40});
    rules[69] = new Rule(-40, new int[]{-41});
    rules[70] = new Rule(-40, new int[]{59});
    rules[71] = new Rule(-41, new int[]{-42,-43,-44});
    rules[72] = new Rule(-43, new int[]{-45,-46,-47});
    rules[73] = new Rule(-46, new int[]{-48,40,-49,41,-50});
    rules[74] = new Rule(-47, new int[]{});
    rules[75] = new Rule(-45, new int[]{181});
    rules[76] = new Rule(-44, new int[]{-51});
    rules[77] = new Rule(-44, new int[]{59});
    rules[78] = new Rule(-51, new int[]{123,-52,125});
    rules[79] = new Rule(-52, new int[]{-53,-52});
    rules[80] = new Rule(-52, new int[]{-53});
    rules[81] = new Rule(-53, new int[]{-54});
    rules[82] = new Rule(-53, new int[]{-55});
    rules[83] = new Rule(-55, new int[]{-56});
    rules[84] = new Rule(-56, new int[]{-57});
    rules[85] = new Rule(-57, new int[]{-58,59});
    rules[86] = new Rule(-58, new int[]{-59});
    rules[87] = new Rule(-59, new int[]{-60,-61,-62});
    rules[88] = new Rule(-60, new int[]{-63});
    rules[89] = new Rule(-63, new int[]{-48});
    rules[90] = new Rule(-61, new int[]{187});
    rules[91] = new Rule(-62, new int[]{-64});
    rules[92] = new Rule(-64, new int[]{-65});
    rules[93] = new Rule(-65, new int[]{-66});
    rules[94] = new Rule(-66, new int[]{-67});
    rules[95] = new Rule(-67, new int[]{-68});
    rules[96] = new Rule(-68, new int[]{-69});
    rules[97] = new Rule(-69, new int[]{-70});
    rules[98] = new Rule(-70, new int[]{-71});
    rules[99] = new Rule(-71, new int[]{-72});
    rules[100] = new Rule(-72, new int[]{-73});
    rules[101] = new Rule(-73, new int[]{-74});
    rules[102] = new Rule(-74, new int[]{-75});
    rules[103] = new Rule(-75, new int[]{-76});
    rules[104] = new Rule(-76, new int[]{-77});
    rules[105] = new Rule(-77, new int[]{-78});
    rules[106] = new Rule(-78, new int[]{-79});
    rules[107] = new Rule(-79, new int[]{-80});
    rules[108] = new Rule(-80, new int[]{-81});
    rules[109] = new Rule(-81, new int[]{184});
    rules[110] = new Rule(-54, new int[]{-82,59});
    rules[111] = new Rule(-82, new int[]{-83,-84,-85});
    rules[112] = new Rule(-83, new int[]{});
    rules[113] = new Rule(-84, new int[]{-86});
    rules[114] = new Rule(-86, new int[]{-87});
    rules[115] = new Rule(-87, new int[]{-88});
    rules[116] = new Rule(-88, new int[]{138});
    rules[117] = new Rule(-88, new int[]{170});
    rules[118] = new Rule(-88, new int[]{160});
    rules[119] = new Rule(-88, new int[]{162});
    rules[120] = new Rule(-88, new int[]{141});
    rules[121] = new Rule(-85, new int[]{-89});
    rules[122] = new Rule(-85, new int[]{-89,-90});
    rules[123] = new Rule(-90, new int[]{});
    rules[124] = new Rule(-89, new int[]{-91});
    rules[125] = new Rule(-89, new int[]{-91,61,-92});
    rules[126] = new Rule(-91, new int[]{-48});
    rules[127] = new Rule(-91, new int[]{-48,-50});
    rules[128] = new Rule(-48, new int[]{130});
    rules[129] = new Rule(-50, new int[]{});
    rules[130] = new Rule(-92, new int[]{});
    rules[131] = new Rule(-24, new int[]{-25,149,130,-28,-93});
    rules[132] = new Rule(-93, new int[]{123,125});
    rules[133] = new Rule(-22, new int[]{-94});
    rules[134] = new Rule(-22, new int[]{-95});
    rules[135] = new Rule(-94, new int[]{-96,161,130,-26,-97,-98});
    rules[136] = new Rule(-95, new int[]{-96,64,161,130,-99});
    rules[137] = new Rule(-99, new int[]{123,125});
    rules[138] = new Rule(-26, new int[]{});
    rules[139] = new Rule(-97, new int[]{150,-35});
    rules[140] = new Rule(-98, new int[]{123,125});
    rules[141] = new Rule(-96, new int[]{-100});
    rules[142] = new Rule(-96, new int[]{-100,-96});
    rules[143] = new Rule(-96, new int[]{});
    rules[144] = new Rule(-100, new int[]{168});
    rules[145] = new Rule(-100, new int[]{167});
    rules[146] = new Rule(-100, new int[]{166});
    rules[147] = new Rule(-100, new int[]{134});
    rules[148] = new Rule(-100, new int[]{171});
    rules[149] = new Rule(-42, new int[]{-101});
    rules[150] = new Rule(-42, new int[]{-101,-42});
    rules[151] = new Rule(-42, new int[]{});
    rules[152] = new Rule(-101, new int[]{168});
    rules[153] = new Rule(-101, new int[]{167});
    rules[154] = new Rule(-101, new int[]{166});
    rules[155] = new Rule(-101, new int[]{134});
    rules[156] = new Rule(-101, new int[]{171});
    rules[157] = new Rule(-16, new int[]{158,-102,59});
    rules[158] = new Rule(-17, new int[]{158,-103,46,42,59});
    rules[159] = new Rule(-18, new int[]{158,171,-102,59});
    rules[160] = new Rule(-19, new int[]{158,171,-103,46,42,59});
    rules[161] = new Rule(-102, new int[]{130});
    rules[162] = new Rule(-102, new int[]{-103,46,130});
    rules[163] = new Rule(-103, new int[]{130});
    rules[164] = new Rule(-103, new int[]{-103,46,130});
    rules[165] = new Rule(-49, new int[]{-104,44,-105});
    rules[166] = new Rule(-49, new int[]{-105});
    rules[167] = new Rule(-105, new int[]{-83,-84,-91});
    rules[168] = new Rule(-104, new int[]{-106});
    rules[169] = new Rule(-104, new int[]{-106,-104});
    rules[170] = new Rule(-106, new int[]{-83,-84,-91});
    rules[171] = new Rule(-83, new int[]{});
    rules[172] = new Rule(-84, new int[]{-107});
    rules[173] = new Rule(-107, new int[]{-108});
    rules[174] = new Rule(-108, new int[]{-109,-50});
    rules[175] = new Rule(-109, new int[]{-110});
    rules[176] = new Rule(-110, new int[]{-48,-32});
    rules[177] = new Rule(-48, new int[]{132});
    rules[178] = new Rule(-32, new int[]{});
    rules[179] = new Rule(-91, new int[]{-48,-50});
    rules[180] = new Rule(-50, new int[]{-11,91,93,-111});
    rules[181] = new Rule(-111, new int[]{-11,91,93});
    rules[182] = new Rule(-111, new int[]{-11,91,93,-111});
    rules[183] = new Rule(-111, new int[]{});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 444 "parser.y"

public Parser(Scanner scanner) : base(scanner)
{
}
#line default
}
}
