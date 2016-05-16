using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
   public class Location
    {
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }

        public override string ToString()
        {
            String result = Address1;
            if (!Address2.Equals(""))
                result = result + Environment.NewLine + Address2;

            result = result + Environment.NewLine + City + ", " + State+" " + Zip;

            return result;
        }

        public string Name ()
        {
            return Address1 + ", " + Address2;
        }

    }
}
