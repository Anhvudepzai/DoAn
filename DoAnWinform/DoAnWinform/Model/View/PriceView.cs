using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform.Model
{
    public class PriceView
    {
        public string IDCustomer { get; set; }
        public string IDPrice { get; set; } 
        public string CustomerName { get; set; }
        public string ServiceName { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public double? ToTal { get; set; }
    }
}
