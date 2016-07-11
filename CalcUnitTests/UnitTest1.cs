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
            calc_obj.main_loop();
            Assert.AreEqual(4, calc_obj.get_result());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Calc_Lib calc_obj = new Calc_Lib();

            calc_obj.entry(2);
            calc_obj.entry("*");
            calc_obj.entry(3);
            calc_obj.main_loop();
            Assert.AreEqual(6, calc_obj.get_result());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Calc_Lib calc_obj = new Calc_Lib();

            calc_obj.entry(6);
            calc_obj.entry("/");
            calc_obj.entry(2);
            calc_obj.main_loop();
            Assert.AreEqual(3, calc_obj.get_result());
        }
        [TestMethod]
        public void TestMethod4()
        {
            Calc_Lib calc_obj = new Calc_Lib();

            calc_obj.entry(6);
            calc_obj.entry("/");
            calc_obj.entry(2);
            calc_obj.entry("+");
            calc_obj.entry(1);
            calc_obj.main_loop();
            Assert.AreEqual(4, calc_obj.get_result());
        }
        [TestMethod]
        public void TestMethod5()
        {
            Calc_Lib calc_obj = new Calc_Lib();

            calc_obj.entry(4);
            calc_obj.entry("*");
            calc_obj.entry(2);
            calc_obj.entry("-");
            calc_obj.entry(1);
            calc_obj.main_loop();
            Assert.AreEqual(7, calc_obj.get_result());
        }
    }
}
