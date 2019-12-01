using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using RPlink;
using HomeWinFrom;
using System.Data.OleDb;

namespace RainbowPlanTest
{
    [TestClass]
    public class HomeWFtest
    {
        [TestMethod]
        public void Home_Word()
        {
            bool OK = false;
            HomeWF HWF = new HomeWF();
            HWF.Home_Word();
            if (HWF.OB_Home != null)
            {
                OK = true;
            }
            Assert.AreEqual(OK, true);
        }
    }
}
