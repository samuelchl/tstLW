using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.XmlDiffPatch;
using Newtonsoft.Json;
using System.IO;
using System.Xml;

namespace FiboTest
{
    static class Tools
    {

        public const string bigXmlStr = @"<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN> project01</MTOKEN ></HPAY ></TRANS >";

        public const string bigJsonStr = @"{""TRANS"":{""HPAY"":{""ID"":""103"",""STATUS"":""3"",""EXTRA"":{""IS3DS"":""0"",""AUTH"":""031183""},""MLABEL"":""501767XXXXXX6700"",""MTOKEN"":"" project01""}}}";


        public static bool CompareJson(string expected, string actual)
        {
            var expectedDoc = JsonConvert.DeserializeXmlNode(expected, "root");
            var actualDoc = JsonConvert.DeserializeXmlNode(actual, "root");
            var diff = new XmlDiff(XmlDiffOptions.IgnoreWhitespace |
                                   XmlDiffOptions.IgnoreChildOrder);
            using (var ms = new MemoryStream())
            using (var writer = new XmlTextWriter(ms, Encoding.UTF8))
            {
                var result = diff.Compare(expectedDoc, actualDoc, writer);
                if (!result)
                {
                    ms.Seek(0, SeekOrigin.Begin);
                    Console.WriteLine(new StreamReader(ms).ReadToEnd());
                }
                return result;
            }
        }

    }
}
