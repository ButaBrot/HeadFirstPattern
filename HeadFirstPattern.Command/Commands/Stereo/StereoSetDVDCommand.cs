using HeadFirstPattern.Command.FremdApis;

namespace HeadFirstPattern.Command.Commands
{
    internal class StereoSetDVDCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoSetDVDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.setDvd();
        }
    }
}
