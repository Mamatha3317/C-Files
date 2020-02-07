using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMVC.Models
{
    public class Items
    {
        [Key]
        public int iid { set; get; }
        public double price { set; get; }
        public string itemname { set; get; }
        public string description { set; get; }
        public int stock_number { set; get; }
        public string remarks { set; get; }




    }
}
