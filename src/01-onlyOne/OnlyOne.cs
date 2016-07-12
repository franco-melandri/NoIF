using System;

namespace ConsoleApplication
{
    public class Instance
    {
        public string message {get; set;}    
    }

    public class OnlyOne
    {
        private Instance instance {get; set;}

        public Instance getInstance (string msg)
        {
            if (instance == null)
                instance = new Instance {
                        message = msg
                };
            return instance;
        }
    }
}