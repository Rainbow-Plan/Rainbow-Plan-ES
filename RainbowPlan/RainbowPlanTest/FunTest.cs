using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Windows;
using FunWinForm;
using RPlink;

namespace RainbowPlanTest
{
    [TestClass]
    public class FunTest
    {
        [TestMethod]
        public void FWordtest()
        {
            bool OK = false;
            WordWF FWtest = new WordWF();
            RPobject FW = new RPobject();
            FW.ins = FWtest.OB_Word.ins;
            if (FW.ins == 3)
            {
                OK = true;
            }
            Assert.AreEqual(OK, true);
        }

        public void FCollecttest()
        {
            bool OK = false;
            CollectWF FCtest = new CollectWF();
            RPobject FC = new RPobject();
            FC.ins = FCtest.Record.ins;
            if (FC.ins == 31)
            {
                OK = true;
            }
            Assert.AreEqual(OK, true);
        }
    }
}
