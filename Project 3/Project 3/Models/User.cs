using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project_3.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public decimal Balance { get; set; }
        public int Password {  get; set; }
        public DateTime JourneyCreationDate { get; set; }

    }
}
