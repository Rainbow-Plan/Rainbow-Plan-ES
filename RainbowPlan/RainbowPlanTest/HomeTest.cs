using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Windows;
using HomeWinFrom;
using RPlink;

namespace RainbowPlanTest
{
    [TestClass]
    public class HomeTest
    {
        [TestMethod]
        public void Hometest()
        {
            bool OK = false;
            HomeWF Htest = new HomeWF();
            RPobject Ht = new RPobject();
            Ht.ins = Htest.OB_Home.ins;
            if (Ht.ins == 2)
            {
                OK = true;
            }
            Assert.AreEqual(OK, true);
        }
    }
}
