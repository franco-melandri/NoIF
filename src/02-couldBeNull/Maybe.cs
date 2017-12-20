using System;

namespace CouldBeNull
{
    public class MaybeResponse
    {
        private bool hasValue;
        private Response response;

        public static MaybeResponse Some(Response response) 
        { 
            return new MaybeResponse {hasValue = true, response = response};
        }

        public static MaybeResponse None() 
        { 
            return new MaybeResponse {hasValue = false};
        }

        public T Match<T>(Func<Response, T> some, Func<T> none)
        {
           return hasValue ? some(response) : none();
        }
    }

    public class Maybe
    {
        public MaybeResponse getResponse(string id) 
        {
            try
            {
                return MaybeResponse.Some(new Response
                {
                    message = string.Format("Your id is {0}", Convert.ToInt32(id))
                });
            }
            catch (Exception)
            {
                return MaybeResponse.None();
            }
        }
    }
}