using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
  public  class RateBlock
    {

        public static readonly string BLOCK_TYPE_FIRST = "First";
        public static readonly string BLOCK_TYPE_NEXT = "Next";
        public static readonly string BLOCK_TYPE_OVER = "Over";


        public Int32 RateBlockNumber { get; set; }
        public String RateBlockType { get; set; }
        public Double RateBlockQuantity { get; set; }
        public Double Rate { get; set; }



    }
}
