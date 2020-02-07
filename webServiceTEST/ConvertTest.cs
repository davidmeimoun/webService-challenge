using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace webServiceTEST
{
    [TestClass]
    public class XmlToJsonControllerTest
    {
        [TestMethod]
        public void testSimpleGoodXML()
        {
            string xml = "<foo>bar</foo>";
            string json = ClassLibrary.Convert.XmlToJson(xml);
            string jsonResult = "{\"foo\":\"bar\"}";
            Assert.AreEqual(jsonResult, json);
        }

        [TestMethod]
        public void testNormalGoodXML()
        {
            string xml = "<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>";
            string json = ClassLibrary.Convert.XmlToJson(xml);
            string jsonResult = "{\"TRANS\":{\"HPAY\":{\"ID\":\"103\",\"STATUS\":\"3\",\"EXTRA\":{\"IS3DS\":\"0\",\"AUTH\":\"031183\"},\"INT_MSG\":null,\"MLABEL\":\"501767XXXXXX6700\",\"MTOKEN\":\"project01\"}}}";
            Assert.AreEqual(jsonResult, json);
        }

        [TestMethod]
        public void testBadXML()
        {
            string xml = "<foo>hello</bar>";
            string json = ClassLibrary.Convert.XmlToJson(xml);
            string jsonResult = "Bad Xml format";
            Assert.AreEqual(jsonResult, json);
        }
    }
}
