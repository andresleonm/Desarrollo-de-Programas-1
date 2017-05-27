using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class RecipeDetail
    {
        int recipe_id;
        int product_id;
        int quantity;
        char operation;
        public RecipeDetail(int recipe_id,int product_id,int quantity)
        {
            this.recipe_id = recipe_id;
            this.product_id = product_id;
            this.quantity = quantity;
        }

        public int Recipe_id
        {
            get
            {
                return recipe_id;
            }

            set
            {
                recipe_id = value;
            }
        }

        public int Product_id
        {
            get
            {
                return product_id;
            }

            set
            {
                product_id = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public char Operation
        {
            get
            {
                return operation;
            }

            set
            {
                operation = value;
            }
        }
    }
}
