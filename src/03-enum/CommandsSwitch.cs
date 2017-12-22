using System;

namespace EnumSnippet
{
    public class CommandsSwitch
    {   
        private readonly ILogger logger;

        public CommandsSwitch (ILogger logger) {
            this.logger = logger;
        }

        public void Do (Actions action, States state)
        {
            switch (action) {
                case Actions.Start:
                    switch (state) {
                        case States.Init:
                            logger.Log(Messages.INIT_START);
                            break;
                        case States.DeInit:
                            logger.Log(Messages.DEINIT_START);
                            break;
                    }                    
                    break;
                case Actions.Stop:
                    switch (state) {
                        case States.Init:
                            logger.Log(Messages.INIT_STOP);
                            break;
                        case States.DeInit:
                            logger.Log(Messages.DEINIT_STOP);
                            break;
                    }                    
                    break;
            }
        }
    }
}