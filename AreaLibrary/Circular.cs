using System;

namespace AreaLibrary
{
    public class Circular : Figure
    { 
        public Circular(double r)
        {
            R = r;
        }
        public double R { get; set; }
        public override double Area()
        {
            return Math.PI * R * R;
        }
    }
   
}
