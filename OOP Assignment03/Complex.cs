using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03
{
    internal class Complex
    {
        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public int Real { get; set; }
        public int Imaginary { get; set; }

        public static Complex operator +(Complex a, Complex b)
        {
            Complex res = new(a.Real + b.Real, a.Imaginary + b.Imaginary);

            return res;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            Complex res = new(a.Real - b.Real, a.Imaginary - b.Imaginary);
            return res;

        }

        public override string ToString()
        {
            return $"Complex number: {Real} + {Imaginary}i";
        }
    }
}
