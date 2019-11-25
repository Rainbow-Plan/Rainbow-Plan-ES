using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Windows;
using LoadWinFrom;
using RPlink;

namespace RainbowPlanTest
{
    [TestClass]
    public class LoadTest
    {
        [TestMethod]
        public void Ltest()
        {
            bool OK = false;
            LoadWF Ltest = new LoadWF();
            RPobject Lt = new RPobject();
            Lt.ins = Ltest.OB_Load.ins;
            if(Lt.ins == 1)
            {
                OK = true;
            }
            Assert.AreEqual(OK, true);
        }
    }
}
