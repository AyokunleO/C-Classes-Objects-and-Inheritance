using System;
namespace ShapesTest
{
    public class Rectangle: Figure
    {
        public Rectangle(double x, double y): base(x,y)
        {
            
        }

        public override string Area()
        {
            // return ($"The area of the {name} is {X*Y}");
            return Convert.ToString(X * Y);
        }
    }
}