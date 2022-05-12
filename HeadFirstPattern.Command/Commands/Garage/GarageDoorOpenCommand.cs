using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPattern.Command.Commands
{
    internal class GarageDoorOpenCommand : ICommand
    {
        GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}
