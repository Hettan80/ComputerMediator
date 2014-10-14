using System;
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
          Computer testComputer = new Computer();
          Keyboard testKeyboard = new Keyboard();
          Screen testScreen = new Screen();
          string expectedScreenOutput = "";
          testComputer.SwitchOn();
          testKeyboard.KeyPressed();
          Assert.AreEqual(expectedScreenOutput,testScreen.DisplayCharacter());
      }
   }
}
