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
            while (true)
            {
                Commands.CommandControler c = new Commands.CommandControler(new BaseCommands(SetCommandsCreatorUsage.ExecuteCommand));
            }
        }
    }
}
