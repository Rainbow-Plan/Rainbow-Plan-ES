using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Windows.Forms;
using FunWinForm;

using System.Data.OleDb;

namespace RainbowPlanTest
{
    [TestClass]
    public class wordTest
    {

        [TestMethod]
        public void WordCapture()
        {
            bool OK = false;
            WordWF testWordWF = new WordWF();
            testWordWF.Word();
            if (testWordWF.I == 1)
            {
                OK = true;
            }
            Assert.AreEqual(OK, true);

            testWordWF.Word();
            if (testWordWF.I == 02)
            {
                OK = true;
            }
            Assert.AreEqual(OK, true);
        }

    }
}
