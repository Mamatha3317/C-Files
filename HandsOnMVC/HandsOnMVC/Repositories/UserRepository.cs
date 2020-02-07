using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVC.Models;
namespace HandsOnMVC.Repositories
{
    public class UserRepository
    {
        public static List<User> list;
        public UserRepository()
        {

            list = new List<User>();
            list.Add(new User()
            {
                Name = "Manu",
                Country = "India",
                Uname = "Manu3317",
                Pwd = "4567"
            }
             );

        }
    




       
        public void Add(User item)
        {
            list.Add(item);//add user data into list
        }
        public User Validate(string uname,string pwd) 
        {
            foreach(var item in list)
            {
                if(item.Uname==uname && item.Pwd==pwd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
