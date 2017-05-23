using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Person
    {
        int id;
        int dni;
        String name;
        String paternal_last_name;
        String maternal_last_name;
        String phone;
        String telephone;
        String email;
        char gender;
        String address;
        String birthday;

        public Person(int id, int dni, string name, string paternal_last_name, string maternal_last_name, string phone, string telephone, string email, char gender, string address, string birthday)
        {
            this.id = id;
            this.dni = dni;
            this.name = name;
            this.paternal_last_name = paternal_last_name;
            this.maternal_last_name = maternal_last_name;
            this.phone = phone;
            this.telephone = telephone;
            this.email = email;
            this.gender = gender;
            this.address = address;
            this.birthday = birthday;
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

        public int Dni
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

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
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

        public string Birthday
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
