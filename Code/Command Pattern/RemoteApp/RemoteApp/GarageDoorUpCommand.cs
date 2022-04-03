using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteApp
{
    public class GarageDoorUpCommand : Command
    {
        GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.Down();
        }
    }
}
