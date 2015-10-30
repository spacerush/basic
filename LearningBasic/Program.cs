﻿namespace LearningBasic
{
    using System.Reflection;
    using LearningBasic.Parsing;
    using LearningBasic.RunTime;

    class Program
    {
        private static void Main(string[] args)
        {
            var inputOutput = new ConsoleInputOutput();
            var rte = new RunTimeEnvironment(inputOutput);
            var scannerFactory = new BasicScannerFactory();
            var parser = new BasicParser(scannerFactory);
            var readEvaluatePrintLoop = new ReadEvaluatePrintLoop(rte, parser);

            PrintSalute(inputOutput);
            Run(readEvaluatePrintLoop);
        }

        private static void PrintSalute(IInputOutput inputOutput)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyName = assembly.GetName();
            inputOutput.WriteLine("{0} {1}", assemblyName.Name, assemblyName.Version);
        }

        private static void Run(ReadEvaluatePrintLoop readEvaluatePrintLoop)
        {
            do
            {
                readEvaluatePrintLoop.TakeStep();
            }
            while (!readEvaluatePrintLoop.IsTerminated);
        }
    }
}
