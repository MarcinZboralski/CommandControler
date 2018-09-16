using System;
using CommandControler.Commands;

namespace CommandControler.Commands
{
    public class CommandControler
    {
        public static CommandControler istance;
        public static int testValue =22;

        private CommandsCreator cC;

        public CommandControler(CommandsCreator commandsCreator)
        {
            istance = this;
            cC = commandsCreator;
            ReadComand(commandsCreator.SetCommandsCreatorUsage,commandsCreator);
        }



        public string readedCommand;


        public string readedValue;

        public void ReadComand(SetCommandsCreatorUsage setCommandsCreatorUsage,CommandsCreator cCreator)
        {

            Console.WriteLine("Prosze podać komende");
            readedCommand = Console.ReadLine();
            if (CommandExist(readedCommand,cCreator))
            {
                Console.WriteLine("Komenda poprawna");
                switch (setCommandsCreatorUsage)
                {
                    case SetCommandsCreatorUsage.ExecuteCommand:
                        cCreator.ExecuteCommand(readedCommand);
                        break;
                    case SetCommandsCreatorUsage.CustomExecuteCommandNullable:
                        cCreator.CustomExecuteCommand();
                        break;
                    case SetCommandsCreatorUsage.CustomExecuteCommandWhithString:
                        cCreator.CustomExecuteCommand(readedCommand);
                        break;
                }

            }
            else
            {
                Console.WriteLine("Błędna komenda proszę podać ponnownie");
                ReadComand(setCommandsCreatorUsage, cCreator);
            }


        }



        private bool CommandExist(string msg,CommandsCreator cCreator)
        {
            bool val= false;
            foreach (var v in cCreator.Commnads)
            {
                if (msg == v)
                {
                    val=  true;
                    break;
                }
            }

            return val;
        }



    }

}
