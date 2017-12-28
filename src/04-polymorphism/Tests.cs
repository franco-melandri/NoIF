using NUnit.Framework;
using Polymorphism;

namespace Tests
{
    [TestFixture]
    public class AreaCalculatorTests
    {    
        [Test]
        public void ShouldCalculateAreaForSquare() 
        {
            var shapes = new [] {
                new Square(2F)
            };
            var area = new AreaCalculator(shapes)
                            .Sum();
            Assert.AreEqual(area, 4f);
        }

        [Test]
        public void ShouldCalculateAreaForCircle() 
        {
            var shapes = new [] {
                new Circle(2F)
            };
            var area = new AreaCalculator(shapes)
                            .Sum();
            Assert.AreEqual(area, 12.566371f);
        }

        [Test]
        public void ShouldCalculateAreaForCircleAndSquare() 
        {
            var shapes = new Shape[] {
                new Square(2F),
                new Circle(2F)
            };
            var area = new AreaCalculator(shapes)
                            .Sum();
            Assert.AreEqual(area, 16.566371f);
        }
    }

    [TestFixture]
    public class AreaCalculatorAbstractTests
    {    
        [Test]
        public void ShouldCalculateAreaForSquare() 
        {
            var shapes = new [] {
                new SquareAbstract(2F)
            };
            var area = new AreaCalculatorAbstract(shapes)
                            .Sum();
            Assert.AreEqual(area, 4f);
        }

        [Test]
        public void ShouldCalculateAreaForCircle() 
        {
            var shapes = new [] {
                new CircleAbstract(2F)
            };
            var area = new AreaCalculatorAbstract(shapes)
                            .Sum();
            Assert.AreEqual(area, 12.566371f);
        }

        [Test]
        public void ShouldCalculateAreaForCircleAndSquare() 
        {
            var shapes = new ShapeAbstract[] {
                new SquareAbstract(2F),
                new CircleAbstract(2F)
            };
            var area = new AreaCalculatorAbstract(shapes)
                            .Sum();
            Assert.AreEqual(area, 16.566371f);
        }
    }

    [TestFixture]
    public class AreaCalculatorVisitorTests
    {    
        [Test]
        public void ShouldCalculateAreaForSquare() 
        {
            var shapes = new [] {
                new SquareElement(2F)
            };
            var area = new AreaCalculatorVisitor(shapes)
                            .Sum();
            Assert.AreEqual(area, 4f);
        }

        [Test]
        public void ShouldCalculateAreaForCircle() 
        {
            var shapes = new [] {
                new CircleElement(2F)
            };
            var area = new AreaCalculatorVisitor(shapes)
                            .Sum();
            Assert.AreEqual(area, 12.566371f);
        }

        [Test]
        public void ShouldCalculateAreaForCircleAndSquare() 
        {
            var shapes = new ShapeElement[] {
                new SquareElement(2F),
                new CircleElement(2F)
            };
            var area = new AreaCalculatorVisitor(shapes)
                            .Sum();
            Assert.AreEqual(area, 16.566371f);
        }
    }
}