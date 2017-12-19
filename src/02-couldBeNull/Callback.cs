using System;

namespace CouldBeNull
{
    public class Callback
    {
        public void getResponse(string id, 
                                Action<Reponse> some,
                                Action<Reponse> none) 
        {
            try
            {
                some(new Reponse
                {
                    message = string.Format("Your id is {0}", Convert.ToInt32(id))
                });
            }
            catch (Exception)
            {
                none(new Reponse());
            }
        }
    }
}