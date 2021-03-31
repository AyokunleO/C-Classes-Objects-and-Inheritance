using System;
namespace ShapesTest
{
    public class Triangle: Figure
    {
        public Triangle(double x, double y): base(x,y)
        {
            
        }

        public override string Area()
        {
        //  return ($"The area of the {name} is {(0.5 * X) * Y}");
            return Convert.ToString((0.5 * X) * Y);
        }
    }
}