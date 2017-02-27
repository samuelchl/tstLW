using System;



namespace FiboClient
{
    class Program
    {
        static  string bigXmlStr = @"<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN> project01</MTOKEN ></HPAY ></TRANS >";


        static void Main(string[] args)
        {
            //instanciation du webservice
            var mySvc = new FiboSvc.FSvc();

            Console.WriteLine(FibonacciClient(mySvc, 10));

            Console.WriteLine(XmlToJsonClient(mySvc, "<foo>bar</foo>"));

            Console.WriteLine(XmlToJsonClient(mySvc, "<foo>hello</bar>"));

            Console.WriteLine(XmlToJsonClient(mySvc, bigXmlStr));

            Console.WriteLine(XmlToJsonClientJSON(mySvc, bigXmlStr));

            Console.WriteLine(FibonacciClientJSON(mySvc, 10));

            Console.ReadLine();

        }

        

        static int FibonacciClient(FiboSvc.FSvc svc, int val)
        {
            return svc.Fibonacci(val);

        }

        static string XmlToJsonClient(FiboSvc.FSvc svc, string inputXml)
        {

            return svc.XmlToJson(inputXml);
        }

        static string FibonacciClientJSON(FiboSvc.FSvc svc, int val)
        {
           return svc.FibonacciJSON(val);

        }

        static string XmlToJsonClientJSON(FiboSvc.FSvc svc, string inputXml)
        {

            return svc.XmlToJsonJSON(inputXml);
        }




    }
}
