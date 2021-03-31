using System;
namespace Task1
{
    public class Rectangle
    {
        // private float perimeter;
        // private float area;
        private float length = 1;
        private float width = 1;
        public Rectangle(float length, float width)
        {
            Length = length;
            Width = width;
        }
        private float Length
        {
            get { return length; }
            set 
            { 
                if(value > 0.0 && value < 20.0){
                    length = value;
                }  
            }
        }
        private float Width
        {
            get { return width; }
            set 
            { 
                if(value > 0.0 && value < 20.0){
                    width = value;
                } 
            }
        }
        
        public float Perimeter
        {
            get 
            {
                 return 2 * (Length + Width); 
            } 
        }
        public float Area
        {
            get 
            {
                 return Length * Width; 
            } 
        }
        
    }
}