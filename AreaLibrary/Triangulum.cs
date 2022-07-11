using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Triangulum : Figure
    {
        public Triangulum(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        public override double Area()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool Checker()
        {
            if (A > B && A > C)
            {
                return A * A == B * B + C * C;
            }
            if (C > B && C > A)
            {
                return C * C == B * B + A * A;
            }
            if (B > C && B > A)
            {
                return B * B == C * C + A * A;
            }

            return false;
        }
    }
}
