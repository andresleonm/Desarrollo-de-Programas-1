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
        String state;


        public Supplier()
        {

        }
        public Supplier(int id, string name, string address, string doi, string phone, string email, string state)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.doi = doi;
            this.phone = phone;
            this.email = email;
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

        public Supplier(string txt_name, string txt_address, string txt_phone, string txt_Doi)
        {
            this.name = txt_name;
            this.address = txt_address;
            this.phone = txt_phone;
            this.doi = txt_Doi;
        }
    }
}
