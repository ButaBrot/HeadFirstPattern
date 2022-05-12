namespace HeadFirstPattern.Command.Commands
{
    internal class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Commmand, sorry!");
        }
    }
}