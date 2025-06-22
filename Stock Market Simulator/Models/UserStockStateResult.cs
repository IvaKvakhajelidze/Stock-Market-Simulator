using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3.Models
{
    public class UserStockStateResult
    {
        public bool Found {  get; set; }
        public decimal lastPrice { get; set; }
        public DateTime lastSeen { get; set; }
    }
}
