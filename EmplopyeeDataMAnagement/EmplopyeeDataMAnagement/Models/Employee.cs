using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmplopyeeDataMAnagement.Models
{
    public enum department
    {
        It, Accounts, Insurance, HealthCare
    }
    public class Employee
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email  { get; set; }
        public  department Dept { get; set; }
        public int Amount { get; set; }
        public Employee()
        {

        }
        public Employee(int Id,string Name,string Email,int Amount)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Amount = Amount;
        }
    }


}
