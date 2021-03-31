using System;
namespace ShapesTest
{
    public class Cube: Figure
    {
        public Cube(double x, double y) :base(x,y)
        {
            
        }

        public override string Area()
        {
            // return ($"The area of the {name} is {6 * Math.Pow(X,2)}");
            return Convert.ToString(6 * Math.Pow(X,2));
        }
    }
}