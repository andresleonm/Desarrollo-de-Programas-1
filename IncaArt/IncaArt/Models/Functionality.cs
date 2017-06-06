using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Functionality : IEquatable<Functionality>
    {
        int id;
        string name;
        string description;

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

        public Functionality(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public bool Equals(Functionality obj)
        {
            if (obj == null) return false;

            return this.id == obj.id;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Functionality funcObj = obj as Functionality;
            if (funcObj == null)
                return false;
            else
                return Equals(funcObj);
        }

        public override int GetHashCode()
        {
            return this.id.GetHashCode();
        }
    }
}
