using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class ProductLineAssignment
    {
        internal List<Assignment> assignments;

        public ProductLineAssignment(Product product)
        {
            assignments = new List<Assignment>(product.production_line.Count());
            for(int i=0; i < assignments.Count(); i++)
            {
                assignments.Add(new Assignment(new Workstation(product, product.production_line.ElementAt(i))));
            }
        }


    }
}
