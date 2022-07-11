using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaLibrary;

namespace CountingAreas
{
    class TestCalculatorAreas
    {
        public void AreaCircularR2()
        {
            Figure a = new Circular(2);
            Console.WriteLine(a.Area());
        }
        public void AreaCircularR0()
        {
            Figure a = new Circular(0);
            Console.WriteLine(a.Area());
        }
        public void AreaTriangulumA1B2C3()
        {
            Figure a = new Triangulum(1,2,3);
            Console.WriteLine(a.Area());
        }
        public void AreaTriangulumA3B4C5()
        {
            Figure a = new Triangulum(3, 4, 5);
            Console.WriteLine(a.Area());
        }

        public void ChekerTriangulumA3B4C5()
        {
            Triangulum tr = new Triangulum(3, 4, 5);
            Console.WriteLine(tr.Checker());
        }
        public void ChekerTriangulumA2B4C5()
        {
            Triangulum tr = new Triangulum(2, 4, 5);
            Console.WriteLine(tr.Checker());
        }

    }
}
