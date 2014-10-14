using System;
using MediatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediatorTests
{
   [TestClass]
   public class MediatorTest
   {
      [TestMethod]
      public void Test_To_See_That_Output_From_Mediator_Is_Correct()
      {
         ComputerSystem testSystem = new ComputerSystem();
         Computer testComputer = new Computer(testSystem);
         Keyboard testKeyboard = new Keyboard(testSystem);
         Screen testScreen = new Screen(testSystem);
         
         testComputer.SwitchOn();
         testKeyboard.KeyPressed('b');
         testComputer.SwitchOff();
      }
   }
}
