namespace HeadFirstPattern.Command.FremdApis
{
    internal class Stereo
    {
      public void On() => Console.WriteLine("Stereo ist angemacht!");
      public void Off() => Console.WriteLine("Stereo ist ausgemacht!");
      public void setCd() => Console.WriteLine("CD ist angemacht!");
      public void setDvd() => Console.WriteLine("DVD ist angemacht!");
      public void setRadio() => Console.WriteLine("Radio ist angemacht!");
      public void setVolume(int v) => Console.WriteLine($"Volumen ist auf {v} eingestellt!");
    }

}