using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Shift
    {
        int id;
        String description;
        private DateTime begin_date;
        private DateTime end_date;
        String state;

        public Shift()
        {
        }

        public Shift(int id, string description)
        {
            this.id = id;
            this.description = description;
        }

        public Shift(int id, string description, DateTime begin_date, DateTime end_date, string state)
        {
            this.id = id;
            this.description = description;
            this.begin_date = begin_date;
            this.end_date = end_date;
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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public DateTime Begin_date
        {
            get
            {
                return begin_date;
            }

            set
            {
                begin_date = value;
            }
        }

        public DateTime End_date
        {
            get
            {
                return end_date;
            }

            set
            {
                end_date = value;
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
