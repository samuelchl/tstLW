using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FiboTest
{
    [TestClass]
    public class LogicTest
    {
       
        [TestMethod]
        public void XmlToJsonTestMethod1()
        {
            var str = Logic.WebUtils.XmlToJson(Tools.bigXmlStr);

            Assert.AreEqual(str, Tools.bigJsonStr);
        }

        [TestMethod]
        public void CalculateFibonacciMethod1()
        {
            var res = Logic.Mth.CalculateFibonacci(10);

            Assert.AreEqual(res, 55);
        }

        [TestMethod]
        public void XmlToJsonDeserialize()
        {


           Assert.AreEqual(Tools.CompareJson(Tools.bigJsonStr, Logic.WebUtils.XmlToJson(Tools.bigXmlStr)),true);
        }
    }
}
