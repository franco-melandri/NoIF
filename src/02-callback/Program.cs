using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var callback = new Callback();
            // var id = Convert.ToInt32(Console.ReadLine());
            // var response = callback.getResponse(id);
            // if (response != null)
            //     Console.WriteLine (response.message);
            // else
            //     Console.WriteLine ("No Id !!!!");
            // Console.ReadKey();

            var callback = new CallbackNoIf();
            var id = Convert.ToInt32(Console.ReadLine());
            callback.getResponse(id,
                                (res) => Console.WriteLine ("No Id !!!!"),
                                (res) => Console.WriteLine (res.message));
            Console.ReadKey();            
        }
    }
}
