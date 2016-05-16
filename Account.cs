using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
    public class Account
    {
        public static readonly string AVISTA = "Avista";
        public static readonly string INLAND = "Inland";
        public static readonly string KTU = "KTU";

        public Account()
        {
            Location = new Location();
            Meters = new List<Meter>();
            Uuid = Guid.NewGuid();
            SortKey = NextSortKey;
            isSelected = true;
        }

        public Guid Uuid { get; set; }
        public Int32 SortKey { get; set; }
        public String Number { get; set; }
        public Location Location { get; set; }
        public List<Meter> Meters { get; set; }
        public String Utiltiy { get; set; }
        public bool isSelected { get; set; }



        private static Int32 mNextSortKey = 1;
        public static Int32 NextSortKey
        {
            get
            {
                return mNextSortKey++;
            }

        }

        public override string ToString()
        {
            return "Account: " + Number +" - " + Location.Address1 + "; " + Location.Address2;
        }

    }
}
