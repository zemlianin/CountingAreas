using System;
using AreaLibrary;

namespace CountingAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestCalculatorAreas();
            test.AreaCircularR0();
            test.AreaCircularR2();
            test.AreaTriangulumA1B2C3();
            test.AreaTriangulumA3B4C5();
            test.ChekerTriangulumA2B4C5();
            test.ChekerTriangulumA3B4C5();
        }
    }
}
