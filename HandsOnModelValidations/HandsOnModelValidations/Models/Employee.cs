using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HandsOnModelValidations.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="plz enter Id")]
        [DisplayName("Employee Id")]
        public int ID { get; set; }
        [Required(ErrorMessage = "plz enter Name")]
        [StringLength(maximumLength:20,ErrorMessage ="Name should be entered")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Id")]
        public string Email { get; set; }
        [Required(ErrorMessage ="plz enter mobile")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Username is Required")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression("[a-z0-9]{6,8}")]
        public string Pwd{get; set; }
        [Compare("Pwd",ErrorMessage ="Password Mismatch")]
        public string Cpwd { get; set; }

    }
}
