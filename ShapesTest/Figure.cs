namespace ShapesTest
{
    public class Figure
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }

        public Figure(double x, double y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }

        public virtual string Area()
        {
            return ($"The area of the figure is empty!");
        }
    }
}