using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Sunniva_Eggen_Appolonia.Models
{
    public class Draw
    {
        #region Properties
        public string Draws { get; set; }
        public List<int> Numbers = new List<int>();
        public int UID { get; set; }
        public DateTime UTCTime { get; set; }
        public DateTime LocalTime { get; set; }

        public List<int> ids = new List<int>();
        public List<int> Ids { get { return ids; } set { ids = value; } }
        #endregion

        #region Methods
        public void AddDraw()
        {
            var filename = "Draws.xml";
            XElement drawsDirectory;
            if (!(File.Exists(filename)))
            {
                drawsDirectory = new XElement("Draws");
                drawsDirectory.Save(filename);
            }
            
            //Adding the element to xml
            var currentDirectory = Directory.GetCurrentDirectory();
            var drawsDirectoryFilepath = Path.Combine(currentDirectory, filename);
            drawsDirectory = XElement.Load(drawsDirectoryFilepath);
            Ids = drawsDirectory.Descendants("Draw").Select(x => (int)x.Attribute("id")).ToList<int>();

            //Increment UID by 1, and add it to the list of UIDs
            if (Ids.Count == 0)
            {
                UID = 1;
            }
            else
            {
                UID = Ids.Last() + 1;
            }
            //Generate the current local DateTime value
            LocalTime = DateTime.Now;

            //Generate the current UTC DateTime value
            UTCTime = DateTime.UtcNow;

            //Generate a random number 9 times between 1 and 20, and add each one of them to list of numbers
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                int number = random.Next(1, 21);
                Numbers.Add(number);
            }

            drawsDirectory.Add(new XElement("Draw", new XAttribute("id", UID), new XElement("LocalTime", LocalTime),
                new XElement("UTCTime", UTCTime), new XElement("Numbers", new XElement("nr1", Numbers[0]),
                new XElement("nr2", Numbers[1]), new XElement("nr3", Numbers[2]), new XElement("nr4", Numbers[3]),
                new XElement("nr5", Numbers[4]), new XElement("nr6", Numbers[5]), new XElement("nr7", Numbers[6]),
                new XElement("nr8", Numbers[7]), new XElement("nr9", Numbers[8])
                )));

            drawsDirectory.Save(filename);
        }
        #endregion
    }
}
