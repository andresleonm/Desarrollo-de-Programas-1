using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Supplier
    {
        int id;
        String name;
        String address;
        String doi;
        String phone;
        String email;
        String type;
        int priority;
        String state;

        public Supplier(int id, string name, string address, string doi, string phone, string email, string type, int priority, string state)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.doi = doi;
            this.phone = phone;
            this.email = email;
            this.type = type;
            this.priority = priority;
            this.state = state;
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

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Priority
        {
            get
            {
                return priority;
            }

            set
            {
                priority = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }
    }
}
