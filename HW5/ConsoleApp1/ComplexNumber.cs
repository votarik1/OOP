using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class ComplexNumber
    {
        private double _real;
        private double _imaginary;
        public double Real { get => _real; set => _real=value; }
        public double Imaginary { get => _imaginary; set => _imaginary = value; }

        public ComplexNumber()
        {

        }
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber((a.Real*b.Real-a.Imaginary*b.Imaginary), (a.Real*b.Imaginary)+(a.Imaginary*b.Real));
        }

        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            return a.Real == b.Real && a.Imaginary == b.Imaginary;
        }
        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !(a==b);
        }
        public override bool Equals(object obj)
        {
            try
            {
                if (this==(ComplexNumber)obj)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override string ToString()
        {
            switch (Imaginary)
            {
                case > 0:
                    return $"{Real}+{Imaginary}i";
                case < 0:
                    return  $"{Real}{Imaginary}i";
            }
            return Real.ToString();
        }

    }
}
