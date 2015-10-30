﻿namespace LearningBasic.Parsing.Ast.Statements
{
    using System.Collections.Generic;

    public class PrintLine : Print
    {
        public PrintLine(IEnumerable<IExpression> expressions)
            : base(expressions)
        { }

        public override Result Run(IRunTimeEnvironment rte)
        {
            var result = base.Run(rte);
            rte.InputOutput.WriteLine();
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + ";";
        }
    }
}