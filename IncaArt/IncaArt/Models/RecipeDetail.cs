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
        int material_id;
        int quantity;
        char operation;
        string unit;

        public RecipeDetail(int recipe_id, int material_id, int quantity)
        {
            this.recipe_id = recipe_id;
            this.material_id = material_id;
            this.quantity = quantity;
        }

        public RecipeDetail(int recipe_id, int material_id, string unit, int quantity)
        {
            this.recipe_id = recipe_id;
            this.material_id = material_id;
            this.unit = unit;
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

        public int Material_id
        {
            get
            {
                return material_id;
            }

            set
            {
                material_id = value;
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

        public string Unit
        {
            get
            {
                return unit;
            }

            set
            {
                unit = value;
            }
        }
    }
}