using System;

namespace ConsoleApplication
{
    public enum CommandTypes
    {
            Unknown,
            Start,
            Load,
            Run,
            Unload,
            Stop
    }

    public class Commands
    {
        private CommandTypes current;

        public Commands () 
        {
            current = CommandTypes.Unknown;
        }
        
        public CommandTypes getNext() 
        {
            if (current == CommandTypes.Unknown)
                current =  CommandTypes.Start;
            else if (current == CommandTypes.Start)
                current =  CommandTypes.Load;
            else if (current == CommandTypes.Load)
                current =  CommandTypes.Run;
            else if (current == CommandTypes.Run)
                current =  CommandTypes.Unload;
            else if (current == CommandTypes.Unload)
                current =  CommandTypes.Stop;
            else if (current == CommandTypes.Stop)
                current =  CommandTypes.Unknown;
            return current;
        }

        public void Do ()
        {
            switch (current) {
                case CommandTypes.Unknown:
                    Console.WriteLine("Unknown command!");
                    break;
                case CommandTypes.Start:
                    Console.WriteLine("Starting...");
                    break;
                case CommandTypes.Load:
                    Console.WriteLine("Loading...");
                    break;
                case CommandTypes.Run:
                    Console.WriteLine("RUN");
                    break;
                case CommandTypes.Unload:
                    Console.WriteLine("Unloading...");
                    break;
                case CommandTypes.Stop:
                    Console.WriteLine("Stopped.");
                    break;
            }
        }
    }
}