using System;

namespace OnlyOne
{

    public class OnlyOneNoIf
    {
        Func<string, Instance> action;
        private Instance instance { get; set;}

        public OnlyOneNoIf() 
        {
            action = createAndGet;
        }

        private Instance createAndGet (string msg)
        {
            instance = new Instance {
                        message = msg
                };
            action = onlydGet;
            return instance;            
        }
        
        private Instance onlydGet (string msg)
        {
            return instance;            
        }

        public Instance getInstance (string msg)
        {
            return action(msg);
        }
    }
}