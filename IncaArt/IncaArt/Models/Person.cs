using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Person
    {
        int id;
        string dni;
        string name;
        string paternal_last_name;
        string maternal_last_name;
        string phone;
        string email;
        char gender;
        string address;
        DateTime birthday;

        public Person(int id, string dni, string name, string paternal_last_name, string maternal_last_name, string phone,  string email, char gender, string address, DateTime birthday)
        {
            this.id = id;
            this.dni = dni;
            this.name = name;
            this.paternal_last_name = paternal_last_name;
            this.maternal_last_name = maternal_last_name;
            this.phone = phone;
            this.email = email;
            this.gender = gender;
            this.address = address;
            this.birthday = birthday;
        }

        public Person()
        {
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

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
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

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }
    }
}
