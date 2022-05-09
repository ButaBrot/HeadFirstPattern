namespace HeadFirstPattern.Command.Commands
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Tor ist aufgefahren!");
        }public void Down()
        {
            Console.WriteLine("Tor ist runtergefahren!");
        }public void Stop()
        {
            Console.WriteLine("Tor ist gestoppt!");
        }public void LightOn()
        {
            Console.WriteLine("Licht in Garage ist an!");
        }public void LightOff()
        {
            Console.WriteLine("Licht in Garage ist aus!");
        }
    }
}