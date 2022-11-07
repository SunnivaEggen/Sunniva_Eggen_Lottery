using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Sunniva_Eggen_Appolonia.Models
{
    public class Price
    {
        #region Properties
        public double PriceInEuro { get; set; } = 5.0;
        public double PriceInDollar { get; set; }
        public double PriceInSwissFranc { get; set; }
        public double PriceInYen { get; set; }

        public double EurToDollar { get; set; }
        public double EurToSwissFranc { get; set; }
        public double EurToYen { get; set; }
        #endregion

        #region Methods
        public void GetCurrency()
        {
            string uri = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml";
            XDocument xDoc = XDocument.Load(uri);
            XmlDocument xmlDoc = new XmlDocument();

            //XDocument -> XmlDocument
            using (var xmlReader = xDoc.CreateReader())
            {
                xmlDoc.Load(xmlReader);
            }

            var env = xmlDoc["gesmes:Envelope"];
            var cube1 = env["Cube"];
            var cube2 = cube1["Cube"];

            var attList = new List<MapXmlCurrency>();

            foreach (XmlElement child in cube2.ChildNodes)
            {
                string? cur = child.Attributes["currency"]?.Value.ToString();
                string? rate = child.Attributes["rate"]?.Value?.ToString();

                attList.Add(new MapXmlCurrency(cur, rate));
            }

            EurToDollar = Convert.ToDouble(attList[0].Rate.Replace(".", ","));
            EurToYen = Convert.ToDouble(attList[1].Rate.Replace(".", ","));
            EurToSwissFranc = Convert.ToDouble(attList[10].Rate.Replace(".", ","));
        }

        public void GetTicketPrice()
        {
            GetCurrency();
            PriceInDollar = PriceInEuro * EurToDollar;
            PriceInSwissFranc = PriceInEuro * EurToSwissFranc;
            PriceInYen = PriceInEuro * EurToYen;
        }

        public string CreateFile()
        {
            string textToWrite = "";
            var filename = $"Prices_{DateTime.Now.ToString("yyyy.MM.dd")}.txt";

            textToWrite = $"Exchange rates:\r\n" +
                $"\t - EUR to USD: {Math.Round(EurToDollar, 4)} \r\n" +
                $"\t - EUR to JPY: {Math.Round(EurToYen, 4)}\r\n" +
                $"\t - EUR to CHF: {Math.Round(EurToSwissFranc, 4)}\r\n \r\n" +
                $"Price of a ticket:\r\n" +
                $"\t - In Euro: {Math.Round(PriceInEuro,2)} EUR\r\n" +
                $"\t - In Dollar: {Math.Round(PriceInDollar,2)} USD\r\n" +
                $"\t - In Yen: {Math.Round(PriceInYen,2)} JPY\r\n" +
                $"\t - In Swiss Franc: {Math.Round(PriceInSwissFranc, 2)} CHF";

            FileStream outputstream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(outputstream);
            sw.Write(textToWrite);
            sw.Close();
            return textToWrite;
        }
        #endregion
    }
}
