using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMVC.Models
{
    public class Seller
    {
        [Key]
        public string Sname { get; set; }
        public string Companyname { get ; set ; }
        public string Website { get ; set ; }
        public string Semail { get ; set ; }
        public string Spassword { get ; set ; }
        public string Saddress { get ; set ; }
        public int Contactno { get ; set; }
        public int Sid { get ; set ; }

       
    }
}
