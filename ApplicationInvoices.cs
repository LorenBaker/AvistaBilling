using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
    public class ApplicationInvoices
    {
        public ApplicationInvoices()
        {
            Items = new List<Invoice>();
        }
        public List<Invoice> Items { get; set; }
        public Int32 Count
        {
            get { return Items.Count; }
        }

    }
}
