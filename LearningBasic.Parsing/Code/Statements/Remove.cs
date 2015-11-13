﻿namespace LearningBasic.Parsing.Code.Statements
{
    using System;
    using System.Linq;
    using LearningBasic.RunTime;
    using System.Globalization;

    public class Remove : IStatement
    {
        public Range Range { get; private set; }

        public Remove(Range range)
        {
            if (range == Range.Undefined)
                throw new ArgumentException(ErrorMessages.RemoveMissingRange, "range");

            Range = range;
        }

        public EvaluateResult Execute(IRunTimeEnvironment rte)
        {
            int start;
            int count;
            Range.GetBounds(rte, out start, out count);

            rte.RemoveRange(start, count);

            var message = string.Format(Messages.RemoveResult, count);
            return new EvaluateResult(message);
        }

        public override string ToString()
        {
            return "REMOVE " + Range.ToString();
        }
    }
}
