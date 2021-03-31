using System;
namespace ShapesTest
{
    public class Square: Figure
    {
        public Square(double x, double y) : base(x,y)
        {
            
        }

        public override string Area()
        {
            // return ($"The area of the {name} is {X * X}");
            return Convert.ToString(X * X);
        }
    }
}