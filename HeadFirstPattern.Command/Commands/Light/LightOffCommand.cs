using HeadFirstPattern.Command.FremdApis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPattern.Command.Commands
{
    internal class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            _light.Off();
        }
    }
}
