using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var shapes = new Shape[] {
                new Square(10),
                new Circle(5)
            };

            var area = new AreaCalculator (shapes);
            Console.WriteLine("Area = {0}", area.Sum());

            // var shapesNoIf = new ShapeNoIf[] {
            //     new SquareNoIf(10),
            //     new CircleNoIf(5)
            // };

            // var areaNoIf = new AreaCalculatorNoIf (shapesNoIf);
            // Console.WriteLine("Area = {0}", areaNoIf.Sum());

            Console.ReadKey();
        }
    }
}
