using System;

namespace OnlyOne
{
    public class OnlyOne
    {
        private Instance instance;

        public Instance getInstance (string msg)
        {
            if (this.instance == null)
                this.instance = new Instance(msg);
            return this.instance;
        }
    }
}