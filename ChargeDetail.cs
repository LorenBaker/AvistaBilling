using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
    public class ChargeDetail
    {
        public string Description {get; set;}
        public double Quantity { get; set; }
        public string Units { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
    }


}
