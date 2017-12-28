using System;

namespace Polymorphism
{
    public abstract class ShapeAbstract {
        public abstract float Area();
    }

    public class SquareAbstract : ShapeAbstract {
        private readonly float length;

        public SquareAbstract(float length) {
            this.length = length;
        }

        public override float Area() {
            return length*length;
        }
    }

    public class CircleAbstract : ShapeAbstract {
        private readonly float radious;

        public CircleAbstract(float radious) {
            this.radious = radious;
        }

        public override float Area() {
            return (float)(radious * radious * System.Math.PI);
        }
    }    
}