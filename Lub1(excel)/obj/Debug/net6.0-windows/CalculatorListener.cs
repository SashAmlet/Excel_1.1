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
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CalculatorParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ICalculatorListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>Neg</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNeg([NotNull] CalculatorParser.NegContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Neg</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNeg([NotNull] CalculatorParser.NegContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Ident</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdent([NotNull] CalculatorParser.IdentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Ident</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdent([NotNull] CalculatorParser.IdentContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Parent</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParent([NotNull] CalculatorParser.ParentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Parent</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParent([NotNull] CalculatorParser.ParentContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulDiv([NotNull] CalculatorParser.MulDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulDiv([NotNull] CalculatorParser.MulDivContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddSub([NotNull] CalculatorParser.AddSubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddSub([NotNull] CalculatorParser.AddSubContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Num</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNum([NotNull] CalculatorParser.NumContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Num</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNum([NotNull] CalculatorParser.NumContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Compare</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompare([NotNull] CalculatorParser.CompareContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Compare</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompare([NotNull] CalculatorParser.CompareContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] CalculatorParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] CalculatorParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] CalculatorParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] CalculatorParser.ExprContext context);
}
} // namespace Lub1_excel_
