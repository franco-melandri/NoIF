using System;

namespace OnlyOne
{

    public class OnlyOneNoIf
    {
        Func<string, Instance> action;
        private Instance instance;

        public OnlyOneNoIf() 
        {
            action = createAndGet;
        }

        private Instance createAndGet (string msg)
        {
            this.instance = new Instance(msg);
            action = onlyGet;
            return this.instance;            
        }
        
        private Instance onlyGet (string msg)
        {
            return this.instance;            
        }

        public Instance getInstance (string msg)
        {
            return action(msg);
        }
    }
}