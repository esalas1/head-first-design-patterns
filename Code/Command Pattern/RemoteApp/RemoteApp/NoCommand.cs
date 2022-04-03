using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteApp
{
    public class NoCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("Execute does nothing.");
        }

        public void Undo()
        {
            Console.WriteLine("Undo does nothing.");
        }
    }
}
