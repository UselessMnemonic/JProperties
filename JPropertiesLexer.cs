//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/nihil/Documents/GitHub/JProperties/JProperties.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class JPropertiesLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		COMMENT=1, LOGICAL_LINE_BREAK=2, NATURAL_LINE_BREAK=3, ESCAPE=4, SPACE=5, 
		PAIR_SEPERATOR=6, PLAINCHAR=7;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"COMMENT", "LOGICAL_LINE_BREAK", "NATURAL_LINE_BREAK", "ESCAPE", "SPACE", 
		"PAIR_SEPERATOR", "PLAINCHAR"
	};


	public JPropertiesLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public JPropertiesLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, "'\\'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "COMMENT", "LOGICAL_LINE_BREAK", "NATURAL_LINE_BREAK", "ESCAPE", 
		"SPACE", "PAIR_SEPERATOR", "PLAINCHAR"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "JProperties.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static JPropertiesLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\t', '\x37', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x3', '\x2', '\x3', '\x2', '\a', '\x2', '\x14', '\n', '\x2', 
		'\f', '\x2', '\xE', '\x2', '\x17', '\v', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', 
		'\x1F', '\n', '\x3', '\x3', '\x3', '\a', '\x3', '\"', '\n', '\x3', '\f', 
		'\x3', '\xE', '\x3', '%', '\v', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x5', '\x4', '*', '\n', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', 
		'\x4', '.', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x2', '\x2', 
		'\t', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x3', '\x2', '\a', '\x4', '\x2', '#', '#', '%', 
		'%', '\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x4', '\x2', '\xE', '\xF', 
		'\"', '\"', '\x4', '\x2', '<', '<', '?', '?', '\b', '\x2', '\f', '\f', 
		'\xE', '\xF', '\"', '\"', '<', '<', '?', '?', '^', '^', '\x2', ';', '\x2', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x5', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\a', '-', '\x3', '\x2', '\x2', '\x2', '\t', '/', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\x31', '\x3', '\x2', '\x2', '\x2', '\r', '\x33', 
		'\x3', '\x2', '\x2', '\x2', '\xF', '\x35', '\x3', '\x2', '\x2', '\x2', 
		'\x11', '\x15', '\t', '\x2', '\x2', '\x2', '\x12', '\x14', '\n', '\x3', 
		'\x2', '\x2', '\x13', '\x12', '\x3', '\x2', '\x2', '\x2', '\x14', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x15', '\x13', '\x3', '\x2', '\x2', '\x2', 
		'\x15', '\x16', '\x3', '\x2', '\x2', '\x2', '\x16', '\x18', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '\x15', '\x3', '\x2', '\x2', '\x2', '\x18', '\x19', 
		'\b', '\x2', '\x2', '\x2', '\x19', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'\x1A', '\x1E', '\a', '^', '\x2', '\x2', '\x1B', '\x1C', '\a', '\xF', 
		'\x2', '\x2', '\x1C', '\x1F', '\a', '\f', '\x2', '\x2', '\x1D', '\x1F', 
		'\a', '\f', '\x2', '\x2', '\x1E', '\x1B', '\x3', '\x2', '\x2', '\x2', 
		'\x1E', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1F', '#', '\x3', '\x2', 
		'\x2', '\x2', ' ', '\"', '\t', '\x4', '\x2', '\x2', '!', ' ', '\x3', '\x2', 
		'\x2', '\x2', '\"', '%', '\x3', '\x2', '\x2', '\x2', '#', '!', '\x3', 
		'\x2', '\x2', '\x2', '#', '$', '\x3', '\x2', '\x2', '\x2', '$', '&', '\x3', 
		'\x2', '\x2', '\x2', '%', '#', '\x3', '\x2', '\x2', '\x2', '&', '\'', 
		'\b', '\x3', '\x2', '\x2', '\'', '\x6', '\x3', '\x2', '\x2', '\x2', '(', 
		'*', '\a', '\xF', '\x2', '\x2', ')', '(', '\x3', '\x2', '\x2', '\x2', 
		')', '*', '\x3', '\x2', '\x2', '\x2', '*', '+', '\x3', '\x2', '\x2', '\x2', 
		'+', '.', '\a', '\f', '\x2', '\x2', ',', '.', '\a', '\f', '\x2', '\x2', 
		'-', ')', '\x3', '\x2', '\x2', '\x2', '-', ',', '\x3', '\x2', '\x2', '\x2', 
		'.', '\b', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\a', '^', '\x2', 
		'\x2', '\x30', '\n', '\x3', '\x2', '\x2', '\x2', '\x31', '\x32', '\t', 
		'\x4', '\x2', '\x2', '\x32', '\f', '\x3', '\x2', '\x2', '\x2', '\x33', 
		'\x34', '\t', '\x5', '\x2', '\x2', '\x34', '\xE', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\x36', '\n', '\x6', '\x2', '\x2', '\x36', '\x10', '\x3', 
		'\x2', '\x2', '\x2', '\b', '\x2', '\x15', '\x1E', '#', ')', '-', '\x3', 
		'\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
