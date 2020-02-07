using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HandsOnMVC.Models
{
    public class User
    {
        [Required(ErrorMessage = "plz enter Name")]
        [StringLength(maximumLength: 20, ErrorMessage = "Name should be entered")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Id")]
        public string Email { get; set; }
        [Required(ErrorMessage = "DOB is Required")]
        [DisplayName("DOB")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage ="Invalid mobile no")]
        [DisplayName("Mobile")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Country is Required")]
        [DisplayName("Country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Username is Required")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression("[a-z0-9]{6,8}")]
        public string Pwd { get; set; }

    }

}
