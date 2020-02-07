using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMVC.Models
{
    public class Buyer
    {
        [Key]
        public int Bid { get ; set  ; }
        public string Bname { get ; set ; }
        public string Baddress { get ; set ; }
        public string Bmail { get ; set ; }
        public int Phoneno { get ; set; }
        public string Bpassword { get ; set ; }
        public DateTime CreatedDate { get; set; }


    }
}
