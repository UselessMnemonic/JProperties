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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="JPropertiesParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IJPropertiesListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="JPropertiesParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile([NotNull] JPropertiesParser.FileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JPropertiesParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile([NotNull] JPropertiesParser.FileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JPropertiesParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] JPropertiesParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JPropertiesParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] JPropertiesParser.LineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JPropertiesParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProperty([NotNull] JPropertiesParser.PropertyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JPropertiesParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProperty([NotNull] JPropertiesParser.PropertyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JPropertiesParser.key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKey([NotNull] JPropertiesParser.KeyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JPropertiesParser.key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKey([NotNull] JPropertiesParser.KeyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JPropertiesParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] JPropertiesParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JPropertiesParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] JPropertiesParser.ValueContext context);
}
