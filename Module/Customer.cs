using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    // próba push Gitre / Flóra
    public class Customer
    {
      public Customer()
        {
            table = new List<int>();
        }
        public string NameCustomer { get; set; }
        public string PhoneCustomer { get; set; }

        public List<int> table { get; set; }

        public double Price
        {
            get 
            { return table.Count * 10; }
        }


        public override string ToString()
        {
            return this.NameCustomer;
        }
    }

}
