using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
   public class Screen
   {
      private ComputerSystem mediator;
      
      public Screen(ComputerSystem mediator)
      {
         this.mediator = mediator;
         this.mediator.RegisterScreen(this);
      }

      public void DisplayCharacter(char c)
      {
         char Key = c;
         Console.WriteLine("Character " + Key + " Displayed");
         mediator.CharacterDisplayed(this);
      }
   }
}
