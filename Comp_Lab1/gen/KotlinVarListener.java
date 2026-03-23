// Generated from C:/Users/Павел/RiderProjects/Comp_Lab1(da)/Comp_Lab1/KotlinVar.g4 by ANTLR 4.13.2
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link KotlinVarParser}.
 */
public interface KotlinVarListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link KotlinVarParser#program}.
	 * @param ctx the parse tree
	 */
	void enterProgram(KotlinVarParser.ProgramContext ctx);
	/**
	 * Exit a parse tree produced by {@link KotlinVarParser#program}.
	 * @param ctx the parse tree
	 */
	void exitProgram(KotlinVarParser.ProgramContext ctx);
	/**
	 * Enter a parse tree produced by {@link KotlinVarParser#declaration}.
	 * @param ctx the parse tree
	 */
	void enterDeclaration(KotlinVarParser.DeclarationContext ctx);
	/**
	 * Exit a parse tree produced by {@link KotlinVarParser#declaration}.
	 * @param ctx the parse tree
	 */
	void exitDeclaration(KotlinVarParser.DeclarationContext ctx);
}