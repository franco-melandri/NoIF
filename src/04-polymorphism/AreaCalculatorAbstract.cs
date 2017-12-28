using System;
using System.Linq;

namespace Polymorphism
{
    public class AreaCalculatorAbstract {
        private readonly ShapeAbstract[] shapes;

        public AreaCalculatorAbstract(ShapeAbstract[] shapes) {
            this.shapes = shapes;
        }

        public float Sum() {
            return shapes.Sum(shape => shape.Area());
        }                
    }
}