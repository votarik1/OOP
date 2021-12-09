using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FractionalNumber a = new FractionalNumber(3, 8);
            FractionalNumber b = new FractionalNumber(3, 6);
            a= a+b;
            Console.WriteLine(a);

            float c = 3.57f;
            FractionalNumber d = (FractionalNumber)c;
            Console.WriteLine(d);

            ComplexNumber e = new ComplexNumber(1, 1);
            ComplexNumber f = new ComplexNumber(4, 5);
            Console.WriteLine(e-f);
            Console.WriteLine(e-e);
            Console.WriteLine(e*f);
        }
    }
}
