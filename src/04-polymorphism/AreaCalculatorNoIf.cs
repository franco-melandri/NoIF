
using System;


namespace ConsoleApplication
{
    public class AreaCalculatorNoIf
    {
        private readonly ShapeNoIf[] shapes;

        public AreaCalculatorNoIf(ShapeNoIf[] shapes)
        {
            this.shapes = shapes;
        }

        public float Sum()
        {
            var sum = 0f;
            foreach ( var shape in shapes)
            {
                sum += shape.Area();
            }
            return sum;
        }                
    }

    public abstract class ShapeNoIf
    {
        public abstract float Area();
    }

    public class SquareNoIf : ShapeNoIf
    {
        private readonly float length;

        public SquareNoIf(float length)
        {
            this.length = length;
        }

        public override float Area()
        {
            return length*length;
        }
    }

    public class CircleNoIf : ShapeNoIf
    {
        private readonly float radious;

        public CircleNoIf(float radious)
        {
            this.radious = radious;
        }

        public override float Area()
        {
            return (float)(radious * radious * System.Math.PI);
        }
    }    
}