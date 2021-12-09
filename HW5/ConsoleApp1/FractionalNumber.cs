using System;
using MathCalculate;

namespace ConsoleApp1
{
    internal sealed class FractionalNumber
    {
        private int _numerator;
        private int _denominator;
        public int Numerator { get => _numerator; set => _numerator = value; }
        public int Denominator
        {
            get => _denominator;
            set
            {
                if (value != 0)
                {
                    _denominator = value;
                }
                else
                {
                    throw new Exception("denominator can't be 0");
                }
            }
        }

        public FractionalNumber()
        {

        }
        public FractionalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static bool operator ==(FractionalNumber a, FractionalNumber b)
        {
            return (double)a.Numerator / a.Denominator == (double)b.Numerator / b.Denominator;
        }
        public static bool operator !=(FractionalNumber a, FractionalNumber b)
        {
            return !(a == b);
        }
        public static bool operator >(FractionalNumber a, FractionalNumber b)
        {
            return (double)a.Numerator / a.Denominator > (double)b.Numerator / b.Denominator;
        }
        public static bool operator <(FractionalNumber a, FractionalNumber b)
        {
            return (double)a.Numerator / a.Denominator < (double)b.Numerator / b.Denominator;
        }
        public static bool operator >=(FractionalNumber a, FractionalNumber b)
        {
            return (double)a.Numerator / a.Denominator >= (double)b.Numerator / b.Denominator;
        }
        public static bool operator <=(FractionalNumber a, FractionalNumber b)
        {
            return (double)a.Numerator / a.Denominator <= (double)b.Numerator / b.Denominator;
        }

        public static FractionalNumber operator +(FractionalNumber a, FractionalNumber b)
        {
            FractionalNumber output = new FractionalNumber();
            output.Denominator = Calculate.NOK(a.Denominator, b.Denominator);
            output.Numerator = a.Numerator * (output.Denominator / a.Denominator) + b.Numerator * (output.Denominator / b.Denominator);
            return output;
        }
        public static FractionalNumber operator -(FractionalNumber a, FractionalNumber b)
        {
            FractionalNumber output = new FractionalNumber();
            output.Denominator = Calculate.NOK(a.Denominator, b.Denominator);
            output.Numerator = a.Numerator * (output.Denominator / a.Denominator) - b.Numerator * (output.Denominator / b.Denominator);
            return output;
        }

        public static FractionalNumber operator ++(FractionalNumber a)
        {
            return new FractionalNumber((a.Numerator + a.Denominator), a.Denominator);
        }

        public static FractionalNumber operator --(FractionalNumber a)
        {
            return new FractionalNumber((a.Numerator - a.Denominator), a.Denominator);
        }

        public static FractionalNumber operator *(FractionalNumber a, FractionalNumber b)
        {
            FractionalNumber output = new FractionalNumber(a.Numerator * a.Numerator, b.Numerator * b.Numerator);
            output.Reduce();
            return output;
        }
        public static FractionalNumber operator /(FractionalNumber a, FractionalNumber b)
        {
            FractionalNumber output = new FractionalNumber(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
            output.Reduce();
            return output;
        }
        public static int operator %(FractionalNumber a, FractionalNumber b)
        {
            return ((a.Numerator * b.Denominator) % (a.Denominator * b.Numerator));
        }

        public static explicit operator float(FractionalNumber a)
        {
            return (float)a.Numerator / a.Denominator;
        }
        public static explicit operator FractionalNumber(float a)
        {
            int b = (int)a;
            double counter =0;
            while (a!=b)
            {
                a *=10;
                b = (int)a;
                counter++;
            }
            return new FractionalNumber(b, (int)Math.Pow(10 , counter));

        }
        public static explicit operator int(FractionalNumber a)
        {
            return a.Numerator / a.Denominator;
        }
        public static explicit operator FractionalNumber(int a)
        {
            return new FractionalNumber(a,1);
        }

        public void Reduce()
        {
            int nod = Calculate.NOD(Numerator, Denominator);
            Numerator = Numerator / nod;
            Denominator = Denominator / nod;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
        public override bool Equals(object obj)
        {
            try
            {
                FractionalNumber b = (FractionalNumber)obj;
                return this == b;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }




    }
}
