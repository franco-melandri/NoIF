using System;

namespace ConsoleApplication
{
    public class CallbackReponse
    {
        public string message {get; set;}
    }

    public class Callback
    {
        public CallbackReponse getResponse(int id) 
        {
            if (id < 0)
                return null;

            return new CallbackReponse
            {
                message = string.Format("Your id is {0}", id)
            };
        }
    }
}