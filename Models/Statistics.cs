using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sunniva_Eggen_Appolonia.Models
{
    public class Statistics
    {
        #region Properties
        public List<int> ListOfDrawsPerNumber = new List<int>();
        public List<double> ListOfPercentages = new List<double>();
        public double TotalNumbers { get; set; } = 0;

        Draws draws=new Draws();
        public List<MapXmlDraw> ListOfMapXmlDraw = new List<MapXmlDraw>();

        //List of ids:
        public List<int> ids = new List<int>();
        public List<int> Ids { get { return ids; } set { ids = value; } }

        //List og groups:
        public List<XElement> localTimes = new List<XElement>();
        public List<XElement> LocalTimes { get { return localTimes; } set { localTimes = value; } }

        //List of species:
        public List<XElement> utcTimes = new List<XElement>();
        public List<XElement> UTCTimes { get { return utcTimes; } set { utcTimes = value; } }

        //List of periods:
        public List<XElement> numbers= new List<XElement>();
        public List<XElement> Numbers { get { return numbers; } set { numbers = value; } }

        public string filename = "";
        #endregion

        #region Methods
        public void DeserializeXMLFile()
        {
            var filename = "Draws.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var DrawsDirectoryFilepath = Path.Combine(currentDirectory, filename);

            XElement drawsDirectory = XElement.Load(DrawsDirectoryFilepath);

            //Creates a list of Ids:
            Ids = drawsDirectory.Descendants("Draw").Select(x => (int)x.Attribute("id")).ToList<int>();

            //Creates a list of local times: 
            IEnumerable<XElement> localTimesList = (IEnumerable<XElement>)drawsDirectory.Descendants("Draw")
                                                .Select(localTime => localTime.Element("LocalTime"));

            foreach (var item in localTimesList)
            {
                LocalTimes.Add(item);
            }

            //Creates a list of utc times: 
            IEnumerable<XElement> utcTimesList = (IEnumerable<XElement>)drawsDirectory.Descendants("Draw")
                                                .Select(localTime => localTime.Element("UTCTime"));

            foreach (var item in utcTimesList)
            {
                UTCTimes.Add(item);
            }

            //Creates a list of numbers: 
            IEnumerable<XElement> numbersList = (IEnumerable<XElement>)drawsDirectory.Descendants("Draw")
                                                .Select(localTime => localTime.Element("Numbers"));

            foreach (var item in numbersList)
            {
                Numbers.Add(item);
            }

            //Creates mapxmldraw object: 
            for (int i = 0; i < Ids.Count; i++)
            {
                XElement _numbers = (XElement)Numbers[i];
                MapXmlDraw mapXmlDraw = new MapXmlDraw();
                mapXmlDraw.id = Ids[i];
                mapXmlDraw.LocalTime=Convert.ToDateTime(LocalTimes[i].Value);
                mapXmlDraw.UTCTime=Convert.ToDateTime(LocalTimes[i].Value);
                mapXmlDraw.nr1 = Convert.ToInt32(_numbers.Element("nr1").Value);
                mapXmlDraw.nr2 = Convert.ToInt32(_numbers.Element("nr2").Value);
                mapXmlDraw.nr3 = Convert.ToInt32(_numbers.Element("nr3").Value);
                mapXmlDraw.nr4 = Convert.ToInt32(_numbers.Element("nr4").Value);
                mapXmlDraw.nr5 = Convert.ToInt32(_numbers.Element("nr5").Value);
                mapXmlDraw.nr6 = Convert.ToInt32(_numbers.Element("nr6").Value);
                mapXmlDraw.nr7 = Convert.ToInt32(_numbers.Element("nr7").Value);
                mapXmlDraw.nr8 = Convert.ToInt32(_numbers.Element("nr8").Value);
                mapXmlDraw.nr9 = Convert.ToInt32(_numbers.Element("nr9").Value);
                ListOfMapXmlDraw.Add(mapXmlDraw);
            }
        }
         //Transforms MapXmlDraw object into Draw object:
        public void MapClasses()
        {
            foreach (MapXmlDraw item in ListOfMapXmlDraw)
            {
                Draw draw = new Draw();
                draw.UID = item.id;
                draw.LocalTime = item.LocalTime;
                draw.UTCTime = item.UTCTime;
                draw.Numbers.Add(item.nr1);
                draw.Numbers.Add(item.nr2);
                draw.Numbers.Add(item.nr3);
                draw.Numbers.Add(item.nr4);
                draw.Numbers.Add(item.nr5);
                draw.Numbers.Add(item.nr6);
                draw.Numbers.Add(item.nr7);
                draw.Numbers.Add(item.nr8);
                draw.Numbers.Add(item.nr9);
                draws.ListOfDraws.Add(draw);
            }
        }


        public void CountRepartitionOfNumbers(DateTime filteredDate)
        {
            int numberOfOnes = 0;
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

            foreach (Draw d in draws.ListOfDraws)
            {
                if (d.LocalTime>filteredDate)
                {
                    foreach (int number in d.Numbers)
                    {
                        TotalNumbers++;
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
            ListOfDrawsPerNumber.Add(numberOfOnes);
            ListOfDrawsPerNumber.Add(numberOfTwos);
            ListOfDrawsPerNumber.Add(numberOfThrees);
            ListOfDrawsPerNumber.Add(numberOfFours);
            ListOfDrawsPerNumber.Add(numberOfFives);
            ListOfDrawsPerNumber.Add(numberOfSixes);
            ListOfDrawsPerNumber.Add(numberOfSevens);
            ListOfDrawsPerNumber.Add(numberOfEights);
            ListOfDrawsPerNumber.Add(numberOfNines);
            ListOfDrawsPerNumber.Add(numberOfTens);
            ListOfDrawsPerNumber.Add(numberOfElevens);
            ListOfDrawsPerNumber.Add(numberOfTwelves);
            ListOfDrawsPerNumber.Add(numberOfThirteens);
            ListOfDrawsPerNumber.Add(numberOfFourteens);
            ListOfDrawsPerNumber.Add(numberOfFifteens);
            ListOfDrawsPerNumber.Add(numberOfSixteens);
            ListOfDrawsPerNumber.Add(numberOfSeventeens);
            ListOfDrawsPerNumber.Add(numberOfEighteens);
            ListOfDrawsPerNumber.Add(numberOfNineteens);
            ListOfDrawsPerNumber.Add(numberOfTwenties);
        }

        public void CalculatePercentages()
        {
            double onesInPercentage = ListOfDrawsPerNumber[0] / TotalNumbers * 100;
            double twosInPercentage = ListOfDrawsPerNumber[1] / TotalNumbers * 100;
            double threesInPercentage = ListOfDrawsPerNumber[2] / TotalNumbers * 100;
            double foursInPercentage = ListOfDrawsPerNumber[3] / TotalNumbers * 100;
            double fivesInPercentage = ListOfDrawsPerNumber[4] / TotalNumbers * 100;
            double sixesInPercentage = ListOfDrawsPerNumber[5] / TotalNumbers * 100;
            double sevensInPercentage = ListOfDrawsPerNumber[6] / TotalNumbers * 100;
            double eightsInPercentage = ListOfDrawsPerNumber[7] / TotalNumbers * 100;
            double ninesInPercentage = ListOfDrawsPerNumber[8] / TotalNumbers * 100;
            double tensInPercentage = ListOfDrawsPerNumber[9] / TotalNumbers * 100;
            double elevensInPercentage = ListOfDrawsPerNumber[10] / TotalNumbers * 100;
            double twelvesInPercentage = ListOfDrawsPerNumber[11] / TotalNumbers * 100;
            double thirteensInPercentage = ListOfDrawsPerNumber[12] / TotalNumbers * 100;
            double fourteensInPercentage = ListOfDrawsPerNumber[13] / TotalNumbers * 100;
            double fifteensInPercentage = ListOfDrawsPerNumber[14] / TotalNumbers * 100;
            double sixteensInPercentage = ListOfDrawsPerNumber[15] / TotalNumbers * 100;
            double seventeensInPercentage = ListOfDrawsPerNumber[16] / TotalNumbers * 100;
            double eighteensInPercentage = ListOfDrawsPerNumber[17] / TotalNumbers * 100;
            double nineteensInPercentage = ListOfDrawsPerNumber[18] / TotalNumbers * 100;
            double twentiesInPercentage = ListOfDrawsPerNumber[19] / TotalNumbers * 100;

            ListOfPercentages.Add(onesInPercentage);
            ListOfPercentages.Add(twosInPercentage);
            ListOfPercentages.Add(threesInPercentage);
            ListOfPercentages.Add(foursInPercentage);
            ListOfPercentages.Add(fivesInPercentage);
            ListOfPercentages.Add(sixesInPercentage);
            ListOfPercentages.Add(sevensInPercentage);
            ListOfPercentages.Add(eightsInPercentage);
            ListOfPercentages.Add(ninesInPercentage);
            ListOfPercentages.Add(tensInPercentage);
            ListOfPercentages.Add(elevensInPercentage);
            ListOfPercentages.Add(twelvesInPercentage);
            ListOfPercentages.Add(thirteensInPercentage);
            ListOfPercentages.Add(fourteensInPercentage);
            ListOfPercentages.Add(fifteensInPercentage);
            ListOfPercentages.Add(sixteensInPercentage);
            ListOfPercentages.Add(seventeensInPercentage);
            ListOfPercentages.Add(eighteensInPercentage);
            ListOfPercentages.Add(nineteensInPercentage);
            ListOfPercentages.Add(twentiesInPercentage);
        }
        #endregion
    }
}
