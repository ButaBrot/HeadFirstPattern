using HeadFirstPattern.Command.FremdApis;

namespace HeadFirstPattern.Command.Commands
{
    internal class StereoSetCDCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoSetCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.setCd();
            stereo.setVolume(11);
        }
    }
}
