using System;

namespace CouldBeNull
{
    public class Callback
    {
        public void getResponse(string id, 
                                Action<Reponse> empty,
                                Action<Reponse> filled) 
        {
            try
            {
                filled(new Reponse
                {
                    message = string.Format("Your id is {0}", Convert.ToInt32(id))
                });
            }
            catch (Exception)
            {
                empty(new Reponse());
            }
        }
    }
}