using System;

namespace OnlyOne
{
    public class OnlyOneNoIfSynch
    {
        Func<string, Instance> action;        
        private Instance instance;
        private object lckObj;

        public OnlyOneNoIfSynch()  {
            lckObj = new object();
            action = createAndGet;
        }

        private Instance createAndGet (string msg) {
            this.instance = new Instance(msg);
            action = onlyGet;
            return this.instance;
        }
        
        private Instance onlyGet (string msg) {
            return this.instance;
        }

        public Instance getInstance (string msg) {
            lock (lckObj) {
                return action(msg);
            }
        }
    }
}