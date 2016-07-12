
using System;


namespace ConsoleApplication
{
    public class AreaCalculator
    {
        private readonly Shape[] shapes;
        public AreaCalculator(Shape[] shapes)
        {
            this.shapes = shapes;
        }

        public float Sum()
        {
            float sum = 0;
            foreach (var s in shapes)
            {
                var square = s as Square;
                if (square != null)
                {
                    sum += square.GetLenght() * square.GetLenght();
                }

                var circle = s as Circle;
                if (circle != null)
                {
                    sum += (float)(circle.GetRadious() * circle.GetRadious() * Math.PI);
                }
            }
            return sum;
        }                
    }

    public class Shape
    {
    }

    public class Square : Shape
    {
        private readonly float length;

        public Square(float length)
        {
            this.length = length;
        }

        public float GetLenght()
        {
            return length;
        }
    }

    public class Circle : Shape
    {
        private readonly float radious;

        public Circle(float radious)
        {
            this.radious = radious;
        }

        public float GetRadious()
        {
            return radious;
        }
    }
    
}