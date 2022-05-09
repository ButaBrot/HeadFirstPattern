using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPattern.Command
{
    internal class SimpleRemoteControl
    {
        private ICommand _slot;

        public SimpleRemoteControl(ICommand slot)
        {
            this._slot = slot;
        }
        public void SetSlot(ICommand slot)
        {
            _slot = slot;
        }
        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}
