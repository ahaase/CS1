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
    /// Klass för ett objekt som hanterar recept.
    /// </summary>
    class RecipeManager
    {
        private Recipe[] recipes;
        private int count;
        
        /// <summary>
        /// Konstruktor.
        /// </summary>
        public RecipeManager(int maxRecipes)
        {
            recipes = new Recipe[maxRecipes];
            count = 0;
        }

        /// <summary>
        /// Lägger till ett recept.
        /// </summary>
        /// <param name="r">Receptet som ska läggas till.</param>
        public bool AddRecipe(Recipe r)
        {
            if(count < recipes.Length)
            {
                recipes[count] = r;
                count++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tar bort ett recept vid vald index.
        /// </summary>
        /// <param name="index">Index av receptet som ska tas bort.</param>
        /// <returns>Om det gick att ta bort.</returns>
        public bool RemoveRecipeAt(int index)
        {
            if(CheckIndex(index))
            {
                recipes[index] = null;
                for(int i = index; i < count - 1; i++)
                {
                    recipes[i] = recipes[i + 1];
                    recipes[i + 1] = null;
                }
                count--;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Hämtar ett recept vid vald index.
        /// </summary>
        /// <param name="index">Index av receptet som ska hämtas.</param>
        /// <returns>Det valda receptet.</returns>
        public Recipe GetRecipeAt(int index)
        {
            if(CheckIndex(index))
            {
                return recipes[index];
            }
            return null;
        }

        /// <summary>
        /// Ändrar ett recept i ett index till ett nytt.
        /// </summary>
        /// <param name="index">Index av gamla receptet.</param>
        /// <param name="recipe">Nya receptet.</param>
        /// <returns>Om det gick att byta ut.</returns>
        public bool SetRecipeAt(int index, Recipe recipe)
        {
            if (CheckIndex(index))
            {
                recipes[index] = recipe;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Kontrollerar att ett index är giltigt.
        /// </summary>
        /// <param name="index">Index som ska kontrolleras.</param>
        /// <returns>Om det är giltigt i Arrayen.</returns>
        public bool CheckIndex(int index)
        {
            if(index >= 0 && index < count)
            {
                return true;
            }
            return false;
        }
    }
}
