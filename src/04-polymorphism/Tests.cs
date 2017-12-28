            // var shapes = new Shape[] {
            //     new Square(10),
            //     new Circle(5)
            // };

            // var area = new AreaCalculator (shapes);
            // Console.WriteLine("Area = {0}", area.Sum());

            // // var shapesNoIf = new ShapeNoIf[] {
            // //     new SquareNoIf(10),
            // //     new CircleNoIf(5)
            // // };

            // // var areaNoIf = new AreaCalculatorNoIf (shapesNoIf);
            // // Console.WriteLine("Area = {0}", areaNoIf.Sum());

            // Console.ReadKey();


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
}