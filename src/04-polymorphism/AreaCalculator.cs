
using System;


namespace Polymorphism
{
    public class AreaCalculator {
        private readonly Shape[] shapes;

        public AreaCalculator(Shape[] shapes) {
            this.shapes = shapes;
        }

        public float Sum() {
            float sum = 0;
            foreach (var s in shapes) {
                var square = s as Square;
                if (square != null) 
                    sum += square.GetLenght() * square.GetLenght();

                var circle = s as Circle;
                if (circle != null)
                    sum += (float)(circle.GetRadious() * circle.GetRadious() * Math.PI);
            }
            return sum;
        }                
    }
}