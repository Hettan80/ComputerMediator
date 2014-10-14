using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class ComputerSystem
    {
        private Screen screen;
        private Keyboard keyboard;
        private Computer computer;

        internal void RegisterScreen(Screen screen)
        {
            this.screen = screen;
        }

        internal void RegisterKeyboard(Keyboard keyboard)
        {
            this.keyboard = keyboard;
        }

        internal void KeyPressed(Keyboard keyboard)
        {
            Console.WriteLine("Mediator: Key " + keyboard.Key + " was pressed");
        }

        internal void RegisterComputer(Computer computer)
        {
            this.computer = computer;
        }

        internal void ComputerSwitchedOn(Computer computer)
        {
            Console.WriteLine("Mediator: Computer Is On");
        
        }

        internal void ComputerSwitchedOff(Computer computer)
        {
            Console.WriteLine("Mediator: Computer Is off");
        }

        internal void CharacterDisplayed(Screen screen)
        {
           Console.WriteLine("Mediator: Character is displayed");
        }
    }
}
