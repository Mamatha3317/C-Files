using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMVC.Models
{
    public class SubCategory:Category
    {
        
        [Key]
        public int Sub_id { get  ; set ; }
        public string Sub_name { get ; set ; }
        public float GST { get ; set ; }

        
    }
}
