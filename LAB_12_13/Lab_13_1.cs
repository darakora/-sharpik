using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_12_13
{
    class Lab_13_1
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public double Perimeter
        {
            get
            {
                return A + B + C;
            }
        }

        public double Mediana
        {
            get
            {
                return Math.Sqrt(2 * Math.Pow(B, 2) + 2 * Math.Pow(A, 2) - Math.Pow(C, 2)) / 2.0;
            }
        }

        public Lab_13_1(double a, double b, double c)
        {
            if (!ChekTriangle(a, b, c))
            {
                throw new Exception("Incorrect sides lenghts");
            }
            this.A = a;
            this.B = b;
            this.C = c;
        }
        
        public static bool ChekTriangle(double a, double b, double c)
        {
            return (a < b + c) && (a > b - c)
                && (b < a + c) && (b > a - c)
                && (c < a + b) && (c > b - a);
        }
        

    }
}
