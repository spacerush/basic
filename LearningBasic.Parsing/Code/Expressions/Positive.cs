﻿namespace LearningBasic.Parsing.Code.Expressions
{
    using System;
    using System.Linq.Expressions;

    public class Positive : UnaryOperator
    {
        public Positive(IExpression operand)
            : base(Associativity.Right, Priority.ArithmeticNegation, "+", operand)
        { }

        protected override Expression BuildExpression(Expression operand)
        {
            return DynamicExpressionBuilder.BuildOperator(ExpressionType.UnaryPlus, operand);
        }
    }
}