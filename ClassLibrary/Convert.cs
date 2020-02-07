using System;
using System.Xml;
using Newtonsoft.Json;

namespace ClassLibrary
{
    public class Convert
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static string XmlToJson(string xml)
        {
            if (xml == null)
            {
                return "Error in method XmlToJson :  null parameter";
            }
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string json = JsonConvert.SerializeXmlNode(doc);
                return json;
            }
            catch (Exception e)
            {
                log.Error(e.StackTrace);
                return "Bad Xml format";
            }

        }

    }
}
