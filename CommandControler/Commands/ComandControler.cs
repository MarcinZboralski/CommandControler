using System;
using System.Collections.Generic;
using CommandControler.Commands;

namespace CommandControler.Commands
{
    public sealed class CommandControler
    {
        public static CommandControler istance;
        public static int testValue =22;

        public List<CommandsCreator> commandsCreators = new List<CommandsCreator>();

        public CommandControler(List<CommandsCreator> commandsCreator)
        {
            commandsCreators = commandsCreator;
            istance = this;
            ReadComand(commandsCreators);
        }
           



        public string readedCommand;


        public string readedValue;

        public void ReadComand(List<CommandsCreator> cCreatorList)
        {
            Console.WriteLine("Prosze podać komende");
            readedCommand = Console.ReadLine();

            for (int i = 0; i < cCreatorList.Count; i++)
            {
                if (CommandExist(readedCommand, cCreatorList[i]))
                {
                    Console.WriteLine("Komenda poprawna");
                    switch (cCreatorList[i].SetCommandsCreatorUsage)
                    {
                        case SetCommandsCreatorUsage.ExecuteCommand:
                            cCreatorList[i].ExecuteCommand(readedCommand);
                            break;
                        case SetCommandsCreatorUsage.CustomExecuteCommandNullable:
                            cCreatorList[i].CustomExecuteCommand();
                            break;
                        case SetCommandsCreatorUsage.CustomExecuteCommandWhithString:
                            cCreatorList[i].CustomExecuteCommand(readedCommand);
                            break;
                    }
                    break;
                }
                else if(i >= cCreatorList.Count-1)
                {
                    Console.WriteLine("Błędna komenda proszę podać ponnownie");
                }
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
