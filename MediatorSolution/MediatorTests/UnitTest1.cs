using System;
using MediatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediatorTests
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void NeedToNameThisTestLater()
      {
          ComputerSystem testSystem = new ComputerSystem();
          Computer testComputer = new Computer(testSystem);
          Keyboard testKeyboard = new Keyboard(testSystem);
          Screen testScreen = new Screen(testSystem);
          string expectedScreenOutput = "";
          testComputer.SwitchOn();
          testKeyboard.KeyPressed('A');
          Assert.AreEqual(expectedScreenOutput, testScreen.DisplayCharacter());
          Assert.AreEqual('A',testKeyboard.Key);
      }
   }
}
