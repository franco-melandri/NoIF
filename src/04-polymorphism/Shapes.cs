
using System;

namespace Polymorphism
{
    public class Shape {
    }

    public class Square : Shape {
        private readonly float length;

        public Square(float length) {
            this.length = length;
        }

        public float GetLenght() {
            return length;
        }
    }

    public class Circle : Shape {
        private readonly float radious;

        public Circle(float radious) {
            this.radious = radious;
        }

        public float GetRadious() {
            return radious;
        }
    }
}