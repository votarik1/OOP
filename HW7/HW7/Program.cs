
using Coder;
using Coder.Common;
using System;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            string codeString = "Я12 пр ? А";
            ICoder coder = new ACoder();
            ICoder coder2 = new BCoder();                        
            Console.WriteLine(coder.Encode(codeString));
            Console.WriteLine(coder.Decode(coder.Encode(codeString)));
            Console.WriteLine(coder2.Encode(codeString));
        }
    }
}
