using Newtonsoft.Json;
using System.Xml;

namespace Logic
{
    public static class WebUtils
    {
        public static string XmlToJson(string xmlInput)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(xmlInput);

            }
            catch (XmlException)
            {
                return "Bad Xml format";
            }

            XmlNodeList nodes = doc.GetElementsByTagName("INT_MSG");

            if (nodes.Count > 0)
                nodes[0].ParentNode.RemoveChild(nodes[0]);

            string jsonText = JsonConvert.SerializeXmlNode(doc);

            return jsonText;
        }
    }
}