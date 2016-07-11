
using System;

namespace ConsoleApplication
{
    public class CallbackNoIf
    {
        public void getResponse(int id, 
                                Action<CallbackReponse> empty,
                                Action<CallbackReponse> filled) 
        {
            if (id < 0) {
                empty(new CallbackReponse());
                return;
            }

            filled(new CallbackReponse
            {
                message = string.Format("Your id is {0}", id)
            });
        }
    }
}