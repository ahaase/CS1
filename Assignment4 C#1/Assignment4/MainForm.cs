using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Haase
/// </summary>
namespace Assignment4
{
    /// <summary>
    /// Huvudsakliga Form-en.
    /// </summary>
    public partial class MainForm : Form
    {
        private RecipeManager recipeManager;
        private Recipe newRecipe;

        private const int maxIngredients = 50;
        private const int maxRecipes = 200;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            recipeManager = new RecipeManager(maxRecipes);
            newRecipe = new Recipe();
            foodCategoryComboBox.DataSource = Enum.GetValues(typeof(FoodCategory));
        }

        private void addIngredientsButton_Click(object sender, EventArgs e)
        {
            FormIngredients fi = new FormIngredients(newRecipe);
            fi.Show();
        }

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            Recipe newRecipe = getNewRecipe();
            if(recipeManager.AddRecipe(newRecipe))
            {
                addRecipeToListView(newRecipe);
                resetNewRecipeSection();
            }
            else
            {
                MessageBox.Show("Could not add recipe!\nMaximum " + maxRecipes + " recipes!!", "Error");
            }
        }

        private void clearSelectionButton_Click(object sender, EventArgs e)
        {
            recipeListView.SelectedItems.Clear();
            resetNewRecipeSection();
        }

        private void editBeginButton_Click(object sender, EventArgs e)
        {
            if(recipeListView.SelectedIndices.Count == 1)
            {
                newRecipe = recipeManager.GetRecipeAt(recipeListView.SelectedIndices[0]);
                nameTextBox.Text = newRecipe.Name;
                instructionsInputTextBox.Text = newRecipe.Instructions;
                foodCategoryComboBox.SelectedItem = newRecipe.Category;
            }
        }

        private void editFinishButton_Click(object sender, EventArgs e)
        {
            if(recipeListView.SelectedIndices.Count == 1)
            {
                recipeManager.SetRecipeAt(recipeListView.SelectedIndices[0], getNewRecipe());
                changeRecipeInListView(recipeListView.Items[recipeListView.SelectedIndices[0]],
                    recipeManager.GetRecipeAt(recipeListView.SelectedIndices[0]));
                resetNewRecipeSection();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (recipeListView.SelectedIndices.Count == 1)
            {
                recipeManager.RemoveRecipeAt(recipeListView.SelectedIndices[0]);
                recipeListView.Items.RemoveAt(recipeListView.SelectedIndices[0]);
            }
        }

        private void recipeListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(recipeListView.SelectedIndices.Count == 1)
            {
                Recipe recipe = recipeManager.GetRecipeAt(recipeListView.SelectedIndices[0]);
                StringBuilder sb = new StringBuilder();
                sb.Append("Ingredients: ");
                if(recipe.IngredientCount > 0)
                {
                    sb.Append(recipe.Ingredients[0]);
                    if(recipe.IngredientCount > 1)
                    {
                        for (int i = 1; i < recipe.IngredientCount; i++)
                        {
                            sb.Append(", ");
                            sb.Append(recipe.Ingredients[i]);
                        }
                    }
                }
                sb.Append("\n\nHow to: ");
                sb.Append(recipe.Instructions);
                MessageBox.Show(sb.ToString(), recipe.Name);
            }
        }

        /// <summary>
        /// Skapar ett ListViewItem och lägger till den till ListView:en med all recept.
        /// </summary>
        /// <param name="recipe">Det nya receptet.</param>
        private void addRecipeToListView(Recipe recipe)
        {
            ListViewItem lvi = new ListViewItem(recipe.Name);
            lvi.SubItems.Add(recipe.Category.ToString());
            lvi.SubItems.Add(recipe.IngredientCount.ToString());
            recipeListView.Items.Add(lvi);
        }

        /// <summary>
        /// Ändrar ett ListViewItem så att dne matchar det nya receptet.
        /// </summary>
        /// <param name="lvi">ListViewItemet i fråga.</param>
        /// <param name="recipe">Det nya receptet.</param>
        private void changeRecipeInListView(ListViewItem lvi, Recipe recipe)
        {
            lvi.SubItems.Clear();
            lvi.Text = recipe.Name;
            lvi.SubItems.Add(recipe.Category.ToString());
            lvi.SubItems.Add(recipe.IngredientCount.ToString());
        }

        /// <summary>
        /// Ställer om alla controls i vänstra delen av programmet.
        /// </summary>
        private void resetNewRecipeSection()
        {
            nameTextBox.Text = string.Empty;
            foodCategoryComboBox.SelectedIndex = 0;
            newRecipe = new Recipe("", new string[maxIngredients], 0, "", FoodCategory.Meats);
            instructionsInputTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Ställer in alla controls i vänstra delen i programmet så att de matchar det valda receptet.
        /// </summary>
        /// <param name="recipe">Det valda receptet.</param>
        public void setNewRecipeSection(Recipe recipe)
        {
            nameTextBox.Text = recipe.Name;
            foodCategoryComboBox.SelectedItem = recipe.Category;
            instructionsInputTextBox.Text = recipe.Instructions;
            newRecipe = recipe;
        }

        /// <summary>
        /// Hämtar receptet som skapas av användarens inmatning.
        /// </summary>
        /// <returns>Nya receptet.</returns>
        private Recipe getNewRecipe()
        {
            return new Recipe(nameTextBox.Text, newRecipe.Ingredients, newRecipe.IngredientCount, instructionsInputTextBox.Text,
                (FoodCategory)foodCategoryComboBox.SelectedItem);
        }
    }
}
