using System;

namespace ConsoleApplication
{
    public class CallbackReponse
    {
        public string message {get; set;}
    }

    public class Callback
    {
        public CallbackReponse getResponse(string id) 
        {
            try
            {
                return new CallbackReponse
                {
                    message = string.Format("Your id is {0}", Convert.ToInt32(id))
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}