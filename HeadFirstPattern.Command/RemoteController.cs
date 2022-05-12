using HeadFirstPattern.Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPattern.Command
{
    internal class RemoteController
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        public RemoteController()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
           
        }
        public void SetController(int slot,ICommand onCommand,ICommand offCommand) { onCommands[slot] = onCommand; offCommands[slot] = offCommand; }
        public void OnButtenWasPushed(int slot) => onCommands[slot].Execute();
        public void OffButtenWasPushed(int slot) => offCommands[slot].Execute();

        public override string ToString()
        {
            StringBuilder stringBuffer = new StringBuilder();
            stringBuffer.Append("\n ---------Fernsteuerung---------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuffer.Append($"Platz {i} {onCommands[i].GetType().Name} \t\t\t {offCommands[i].GetType().Name}\n");
            }
            return stringBuffer.ToString();

        }
    }
}

