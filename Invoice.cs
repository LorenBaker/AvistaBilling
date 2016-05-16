using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
    public class Invoice
    {
        public Invoice()
        {
            MeterReadingItems = new List<MeterReadingItem>();
        }

        public Guid AccountUuid { get; set; }

        public DateTime BillingDate { get; set; }
        public DateTime ReadDate { get; set; }
        public DateTime PreviousReadDate { get; set; }

        public List<MeterReadingItem> MeterReadingItems { get; set; }

        public Double TotalTherms_NatGas { get; set; }
        public Double TotalKWH_Energy { get; set; }
        public Double TotalKW_Demand { get; set; }

        public Double TotalUsageCharges { get; set; }
        public Double TotalCityTax { get; set; }
        public Double TotalAmount { get; set; }

        public Boolean TotalChargesMatch { get; set; }
        public Boolean WrongRateSchedule { get; set; }

        public string ServiceMonth
        {
            get
            {
                string result = "N/A";
                if (ReadDate != null)
                    if (ReadDate > new DateTime(1954, 1, 1))
                    {
                        {
                            int month = ReadDate.Month;
                            int year = ReadDate.Year;
                            month--;
                            if (month < 1)
                            {
                                month = 12;
                                year--;
                            }

                            DateTime serviceMonthDateTime = new DateTime(year, month, 1);

                            result = serviceMonthDateTime.ToString("MMM yyyy");
                        }
                    }
                return result;
            }


        }

        public void SetDaysInServiceMonth()
        {
            daysInServiceMonth = -1;
            if (ReadDate != null && PreviousReadDate != null)
            {
                TimeSpan timeSpan = ReadDate - PreviousReadDate;
                daysInServiceMonth = timeSpan.Days;
            }
        }
        private Int32 daysInServiceMonth = -1;
        ////public Int32 DaysInServiceMonth
        ////{
        ////    get
        ////    {
        ////        return daysInServiceMonth;
        ////    }
           
        ////}
    }
}
