﻿using System;
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
           Console.WriteLine("ComputerSystem: Key " + keyboard.Key + " was pressed");
       }

       internal void RegisterComputer()
       {
           this.computer = computer;
       }
        
        internal void Switch(Computer computer)
        {
            throw new NotImplementedException();
        }
    }
}
