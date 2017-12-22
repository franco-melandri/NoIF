using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumSnippet
{
    public class CommandsNoIf
    {        
        private readonly ILogger logger;
    
        private Dictionary<Func<Actions, States, bool>, string> commands;

        public CommandsNoIf (ILogger logger) 
        {
            this.logger = logger;
            
            commands = new Dictionary<Func<Actions, States, bool>, string> {
                { (action, state) => { return action == Actions.Start && 
                                              state == States.Init; }, 
                    Messages.INIT_START },
                { (action, state) => { return action == Actions.Start && 
                                              state == States.DeInit; }, 
                    Messages.DEINIT_START },
                { (action, state) => { return action == Actions.Stop && 
                                              state == States.Init; }, 
                    Messages.INIT_STOP },
                { (action, state) => { return action == Actions.Stop && 
                                              state == States.DeInit; }, 
                    Messages.DEINIT_STOP }
            };
        }
        
        public void Do (Actions action, States state)
        {
            var message = commands
                            .FirstOrDefault(item => item.Key(action, state) == true)
                            .Value;
                            
            logger.Log(message);
        }
    }
}