using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Client
    {
        int id;
        Company company;
        Person person;
        int status;

        public Client(int id, Person person, int status, Company company)
        {
            this.id = id;
            this.company = company;
            this.status = status;
            this.person = person;
        }

        public Person Person
        {
            get
            {
                return person;
            }

            set
            {
                person = value;
            }
        }

        internal Company Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
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
    }
}
