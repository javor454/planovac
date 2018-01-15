using Microsoft.VisualStudio.TestTools.UnitTesting;
using planovac2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planovac2.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        [TestMethod()]
        public void GetDateOnlyTest()
        {
            MainForm mainForm = new MainForm();
            DateTime time = DateTime.Now;
            Assert.AreEqual(string.Format("{0:D}", time), mainForm.GetDateOnly());
        }

        [TestMethod()]
        public void GetTimeOnlyTest()
        {
            MainForm mainForm = new MainForm();
            DateTime time = DateTime.Now;
            Assert.AreEqual(string.Format("{0:HH:mm}", time), mainForm.GetTimeOnly());
        }
    }
}