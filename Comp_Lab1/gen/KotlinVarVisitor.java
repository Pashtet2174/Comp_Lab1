// Generated from C:/Users/Павел/RiderProjects/Comp_Lab1(da)/Comp_Lab1/KotlinVar.g4 by ANTLR 4.13.2
import org.antlr.v4.runtime.tree.ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link KotlinVarParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */
public interface KotlinVarVisitor<T> extends ParseTreeVisitor<T> {
	/**
	 * Visit a parse tree produced by {@link KotlinVarParser#program}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitProgram(KotlinVarParser.ProgramContext ctx);
	/**
	 * Visit a parse tree produced by {@link KotlinVarParser#declaration}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitDeclaration(KotlinVarParser.DeclarationContext ctx);
}