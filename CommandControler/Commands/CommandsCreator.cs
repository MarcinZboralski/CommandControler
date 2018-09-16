using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandControler.Commands
{
     public abstract class CommandsCreator
     {
         public SetCommandsCreatorUsage SetCommandsCreatorUsage;
         public List<string> Commnads = new List<string>();

         public abstract void ExecuteCommand(string command);
         public abstract void CustomExecuteCommand();
         public abstract void CustomExecuteCommand(string command);
    }

    public enum SetCommandsCreatorUsage
    {
        ExecuteCommand,
        CustomExecuteCommandNullable,
        CustomExecuteCommandWhithString,
    }
}
