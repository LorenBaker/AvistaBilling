using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
     public class ApplicationData
    {     
        public ApplicationAccounts Accounts { get; set; }
        public ApplicationInvoices Invoices { get; set; }
        public ApplicationRateSchedules RateSchedules { get; set; }
        public  List<Int32> RateScheduleNumbers { get; set; }

        public ApplicationData()
        {
            Invoices = new ApplicationInvoices();
            Accounts = new ApplicationAccounts();
            RateSchedules = new ApplicationRateSchedules();
            RateScheduleNumbers = new List<Int32>();
        }

        internal void addMeterRateScheduleNumber(int rateScheduleNumber)
        {
            if (!RateScheduleNumbers.Contains(rateScheduleNumber))
            {
                RateScheduleNumbers.Add(rateScheduleNumber);
                RateScheduleNumbers.Sort();
            }
        }
    }
}
