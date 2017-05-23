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
        Person person;
        String shift;
        int status;

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

        public string Shift
        {
            get
            {
                return shift;
            }

            set
            {
                shift = value;
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

        internal Person Person
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
    }
}
