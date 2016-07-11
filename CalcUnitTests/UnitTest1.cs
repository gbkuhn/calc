using System;
using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calc_Lib calc_obj = new Calc_Lib();

            calc_obj.entry(2);
            calc_obj.entry("+");
            calc_obj.entry(2);
            Assert.Equals(2, calc_obj.get_result());

        }
    }
}
