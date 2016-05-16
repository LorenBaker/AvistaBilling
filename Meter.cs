using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
    public class Meter
    {

        public static readonly string ELECTRIC = "Electric";
        public static readonly string DEMAND = "Demand";
        public static readonly string NAT_GAS = "Natural Gas";
        public Meter()
        {
            Uuid = Guid.NewGuid();
            MeterNumber = "";
            MeterType = ELECTRIC;
            MeterMultiplier = 0;
            RateScheduleNumber = 11;
        }

        public Guid Uuid { get; set; }
        public String MeterNumber { get; set; }
        public String MeterType { get; set; }
        public Double MeterMultiplier { get; set; }
        public Int32 RateScheduleNumber { get; set; }

        //public Int32 PreviousRateScheduleNumber { get; set; }
        //public Double PreviousReading { get; set; }

        public override string ToString()
        {
            return "Meter: " + MeterNumber + "; " + MeterType;
        }
    }
}
