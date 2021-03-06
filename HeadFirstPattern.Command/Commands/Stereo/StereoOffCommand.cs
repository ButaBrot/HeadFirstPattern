using HeadFirstPattern.Command.FremdApis;

namespace HeadFirstPattern.Command.Commands
{
    internal class StereoOffCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute() => stereo.Off();
    }
}
