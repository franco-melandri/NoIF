using System;

namespace Callback
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var id = Console.ReadLine();

            var callback = new Callback();
            var response = callback.getResponse(id);
            if (response != null)
                Console.WriteLine (response.message);
            else
                Console.WriteLine ("No Id !!!!");

            // var callback = new CallbackNoIf();
            // callback.getResponse(id,
            //                     (res) => Console.WriteLine ("No Id !!!!"),
            //                     (res) => Console.WriteLine (res.message));

            Console.ReadKey();            
        }
    }
}
