using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandControler.Commands;

namespace CommandControler
{
    public class Program
    {
        public static bool closeProgram = false;

        static void Main()
        {
            List<CommandsCreator> cc = new List<CommandsCreator>();
            cc.Add(new BaseCommands(SetCommandsCreatorUsage.ExecuteCommand));
            cc.Add(new CustomTestCommands(SetCommandsCreatorUsage.ExecuteCommand));
            while (true)
            {
                Commands.CommandControler c = new Commands.CommandControler(cc);
            }
        }
    }
}
