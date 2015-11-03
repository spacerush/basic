﻿namespace LearningBasic.Parsing.Ast
{
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Declares a generic expression that can be compiled to <see cref="Expression"/>.
    /// </summary>
    public interface IExpression : IAstNode
    {
        /// <summary>
        /// Associativity of the expression.
        /// </summary>
        /// <remarks>The associativity is used to format expressions.</remarks>
        Associativity Associativity { get; }

        /// <summary>
        /// Priority of the expression.
        /// </summary>
        /// <remarks>The priority is used to format expressions.</remarks>
        Priority Priority { get; }

        /// <summary>
        /// Compiles abstract syntax expression to <see cref="Expression">.NET expression object</see>.
        /// </summary>
        /// <param name="variables">The variables dictionary to get and set variables' values.</param>
        /// <returns>.NET expression object.</returns>
        Expression GetExpression(IDictionary<string, dynamic> variables);
    }
}
