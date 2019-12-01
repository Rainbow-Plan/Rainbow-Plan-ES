using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Data;
using System.Xml;
using RPlink;
using System.Data.OleDb;

namespace RainbowPlanTest
{
    [TestClass]
    public class connectTest
    {
        [TestMethod]
        public void Connect()
        {
            bool OK = false;
            RPobject obj = new RPobject();
            RPconnect con = new RPconnect(obj);
            if (con.DtableWord != null)
            {
                OK = true;
            }
            Assert.AreEqual(OK, true);
        }
        public void ToRecordSaveTest()
        {
            bool OK = false;
            RPobject obj = new RPobject();
            RPconnect con = new RPconnect(obj);
            int T = con.ToRecordSave();
            if (T != 0)
            {
                OK = true;
            }
            Assert.AreEqual(OK, true);

        }
        public void captureWord()
        {
            bool OK = false;
            RPobject obj = new RPobject();
            RPconnect con = new RPconnect(obj);
            obj = con.captureWord();
            if (obj != null)
            {
                OK = true;
            }
            Assert.AreEqual(OK, true);

        }
    }
}
