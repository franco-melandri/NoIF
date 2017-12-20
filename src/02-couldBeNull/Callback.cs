using System;

namespace CouldBeNull
{
    public class Callback
    {
        public void getResponse(string id, 
                                Action<Response> some,
                                Action<Response> none) 
        {
            try
            {
                some(new Response
                {
                    message = string.Format("Your id is {0}", Convert.ToInt32(id))
                });
            }
            catch (Exception)
            {
                none(new Response());
            }
        }
    }
}