using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiboTest
{
    /// <summary>
    /// Description résumée pour UnitTest1
    /// </summary>
    [TestClass]
    public class XmlToJsonTest
    {

        FiboSvc.FSvc mySvc = new FiboSvc.FSvc();

       
        [TestMethod]
        public void X2JTestMethod1()
        {
            Assert.AreEqual(Tools.CompareJson(mySvc.XmlToJson("<foo>bar</foo>"), "{\"foo\":\"bar\"}"),true) ;
        }

        [TestMethod]
        public void X2JTestMethod2()
        {
            Assert.AreEqual(mySvc.XmlToJson("<foo>hello</bar>"), "Bad Xml format"); 
        }

        [TestMethod]
        public void X2JTestMethod3()
        {
            Assert.AreEqual(Tools.CompareJson(mySvc.XmlToJson(Tools.bigXmlStr), Tools.bigJsonStr),true);
        }

        [TestMethod]
        public void X2JTestMethod4()
        {
            Assert.AreEqual(Tools.CompareJson(mySvc.XmlToJsonJSON("<foo>bar</foo>"), "{\"foo\":\"bar\"}"),true);
        }

        [TestMethod]
        public void X2JTestMethod5()
        {
            Assert.AreEqual(mySvc.XmlToJsonJSON("<foo>hello</bar>"), "Bad Xml format");
        }

        [TestMethod]
        public void X2JTestMethod6()
        {
            Assert.AreEqual(Tools.CompareJson(mySvc.XmlToJsonJSON(Tools.bigXmlStr), Tools.bigJsonStr),true) ;
        }
    }
}
