using System;

namespace EnumSnippet
{
    public class CommandsIf
    {   
        private readonly ILogger logger;

        public CommandsIf (ILogger logger) {
            this.logger = logger;
        }

        public void Do (Actions action, States state)        
        {
            if (action == Actions.Start && state == States.Init) {
                logger.Log(Messages.INIT_START);
            } else if (action == Actions.Start && state == States.DeInit) {
                logger.Log(Messages.DEINIT_START);
            } else if (action == Actions.Stop && state == States.Init) {
                logger.Log(Messages.INIT_STOP);
            } else if (action == Actions.Stop && state == States.DeInit) {
                logger.Log(Messages.DEINIT_STOP);
            }
        }
    }
}