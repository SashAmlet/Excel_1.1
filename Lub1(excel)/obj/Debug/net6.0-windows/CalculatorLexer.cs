//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from E:\Proga\C#\Excel_1.0\Lub1(excel)\Lub1(excel)\Calculator.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Lub1_excel_ {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class CalculatorLexer : Lexer {
	public const int
		NUMBER=1, IDENTIFIER=2, INT=3, MULTIPLY=4, DIVIDE=5, DIV=6, MOD=7, ADD=8, 
		SUBSTRUCT=9, EQUAL=10, GREATER=11, GREATOREQ=12, LESS=13, LESSOREQ=14, 
		LPAREN=15, RPAREN=16, WS=17;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"NUMBER", "IDENTIFIER", "INT", "MULTIPLY", "DIVIDE", "DIV", "MOD", "ADD", 
		"SUBSTRUCT", "EQUAL", "GREATER", "GREATOREQ", "LESS", "LESSOREQ", "LPAREN", 
		"RPAREN", "WS"
	};


	public CalculatorLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, "'*'", "':'", "'/'", "'%'", "'+'", "'-'", "'=='", 
		"'>'", "'>='", "'<'", "'<='", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NUMBER", "IDENTIFIER", "INT", "MULTIPLY", "DIVIDE", "DIV", "MOD", 
		"ADD", "SUBSTRUCT", "EQUAL", "GREATER", "GREATOREQ", "LESS", "LESSOREQ", 
		"LPAREN", "RPAREN", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Calculator.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x13Z\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x3\x2\x3\x2\x3\x3\x6\x3)\n\x3\r\x3\xE"+
		"\x3*\x3\x3\x6\x3.\n\x3\r\x3\xE\x3/\x3\x4\x5\x4\x33\n\x4\x3\x4\x6\x4\x36"+
		"\n\x4\r\x4\xE\x4\x37\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t"+
		"\x3\t\x3\n\x3\n\x3\v\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3"+
		"\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12"+
		"\x2\x2\x2\x13\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t"+
		"\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F"+
		"\x2\x11!\x2\x12#\x2\x13\x3\x2\x5\x3\x2\x43\\\x3\x2\x32;\x5\x2\v\f\xF\xF"+
		"\"\"]\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2"+
		"\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2"+
		"\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19"+
		"\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2"+
		"\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x3%\x3\x2\x2\x2\x5(\x3\x2\x2\x2\a\x32"+
		"\x3\x2\x2\x2\t\x39\x3\x2\x2\x2\v;\x3\x2\x2\x2\r=\x3\x2\x2\x2\xF?\x3\x2"+
		"\x2\x2\x11\x41\x3\x2\x2\x2\x13\x43\x3\x2\x2\x2\x15\x45\x3\x2\x2\x2\x17"+
		"H\x3\x2\x2\x2\x19J\x3\x2\x2\x2\x1BM\x3\x2\x2\x2\x1DO\x3\x2\x2\x2\x1FR"+
		"\x3\x2\x2\x2!T\x3\x2\x2\x2#V\x3\x2\x2\x2%&\x5\a\x4\x2&\x4\x3\x2\x2\x2"+
		"\')\t\x2\x2\x2(\'\x3\x2\x2\x2)*\x3\x2\x2\x2*(\x3\x2\x2\x2*+\x3\x2\x2\x2"+
		"+-\x3\x2\x2\x2,.\t\x3\x2\x2-,\x3\x2\x2\x2./\x3\x2\x2\x2/-\x3\x2\x2\x2"+
		"/\x30\x3\x2\x2\x2\x30\x6\x3\x2\x2\x2\x31\x33\a/\x2\x2\x32\x31\x3\x2\x2"+
		"\x2\x32\x33\x3\x2\x2\x2\x33\x35\x3\x2\x2\x2\x34\x36\x4\x32;\x2\x35\x34"+
		"\x3\x2\x2\x2\x36\x37\x3\x2\x2\x2\x37\x35\x3\x2\x2\x2\x37\x38\x3\x2\x2"+
		"\x2\x38\b\x3\x2\x2\x2\x39:\a,\x2\x2:\n\x3\x2\x2\x2;<\a<\x2\x2<\f\x3\x2"+
		"\x2\x2=>\a\x31\x2\x2>\xE\x3\x2\x2\x2?@\a\'\x2\x2@\x10\x3\x2\x2\x2\x41"+
		"\x42\a-\x2\x2\x42\x12\x3\x2\x2\x2\x43\x44\a/\x2\x2\x44\x14\x3\x2\x2\x2"+
		"\x45\x46\a?\x2\x2\x46G\a?\x2\x2G\x16\x3\x2\x2\x2HI\a@\x2\x2I\x18\x3\x2"+
		"\x2\x2JK\a@\x2\x2KL\a?\x2\x2L\x1A\x3\x2\x2\x2MN\a>\x2\x2N\x1C\x3\x2\x2"+
		"\x2OP\a>\x2\x2PQ\a?\x2\x2Q\x1E\x3\x2\x2\x2RS\a*\x2\x2S \x3\x2\x2\x2TU"+
		"\a+\x2\x2U\"\x3\x2\x2\x2VW\t\x4\x2\x2WX\x3\x2\x2\x2XY\b\x12\x2\x2Y$\x3"+
		"\x2\x2\x2\a\x2*/\x32\x37\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Lub1_excel_
