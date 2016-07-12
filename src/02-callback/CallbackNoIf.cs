
using System;

namespace ConsoleApplication
{
    public class CallbackNoIf
    {
        public void getResponse(string id, 
                                Action<CallbackReponse> empty,
                                Action<CallbackReponse> filled) 
        {
            try
            {
                filled(new CallbackReponse
                {
                    message = string.Format("Your id is {0}", Convert.ToInt32(id))
                });
            }
            catch (Exception)
            {
                empty(new CallbackReponse());
            }
        }
    }
}