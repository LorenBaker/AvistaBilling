using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
    public class MeterReadingItem
    {
        // DataGridView column numbers
        public static readonly int SERVICE_TYPE = 0;
        public static readonly int METER_NUMBER = 1;
        public static readonly int RATE_SCHEDULE = 2;
        public static readonly int PREVIOUS_READING = 3;
        public static readonly int CURRENT_READING = 4;
        public static readonly int MULTIPLIER = 5;
        public static readonly int USAGE = 6;
        public static readonly int CITY_TAX = 7;
        public static readonly int AMOUNT = 8;
        public static readonly int RATE_SCHEDULE_UUID = 9;

        public string ServiceType { get; set; }
        public string MeterNumber { get; set; }
        public Int32 RateScheduleNumber { get; set; }
        public double PreviousReading { get; set; }
        public double CurrentReading { get; set; }
        public double MeterMultiplier { get; set; }
        public double Usage { get; set; }
        public double CityTax { get; set; }
        public double Amount { get; set; }
        public Guid CurrentRateScheduleUuid { get; set; }
    }
}
