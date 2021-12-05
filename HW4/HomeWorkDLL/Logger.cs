using System;

namespace HomeWorkDLL
{
    public abstract class Logger
    {
        public abstract void PrintMsg(string text);
    }

    public sealed class ConsoleLogger : Logger
    {
        public override void PrintMsg(string text)
        {
            Console.WriteLine(text); ;
        }
    }

}
