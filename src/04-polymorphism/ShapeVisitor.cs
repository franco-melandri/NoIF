using System;

namespace Polymorphism
{
    public abstract class ShapeVisitor {
        public abstract void visit(float area);
    }

    public abstract class ShapeElement {
        public abstract void accept(ShapeVisitor visitor);
    }

    public class SquareElement : ShapeElement {
        private readonly float length;

        public SquareElement(float length) {
            this.length = length;
        }

        public override void accept(ShapeVisitor visitor) {
            visitor.visit(length*length);
        }
    }

    public class CircleElement : ShapeElement {
        private readonly float radious;

        public CircleElement(float radious) {
            this.radious = radious;
        }

        public override void accept(ShapeVisitor visitor) {
            visitor.visit((float)(radious * radious * System.Math.PI));
        }
    }    
}