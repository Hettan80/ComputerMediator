using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Keyboard
    {
        private ComputerSystem mediator;
        public bool KeyboardEnabled { get; set; }

        public Keyboard(ComputerSystem mediator)
        {
            this.mediator = mediator;
            mediator.RegisterKeyboard(this);
        }

        public void KeyPressed(string c)
        {
            Console.WriteLine("Keyboard: Key " + c + " Pressed");
            mediator.KeyPressed(c);
        }

        public void Enabled()
        {
            KeyboardEnabled = true;
        }

        public void Disabled()
        {
            KeyboardEnabled = false;
        }
    }
}
