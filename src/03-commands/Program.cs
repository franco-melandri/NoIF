using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var command = new CommandsNoIf();
            while (command.getNext() != CommandTypes.Unknown)
                command.Do(); 

            Console.ReadKey();
        }
    }
}
