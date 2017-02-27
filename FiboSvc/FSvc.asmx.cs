using System.Web.Services;
using Logic;
using System.Web.Script.Services;
using Newtonsoft.Json;
using log4net;
using System;

namespace FiboSvc
{
    /// <summary>
    /// Description résumée de FSvc
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    [ScriptService]
    public class FSvc : System.Web.Services.WebService
    {


        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);



        [WebMethod(Description = "The Fibonacci service takes input an integer N, and return the Nth value in the Fibonacci sequence")]
        public int Fibonacci(int n)
        {

            log.Info(string.Format("Appel Fibonnacci - param n = {0}", n));

            try
            {

                //restrictions 1 <= N <= 100
                if (n < 1 || n > 100)
                    return -1;

                var res = Mth.CalculateFibonacci(n);

                log.Info(string.Format("Retour Fibonnacci - resultat = {0}", res));

                return res;

            }
            catch (Exception e)
            {
                log.Error(e.Message);
                return -1;
            }

        }

        [WebMethod(Description = "The Fibonacci service takes input an integer N, and return the Nth value in the Fibonacci sequence")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string FibonacciJSON(int n)
        {
            log.Info(string.Format("Appel FibonacciJSON - param n = {0}", n));

            try
            {

                //restrictions 1 <= N <= 100
                if (n < 1 || n > 100)
                    return JsonConvert.SerializeObject(-1);

                var res = JsonConvert.SerializeObject(Mth.CalculateFibonacci(n));

                log.Info(string.Format("Retour FibonacciJSON - resultat = {0}", res));

                return res;

            }
            catch (Exception e)
            {
                log.Error(string.Format(e.Message));
                return "-1";
            }

            
        }

        [WebMethod(Description = "The XmlToJson service takes input a string xml and returns the json form of the xml string, It will return \"Bad Xml format\" if the input string is not a well - formed xml")]

        public string XmlToJson(string xmlInput)
        {
            log.Info(string.Format("Appel XmlToJson - param xmlInput = {0}", xmlInput));

            try
            {

                var res = WebUtils.XmlToJson(xmlInput); ;

                log.Info(string.Format("Retour XmlToJson - resultat = {0}", res));

                return res;
            }
            catch (Exception e)
            {
                log.Error(string.Format(e.Message));
                return "Bad Xml format";
            }
        }

        [WebMethod(Description = "The XmlToJson service takes input a string xml and returns the json form of the xml string, It will return \"Bad Xml format\" if the input string is not a well - formed xml")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, XmlSerializeString = true)]

        public string XmlToJsonJSON(string xmlInput)
        {
            log.Info(string.Format("Appel XmlToJsonJSON - param xmlInput = {0}", xmlInput));

            try
            {

                var res =WebUtils.XmlToJson(xmlInput);

                log.Info(string.Format("Retour XmlToJsonJSON - resultat = {0}", res));

                return res;
            }
            catch (Exception e)
            {
                log.Error(string.Format(e.Message));
                return "Bad Xml format";
            }

        }
    }
}
