using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvistaBilling
{
    public class ApplicationAccounts
    {
        public ApplicationAccounts()
        {
            Items = new List<Account>();
        }
        public List<Account> Items { get; set; }
        public Int32 Count
        {
            get { return Items.Count; }
        }

        internal Account getAccount(Guid accountUuid)
        {
            return Items.Find(x => x.Uuid.Equals(accountUuid));
        }

        public void sort()
        {
            Items = Items.OrderBy(o => o.SortKey).ToList();
            // refresh each items sort key
            Int32 sortKey = 1;
            foreach (Account item in Items)
            {
                item.SortKey = sortKey;
                sortKey++;
            }
        }
    }
}
