using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandControler.Commands
{
    public class CustomTestCommands : CommandsCreator
    {
        public CustomTestCommands(SetCommandsCreatorUsage setCommandsCreatorUsage)
        {
            SetCommandsCreatorUsage = setCommandsCreatorUsage;
            SetCommands();
        }

        public override void SetCommands()
        {
            Commnads.Add("test-comm");
        }

        public override void ExecuteCommand(string command)
        {
            if (command == "test-comm")
            {
                Console.WriteLine("Working!!!");
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
