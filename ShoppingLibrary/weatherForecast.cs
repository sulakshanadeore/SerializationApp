using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    [Serializable]
    public class weatherForecast
    {
        public DateTime ForecastDate { get; set; }
        public int Temperature { get; set; }
        public string DaySummary { get; set; }

    }
}
