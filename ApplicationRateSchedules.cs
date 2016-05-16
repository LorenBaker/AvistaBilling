using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
    public class ApplicationRateSchedules
    {
        public ApplicationRateSchedules()
        {
            Items = new List<RateSchedule>();
        }

        public IList<RateSchedule> Items { get; set; }
        public Int32 Count
        {
            get { return Items.Count; }
        }

        //private List<Int32> rateSchedules;
        //    public List<Int32> RateSchedules { 
        //    get
        //    {
        //        return rateSchedules;
        //    }

        //    set
        //    {
        //        rateSchedules = retrieveRateSchedules();
        //    }
        //}

        //private List<Int32> retrieveRateSchedules()
        //{
        //    List<Int32> rateSchedules = frmMain.AppData.Accounts.
        //           .Select(e => e.)
        //           .Distinct()
        //           .ToList();

        //    return rateSchedules;
        //}

        public void sort()
        {
            Items = Items.OrderByDescending(o => o.EffectiveDate).ToList();
        }

        public RateSchedule getRateSchedule(Guid uuid)
        {
            foreach (RateSchedule rateSchedule in Items)
            {
                if (rateSchedule.Uuid.Equals(uuid))
                {
                    return rateSchedule;
                }
            }

            // did not find a match
            return null;
        }

        public RateSchedule getRateSchedule(Int32 schedule, DateTime date)
        {
            // NOTE: NEEDS TO BE RUN ON A SORTED LIST!
            foreach (RateSchedule rateSchedule in Items)
            {
                if (rateSchedule.ScheduleNumber == schedule && rateSchedule.EffectiveDate < date)
                {
                    return rateSchedule;
                }
            }

            // did not find a match
            return null;
        }
    }
}
