using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPark.Models
{
    
        public class OpeningHour
        {
            public List<string> weekdays { get; set; }
            public bool excludePublicHoliday { get; set; }
            public string periodStart { get; set; }
            public string periodEnd { get; set; }
        }

        public class MotorCycle
        {
            public int space { get; set; }
        }

        public class Coach
        {
            public int space { get; set; }
        }

        public class HGV
        {
            public int space { get; set; }
        }

        public class LGV
        {
            public int space { get; set; }
        }

        public class PrivateCar
        {
            public int space { get; set; }
        }

        public class RenditionUrls
        {
            public string square { get; set; }
            public string thumbnail { get; set; }
            public string banner { get; set; }
        }

        public class Result
        {
            public int _id { get; set; }
            public string name { get; set; }
            public string nature { get; set; }
            public string type { get; set; }
            public List<OpeningHour> openingHours { get; set; }
            public MotorCycle motorCycle { get; set; }
            public Coach coach { get; set; }
            public HGV HGV { get; set; }
            public LGV LGV { get; set; }
            public PrivateCar privateCar { get; set; }
            public List<double> coordinates { get; set; }
            public RenditionUrls renditionUrls { get; set; }
        }

        public class CarParkData
        {
            public List<Result> results { get; set; }
        }
    
}
