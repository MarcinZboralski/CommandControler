using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CommandControler.Commands;

namespace CommandControler
{
    public class ConsoleControler
    {

        //public delegate void AddCommand(CommandsCreator commandsCreator);

        //public static event AddCommand addToCommandList;


        private static bool closeProgram = false;
        private static List<CommandsCreator> cc = new List<CommandsCreator>();

        private static void Main()
        {

           // addToCommandList += AddToCommandList;

            AddToCommandList(new BaseCommands(SetCommandsCreatorUsage.ExecuteCommand));
            AddToCommandList(new CustomTestCommands(SetCommandsCreatorUsage.ExecuteCommand));

            while (!closeProgram)
            {
                Commands.CommandControler c = new Commands.CommandControler(cc);
            }
        }

        public static void AddToCommandList(CommandsCreator commandsCreator)
        {
            cc.Add(commandsCreator);
        }

        public static void CloseConsole()
        {
            Console.WriteLine("Trwa Zamykanie Konsoli...");
            Task.Delay(1000).Wait();
            closeProgram = !closeProgram;
        }
    }
}
