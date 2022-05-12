using HeadFirstPattern.Command.FremdApis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPattern.Command.Commands
{
    internal class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }
}
