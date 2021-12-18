using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support
{
   public sealed class ConsoleLogger : Logger
    {
        public override void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
