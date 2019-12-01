using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FunWinForm;
using RPlink;
using System.Data.OleDb;

namespace RainbowPlanTest
{
    [TestClass]
    public class collectWFTest
    {
        [TestMethod]
        public void DataToFill()
        {
            bool OK = false;
            //RPobject obj = new RPobject();
            CollectWF CWF = new CollectWF();
            CWF.DataToFill();
            if(CWF.Record != null)
            {
                OK = true;
            }
            Assert.AreEqual(OK, true);
            
        }
    }
}
