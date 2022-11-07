using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunniva_Eggen_Appolonia.Models
{
    public class MapXmlCurrency
    {
        #region Properties
        public string? Currency { get; set; }
        public string? Rate { get; set; }
        #endregion

        #region Constructors
        public MapXmlCurrency(string? currency, string? rate)
        {
            Currency = currency;
            Rate = rate;
        }
        #endregion
    }
}
