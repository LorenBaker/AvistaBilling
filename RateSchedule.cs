using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
    public class RateSchedule
    {
        public RateSchedule()
        {
            Uuid = Guid.NewGuid();

        }
        public Guid Uuid { get; set; }
        public Int32 ScheduleNumber { get; set; }
        public string Utility { get; set; }
        public string TypeOfService { get; set; }
        public DateTime EffectiveDate { get; set; }
        public double BasicCharge { get; set; }
        public double MinimumCharge { get; set; }
        public double CityTaxRate { get; set; }
        public bool hasDemandRates { get; set; }

        private IList<RateBlock> rateBlocksList = new List<RateBlock>();
        public IList<RateBlock> RateBlocks
        {
            get
            {
                List<RateBlock> sortedRateBlocksList = rateBlocksList.OrderBy(o => o.RateBlockNumber).ToList();
                rateBlocksList = sortedRateBlocksList;
                return rateBlocksList;
            }
            set { this.rateBlocksList = value; }
        }

        private IList<RateBlock> demandRateBlocksList = new List<RateBlock>();
        public IList<RateBlock> DemandRateBlocks
        {
            get { return this.demandRateBlocksList; }
            set { this.demandRateBlocksList = value; }
        }

        public override string ToString()
        {
            return ScheduleNumber.ToString();
        }

        //public Boolean hasDemandRates()
        //{
        //    return demandRateBlocksList.Count > 0;
        //}

        public Boolean isNaturalGasRateSchedule()
        {
            return TypeOfService.Equals(Meter.NAT_GAS);
        }


    }
}
