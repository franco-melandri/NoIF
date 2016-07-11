using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class CommandsInfo
    {
        public CommandTypes next {get; set;}
        public string message {get; set;}
    }

    public class CommandsNoIf
    {        
        private Dictionary<CommandTypes, CommandsInfo> info;
        private CommandTypes current;

        public CommandsNoIf () 
        {
            current = CommandTypes.Unknown;
            info = new  Dictionary<CommandTypes, CommandsInfo> {
                {CommandTypes.Unknown, new CommandsInfo {
                    next = CommandTypes.Start,
                    message = "Unknown command!"                    
                }},
                {CommandTypes.Start, new CommandsInfo {
                    next = CommandTypes.Load,
                    message = "Starting..."                    
                }},
                {CommandTypes.Load, new CommandsInfo {
                    next = CommandTypes.Run,
                    message = "Loading..."                    
                }},
                {CommandTypes.Run, new CommandsInfo {
                    next = CommandTypes.Unload,
                    message = "RUN"                    
                }},
                {CommandTypes.Unload, new CommandsInfo {
                    next = CommandTypes.Stop,
                    message = "Unloading..."                    
                }},
                {CommandTypes.Stop, new CommandsInfo {
                    next = CommandTypes.Unknown,
                    message = "Stopped."                    
                }} 
            };
        }
        
        public CommandTypes getNext() 
        {
            var  currentInfo = info[current];
            current = currentInfo.next;
            return current;
        }

        public void Do ()
        {
            var  currentInfo = info[current];
            Console.WriteLine(currentInfo.message);
        }
    }
}