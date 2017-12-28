using System;
using System.Linq;

namespace Polymorphism
{
    public class Visitor : ShapeVisitor {
        public float Area {get; private set;}

        public Visitor () {
            Area = 0F;
        }
        public override void visit(float area) {
            Area += area;
        }
    }

    public class AreaCalculatorVisitor {
        private readonly ShapeElement[] shapes;

        public AreaCalculatorVisitor(ShapeElement[] shapes) {
            this.shapes = shapes;
        }

        public float Sum() {
            var visitor = new Visitor();
            foreach (var shape in shapes)
                shape.accept(visitor);
            return visitor.Area;
        }
    }    
}