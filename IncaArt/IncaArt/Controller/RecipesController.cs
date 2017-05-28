using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataService;

namespace WindowsFormsApp1.Controller
{
    class RecipesController : DataService.DatabaseService
    {
        public RecipesController(string user, string password) : base(user, password)
        {
        }

        public Result getRecipes()
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result = execute_function("get_recipes", parameters);
            List<Models.Recipe> recipes = new List<Models.Recipe>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    //"RECIPE_ID",      0
                    //"PRODUCT_ID",     1
                    //"RECIPE_NAME"     2
                    recipes.Add(new Models.Recipe(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2)));
                }
                return new Result(recipes, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getRecipe(int id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", id.ToString()));
            GenericResult result = execute_function("get_recipe", parameters);
            if (result.success)
            {
                //"RECIPE_ID",          0
                //"PRODUCT_ID",         1
                //"RECIPE_NAME",        2
                //"RECIPE_DESCRIPTION"  3
                var r = result.data[0];
                Models.Recipe recipe = new Models.Recipe(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), r.getColumn(2), r.getColumn(3));
                return new Result(recipe, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertRecipe(Models.Recipe recipe)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("product_id", recipe.Product_id.ToString()));
            parameters.Add(new Parameter("name", recipe.Name));
            parameters.Add(new Parameter("description", recipe.Description));
            GenericResult result = execute_transaction("insert_recipe", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateRecipe(Models.Recipe recipe)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", recipe.Id.ToString()));
            parameters.Add(new Parameter("product_id", recipe.Product_id.ToString()));
            parameters.Add(new Parameter("name", recipe.Name));
            parameters.Add(new Parameter("description", recipe.Description));
            GenericResult result = execute_transaction("update_recipe", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteRecipe(Models.Recipe recipe)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", recipe.Id.ToString()));
            GenericResult result = execute_transaction("delete_recipe", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getRecipeDetails(Models.Recipe recipe)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("id", recipe.Id.ToString()));
            GenericResult result = execute_function("get_recipe_details", parameters);
            List<Models.RecipeDetail> recipe_details = new List<Models.RecipeDetail>();
            if (result.success)
            {
                foreach (Row r in result.data)
                {
                    //"RECIPE_ID",      0
                    //"MATERIAL_ID",    1
                    //"QUANTITY"        2
                    recipe_details.Add(new Models.RecipeDetail(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), Int32.Parse(r.getColumn(2))));
                }
                return new Result(recipe_details, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result getRecipeDetail(int recipe_id, int material_id)
        {
            //consultar permisos
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("recipe_id", recipe_id.ToString()));
            parameters.Add(new Parameter("id", material_id.ToString()));
            GenericResult result = execute_function("get_recipe", parameters);
            if (result.success)
            {
                //"RECIPE_ID",      0
                //"MATERIAL_ID",    1
   		        //"QUANTITY"        2
                var r = result.data[0];
                Models.RecipeDetail recipe_detail = new Models.RecipeDetail(Int32.Parse(r.getColumn(0)), Int32.Parse(r.getColumn(1)), Int32.Parse(r.getColumn(2)));
                return new Result(recipe_detail, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result insertRecipeDetail(Models.RecipeDetail detail)
        {
            List<Parameter> parameters = new List<Parameter>();
            GenericResult result;
            parameters.Add(new Parameter("recipe_id", detail.Recipe_id.ToString()));
            parameters.Add(new Parameter("material_id", detail.Material_id.ToString()));
            parameters.Add(new Parameter("quantity", detail.Quantity.ToString()));
            result = execute_function("insert_recipe_detail", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result updateRecipeDetail(Models.RecipeDetail detail)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("recipe_id", detail.Recipe_id.ToString()));
            parameters.Add(new Parameter("material_id", detail.Material_id.ToString()));
            parameters.Add(new Parameter("quantity", detail.Quantity.ToString()));
            GenericResult result = execute_transaction("update_recipe_detail", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }

        public Result deleteRecipeDetail(Models.RecipeDetail detail)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("recipe_id", detail.Recipe_id.ToString()));
            parameters.Add(new Parameter("material_id", detail.Material_id.ToString()));
            GenericResult result = execute_transaction("delete_recipe_detail", parameters);
            if (result.success)
            {
                return new Result(result.singleValue, true, "");
            }
            return new Result(null, result.success, result.message);
        }
    }
}
