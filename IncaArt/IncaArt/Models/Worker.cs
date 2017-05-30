using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Worker
    {
        int id;
        int shift_id;
        string name;
        string paternal_name;
        string maternal_name;
        string phone;
        string email;
        char gender;
        string address;
        string doi;
        string telephone;
        DateTime birthday;
        double salary;
        int currency_id;

        public Worker(int id,int shift_id, string name,string paternal_name,string maternal_name, string doi)
        {
            this.id = id;
            this.shift_id = shift_id;
            this.name = name;
            this.paternal_name = paternal_name;
            this.maternal_name = maternal_name;
            this.doi = doi;
        }

        public Worker(int id, int shift_id, string name, string paternal_name, string maternal_name, string doi,DateTime birthday,char gender,string telephone,string phone,string email,string address,double salary)
        {
            this.id = id;
            this.shift_id = shift_id;
            this.name = name;
            this.paternal_name = paternal_name;
            this.maternal_name = maternal_name;
            this.doi = doi;
            this.birthday = birthday;
            this.gender = gender;
            this.telephone = telephone;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.salary = salary;
        }

        public Worker()
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

        public int Shift_id
        {
            get
            {
                return shift_id;
            }

            set
            {
                shift_id = value;
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

        public string Paternal_name
        {
            get
            {
                return paternal_name;
            }

            set
            {
                paternal_name = value;
            }
        }

        public string Maternal_name
        {
            get
            {
                return maternal_name;
            }

            set
            {
                maternal_name = value;
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

        public string Doi
        {
            get
            {
                return doi;
            }

            set
            {
                doi = value;
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

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public int Currency_id
        {
            get
            {
                return currency_id;
            }

            set
            {
                currency_id = value;
            }
        }
    }
}
