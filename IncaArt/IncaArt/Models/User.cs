using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class User
    {
        public int id;
        public int profile_id;
        public string name;
        public string middle_name;
        public string last_name;
        public string phone;
        public string email;
        public string gender;
        public string address;
        public string password;

        public User( int id,int profile_id,string name,string middle_name,
                        string last_name, string phone,string email,string gender,string address)
        {
            this.id = id;
            this.profile_id = profile_id;
            this.name = name;
            this.middle_name = middle_name;
            this.last_name = last_name;
            this.phone = phone;
            this.email = email;
            this.gender = gender;
            this.address = address;
        }

        public User(int id,  string name, string middle_name,
                        string last_name)
        {
            this.id = id;
            this.name = name;
            this.middle_name = middle_name;
            this.last_name = last_name;
        }

        public void print()
        {
            Console.WriteLine(name + " " + middle_name);
        }
    }
}
