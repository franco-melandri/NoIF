using System;

namespace CouldBeNull
{
    public class CouldBeNull
    {
        public Reponse getResponse(string id) 
        {
            try
            {
                return new Reponse
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