using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class User
    {
        int id;
        String name;
        String paternal_last_name;
        String maternal_last_name;
        String phone;
        String email;
        char gender;
        String address;
        String profile;
        String username;
        String password;
        int status;

        public User( int id,string profile_id,string name,string middle_name,
                        string last_name, string phone,string email,char gender,string address)
        {
            this.id = id;
            this.profile = profile_id;
            this.name = name;
            this.maternal_last_name = middle_name;
            this.paternal_last_name = last_name;
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
            this.maternal_last_name = middle_name;
            this.paternal_last_name = last_name;
        }

        public User()
        {

        }

        public void print()
        {
            Console.WriteLine(name + " " + paternal_last_name);
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Paternal_last_name
        {
            get
            {
                return paternal_last_name;
            }

            set
            {
                paternal_last_name = value;
            }
        }

        public string Maternal_last_name
        {
            get
            {
                return maternal_last_name;
            }

            set
            {
                maternal_last_name = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Profile
        {
            get
            {
                return profile;
            }

            set
            {
                profile = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }


        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
    }
}
