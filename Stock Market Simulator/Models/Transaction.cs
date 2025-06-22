using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerShare { get; set; }
        public DateTime Time { get; set; }
        public bool IsBuyingOrSelling { get; set; }
    }
}
