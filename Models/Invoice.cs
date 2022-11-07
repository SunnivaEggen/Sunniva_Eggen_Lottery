using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sunniva_Eggen_Appolonia.Models
{
    public class Invoice
    {
        #region Properties
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? InvoiceNumber { get; set; } 
        public DateTime InvoiceDate { get; set; }
        public int NumberOfTickets { get; set; }
        public double PriceEurWithoutDiscount { get; set; }
        public double PriceUSDWithoutDiscount { get; set; }
        public double PriceEurWithDiscount { get; set; }
        public double PriceUSDWithDiscount { get; set; }
        #endregion

        #region Methods
        public void CreateInvoice(string firstName, string lastName, int numberOfTickets, string invoiceNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            InvoiceNumber= invoiceNumber;
            InvoiceDate = DateTime.Now;
            NumberOfTickets = numberOfTickets;  
            Price price = new Price();
            price.GetTicketPrice();

            if (NumberOfTickets<10)
            {
                PriceEurWithoutDiscount = price.PriceInEuro * NumberOfTickets;
                PriceUSDWithoutDiscount = price.PriceInDollar * NumberOfTickets;
                PriceEurWithDiscount = PriceEurWithoutDiscount;
                PriceUSDWithDiscount = PriceUSDWithoutDiscount;
            }
            else
            {
                PriceEurWithoutDiscount = price.PriceInEuro * NumberOfTickets;
                PriceUSDWithoutDiscount = price.PriceInDollar * NumberOfTickets;
                PriceEurWithDiscount = price.PriceInEuro * NumberOfTickets * 0.85;
                PriceUSDWithDiscount = price.PriceInDollar * NumberOfTickets * 0.85;
            }

            var filename = $"Invoice_{InvoiceNumber}.txt";
            string textToWrite = $"First Name: {FirstName}\r\n" +
                $"Last Name: {LastName}\r\n" +
                $"Invoice number: {InvoiceNumber}\r\n" +
                $"Invoice date: {InvoiceDate}\r\n" +
                $"Number of tickets bought: {NumberOfTickets}\r\n" +
                $"Price before discount in EUR: {PriceEurWithoutDiscount} EUR\r\n" +
                $"Price after discount in EUR: {PriceEurWithDiscount} EUR\r\n" +
                $"Price before discount in USD: {PriceUSDWithoutDiscount} USD\r\n" +
                $"Price after discount in USD: {PriceUSDWithDiscount} USD";
            FileStream outputstream=new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw=new StreamWriter(outputstream);
            sw.Write(textToWrite);
            sw.Close();
        }
        #endregion
    }
}
