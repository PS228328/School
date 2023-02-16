using Microsoft.VisualStudio.TestTools.UnitTesting;
using MastermindCore6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindCore6.Model.Tests
{
    [TestClass()]
    public class UitslagTests
    {
        UitslagTests ut = new UitslagTests();
        [TestMethod()]
        public void UitslagTest()
        {

        }

        [TestMethod()]
        public void ToStringTest()
        {
            string test = ut.ToString();
            try
            {
                Convert.ToString(test);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}