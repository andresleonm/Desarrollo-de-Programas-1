﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class User
    {
        private int id;
        private string name;
        private string middlename;
        private string lastname;
        private string phone;
        private string email;
        private char gender;
        private string address;
        private Profile profile;
        private string nickname;
        private string password;
        private int status;

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

        public string Middlename
        {
            get
            {
                return middlename;
            }

            set
            {
                middlename = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
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

        internal Profile Profile
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

        public string Nickname
        {
            get
            {
                return nickname;
            }

            set
            {
                nickname = value;
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

        public User(int id, Profile profile, string name, string middlename, string lastname, string phone, string email, char gender, string address)
        {
            this.id = id;
            this.profile = profile;
            this.name = name;
            this.lastname = middlename;
            this.middlename = lastname;
            this.phone = phone;
            this.email = email;
            this.gender = gender;
            this.address = address;
        }

        public User()
        {

        }
    }
}
