using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteApp
{
    public class SimpleRemoteControl
    {
        Command slot;

        public SimpleRemoteControl() { }

        public void SetCommand(Command command)
        {
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }


    }
}
