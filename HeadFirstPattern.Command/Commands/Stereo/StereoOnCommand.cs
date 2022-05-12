using HeadFirstPattern.Command.FremdApis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPattern.Command.Commands
{
    internal class StereoOnCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute() => stereo.On();
    }        }
