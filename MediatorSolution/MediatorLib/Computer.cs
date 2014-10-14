using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
  public class Computer
   {
       private ComputerSystem mediator;
       private bool ComputerOff;
     
       public Computer(ComputerSystem mediator)
       {
           this.mediator = mediator;
           this.mediator.RegisterComputer(this);
       }

       public void SwitchOn()
       {
           ComputerOff = true;
           Console.WriteLine("Computer switched on");
           mediator.ComputerSwitchedOn(this);
       }

       public void SwitchOff()
       {
           ComputerOff = true;
           Console.WriteLine("Computer Off");
           mediator.ComputerSwitchedOff(this);
       }
   }
}
