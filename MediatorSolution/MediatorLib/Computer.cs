using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
   class Computer
   {
       private ComputerSystem mediator;

       public Computer(ComputerSystem mediator)
       {
           this.mediator = mediator;
           this.mediator.RegisterComputer();
       }

       public void SwitchOn()
       {
       
       }

       public void SwitchOff()
       {
       
       }
   }
}
