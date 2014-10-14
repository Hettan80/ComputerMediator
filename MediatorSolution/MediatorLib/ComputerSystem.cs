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
       internal void RegisterScreen(Screen screen)
       {
          this.screen = screen;
       }
    }
}
