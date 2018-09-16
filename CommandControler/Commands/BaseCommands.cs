using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandControler.Commands
{
    public class BaseCommands : CommandsCreator
    {
        public BaseCommands(SetCommandsCreatorUsage setCommandsCreatorUsage)
        {
            SetCommandsCreatorUsage = setCommandsCreatorUsage;
            SetCommands();
        }

        public override void SetCommands()
        {
            Commnads.Add("set-testValue");
            Commnads.Add("read-testValue");
            Commnads.Add("clear-console");
            Commnads.Add("close-console");
            Commnads.Add("readAllCommands");
        }

        public override void ExecuteCommand(string command)
        {

            if (command == "read-testValue")
            {
                Console.WriteLine("Odtczytana wartosc to: " + CommandControler.testValue);
            }

            if (command == "readAllCommands")
            {
                Console.WriteLine("Aktualne Komendy: ");
                Console.WriteLine("");

                foreach (var cc in CommandControler.istance.commandsCreators)
                {
                    foreach (var v in cc.Commnads)
                    {
                        Console.WriteLine(v);
                    }
                }

               
                Console.WriteLine("");
            }

            if (command == "clear-console")
            {
                Console.Clear();
            }

            if (command == "close-console")
            {
                ConsoleControler.CloseConsole();
            }

            if (command == "set-testValue")
            {
                Console.WriteLine("Prosze podać wartosc");
                CommandControler.istance.readedValue = Console.ReadLine();
                try
                {
                    CommandControler.testValue = Convert.ToInt32(CommandControler.istance.readedValue);
                    Console.WriteLine("Ustawiono Wartosć Na : " + CommandControler.testValue);
                }
                catch (Exception e)
                {
                    Console.WriteLine("To nie jest wartosc liczbowa");
                }
                

            }

        }

        public override void CustomExecuteCommand()
        {
            
        }

        public override void CustomExecuteCommand(string command)
        {
            
        }
    }
}
