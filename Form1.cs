using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Serialization;
using Sunniva_Eggen_Appolonia.Models;

namespace Sunniva_Eggen_Appolonia
{
    public partial class Form1 : Form
    {
        Draws draws=new Draws();

        public Form1()
        {
            InitializeComponent();
            draws.ListOfDraws=new List<Draw>();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //Everytime the user clicks ont the button, a new Draw object is created. Its method AddDraw is called upon
            Draw draw = new Draw();
            draw.AddDraw();

            //Shows the latest draw numbers in the textbox
            txtDraw.Clear();
            txtDraw.AppendText(draw.Numbers[0].ToString() +"\t"+ (draw.Numbers[1].ToString()) + "\t" + (draw.Numbers[2].ToString()) + "\t" +
                (draw.Numbers[3].ToString()) + "\t" + (draw.Numbers[4].ToString()) + "\t" + (draw.Numbers[5].ToString()) + "\t" + 
                (draw.Numbers[6].ToString()) + "\t" + (draw.Numbers[7].ToString()) + "\t" + (draw.Numbers[8].ToString()));

            //The new Draw object is added to the list of Draws
            draws.ListOfDraws.Add(draw);

            //Initiates int variables to count the number of times each number is drawn. Starts at 0. 
            int numberOfOnes=0;
            int numberOfTwos = 0;
            int numberOfThrees = 0;
            int numberOfFours = 0;
            int numberOfFives = 0;
            int numberOfSixes = 0;
            int numberOfSevens = 0;
            int numberOfEights = 0;
            int numberOfNines = 0;
            int numberOfTens = 0;
            int numberOfElevens = 0;
            int numberOfTwelves = 0;
            int numberOfThirteens = 0;
            int numberOfFourteens = 0;
            int numberOfFifteens = 0;
            int numberOfSixteens = 0;
            int numberOfSeventeens = 0;
            int numberOfEighteens = 0;
            int numberOfNineteens = 0;
            int numberOfTwenties = 0;

            //Counts the number of times each number appeared
            foreach (Draw d in draws.ListOfDraws)
            {
                foreach (int number in d.Numbers)
                {
                    switch (number)
                    {
                        case 1:
                            numberOfOnes++;
                            break;
                        case 2:
                            numberOfTwos++;
                            break;
                        case 3:
                            numberOfThrees++;
                            break;
                        case 4:
                            numberOfFours++;
                            break;
                        case 5:
                            numberOfFives++;
                            break;
                        case 6:
                            numberOfSixes++;
                            break;
                        case 7:
                            numberOfSevens++;
                            break;
                        case 8:
                            numberOfEights++;
                            break;
                        case 9:
                            numberOfNines++;
                            break;
                        case 10:
                            numberOfTens++;
                            break;
                        case 11:
                            numberOfElevens++;
                            break;
                        case 12:
                            numberOfTwelves++;
                            break;
                        case 13:
                            numberOfThirteens++;
                            break;
                        case 14:
                            numberOfFourteens++;
                            break;
                        case 15:
                            numberOfFifteens++;
                            break;
                        case 16:
                            numberOfSixteens++;
                            break;
                        case 17:
                            numberOfSeventeens++;
                            break;
                        case 18:
                            numberOfEighteens++;
                            break;
                        case 19:
                            numberOfNineteens++;
                            break;
                        case 20:
                            numberOfTwenties++;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            //Creates a Price object and calls its GetTicketPrice() method to calculate the price of a ticket in different currencies 
            Price price = new Price();
            price.GetTicketPrice();

            //Writes the result to a textbox and to a txt file
            string textToWrite = price.CreateFile();
            txtPrices.Text = textToWrite;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            //Gets data from the form: first name, last name, number of tickets, and invoice number
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int numberOfTickets = 0;
            string invoiceNumber = txtInvoiceNumber.Text;

            //If-statement handles the possibility that the user did not type the number of tickets purchased in a correct in format
            if (int.TryParse(txtNumberOfTickets.Text, out int number))
            {
                numberOfTickets = number;
            }
            else
            {
                MessageBox.Show("Type in valid number.");
            }


            if (!string.IsNullOrEmpty(firstName)&& !string.IsNullOrEmpty(lastName)&& numberOfTickets >=0&&!string.IsNullOrEmpty(invoiceNumber))
            {
                //Creates an Invoice object and writes its contents in a txt file. Then a MessageBox tells the user that the invoice file has been downloaded
                Invoice invoice = new Invoice();
                invoice.CreateInvoice(firstName, lastName, numberOfTickets, invoiceNumber);
                MessageBox.Show("New invoice file created");
            }
            else
            {
                MessageBox.Show("Fill all requested fields");
            }

            
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            //Creates a Statistics object in order to read the xml file containing all the draws. 
            Statistics stats = new Statistics();
            stats.DeserializeXMLFile();

            //Converts read data into Draw objects
            stats.MapClasses();

            //Handles the combobox
            DateTime period=new DateTime();
            if (cboPeriod.Text == "All Periods")
            {
                period = Convert.ToDateTime("01.01.0001");
            }
            else if (cboPeriod.Text == "Last Month")
            {
                period = DateTime.Now.AddMonths(-1);
            }
            else if (cboPeriod.Text == "Last Week")
            {
                period = DateTime.Now.AddDays(-7);
            }
            else if (cboPeriod.Text == "Last Day")
            {
                period = DateTime.Now.AddDays(-1);
            }
            stats.CountRepartitionOfNumbers(period);
            
            
            
            stats.CalculatePercentages();

            txtStatistics.Clear();

            for (int i = 0; i < stats.ListOfPercentages.Count; i++)
            {
                txtStatistics.AppendText((i+1).ToString() + "\t" + (stats.ListOfDrawsPerNumber[i].ToString() + "\t"+Math.Round(stats.ListOfPercentages[i], 2).ToString() + "\r\n"));
            }


            //Imported NuGet package ScottPlot as charts class is no longer available in .NET 6.0. 
            double[] dataX=new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            double[] dataY = new double[20];

            for (int i = 0; i < stats.ListOfDrawsPerNumber.Count; i++)
            {
                dataY[i] = stats.ListOfDrawsPerNumber[i];
            }

            formsPlot1.Plot.AddBar(dataY, dataX);
            formsPlot1.Refresh();
        }

        private void txtStatistics_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
