using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Haase
/// </summary>
namespace Assignment4
{
    /// <summary>
    /// Enum med typer of mat.
    /// </summary>
    public enum FoodCategory
    {
        Meats,
        Pasta,
        Pizza,
        Fish,
        Seafood,
        Soups,
        Stew,
        Vegan,
        Vegetarian,
        Vegetarian_Dairy_Egg,
        Other
    }

    /// <summary>
    /// Klass som håller reda på ett recept-objekt.
    /// </summary>
    public class Recipe
    {
        private string[] ingredients;
        private string name;
        private string instructions;
        private int ingredientsCount;
        private FoodCategory category;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        public Recipe()
        {
            ingredients = new string[50];
            name = "Unnamed recipe";
            instructions = "No instructions.";
            category = FoodCategory.Other;
            ingredientsCount = 0;
        }

        /// <summary>
        /// Hämtar name.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Hämtar instructions.
        /// </summary>
        public string Instructions
        {
            get
            {
                return instructions;
            }
        }

        /// <summary>
        /// Hämtar antalet ingredients.
        /// </summary>
        public int IngredientCount
        {
            get
            {
                return ingredientsCount;
            }
        }

        /// <summary>
        /// Hämtar matkategori.
        /// </summary>
        public FoodCategory Category
        {
            get
            {
                return category;
            }
        }
        
        /// <summary>
        /// Hämtar ingredients.
        /// </summary>
        public string[] Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="name">Namnet</param>
        /// <param name="ingredients">Ingredienserna.</param>
        /// <param name="ingredientCount">Hur många ingredienser som finns med i Arrayen.</param>
        /// <param name="instructions">Instruktionerna</param>
        /// <param name="category">Matkategorin.</param>
        public Recipe(string name, string[] ingredients, int ingredientCount, string instructions, FoodCategory category)
        {
            this.ingredients = ingredients;
            this.name = (name == string.Empty ? "Unnamed recipe" : name);
            this.instructions = (instructions == string.Empty ? "No instructions" : instructions);
            this.category = category;
            this.ingredientsCount = ingredientCount;
        }

        /// <summary>
        /// Lägger till en ingrediens.
        /// </summary>
        /// <param name="s">Ingrediensen som ska läggas till.</param>
        /// <returns>Om det gick att lägga till.</returns>
        public bool AddIngredient(string s)
        {
            if(!ingredients.Contains(s))
            {
                if(ingredientsCount < ingredients.Length)
                {
                    ingredients[ingredientsCount] = s;
                    ingredientsCount++;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Ändrar en ingrediens.
        /// </summary>
        /// <param name="s">Ingrediensen som ska ändras.</param>
        /// <returns>Om det gick att ändra.</returns>
        public bool EditIngredient(string s, string newString)
        {
            if(ingredients.Contains(s) && !ingredients.Contains(newString))
            {
                for(int i = 0; i < ingredientsCount; i++)
                {
                    if(ingredients[i].Equals(s))
                    {
                        ingredients[i] = newString;
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Tar bort en ingrediens.
        /// </summary>
        /// <param name="s">Ingrediensen som ska tas bort.</param>
        /// <returns>Om det gick att ta bort.</returns>
        public bool RemoveIngredient(string s)
        {
            if(ingredients.Contains(s))
            {
                for(int i = 0; i < ingredientsCount; i++)
                {
                    if(ingredients[i].Equals(s))
                    {
                        if(i < ingredientsCount - 1)
                        {
                            for (int j = i; j < ingredientsCount - 1; j++)
                            {
                                ingredients[j] = ingredients[j + 1];
                                ingredients[j + 1] = null;
                            }
                            ingredientsCount--;
                            return true;
                        }
                        else if(i == ingredientsCount - 1)
                        {
                            ingredients[i] = null;
                            ingredientsCount--;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
