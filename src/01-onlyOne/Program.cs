using System;

namespace OnlyOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
//            var onlyOne = new OnlyOne();
            var onlyOne = new OnlyOneNoIf();
            
            var msg = Console.ReadLine();
            var inst = onlyOne.getInstance(msg);
            Console.WriteLine(inst.message);

            msg = Console.ReadLine();
            inst = onlyOne.getInstance(msg);
            Console.WriteLine(inst.message);
            
            Console.ReadKey();            
        }
    }
}
