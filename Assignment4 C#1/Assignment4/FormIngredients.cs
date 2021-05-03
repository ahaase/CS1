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
    /// Klass som hanterar en Winforms Form som hanterar ingredients.
    /// </summary>
    public partial class FormIngredients : Form
    {
        private Recipe recipe;

        /// <summary>
        /// Konstruktor för Form där användaren lägger till, ändrar eller tar bort ingredients.
        /// </summary>
        /// <param name="recipe">Receptet som ska ändras.</param>
        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
            for(int i = 0; i < recipe.IngredientCount; i++)
            {
                ingredientsListBox.Items.Add(recipe.Ingredients[i]);
            }
            ingredientsCountLabel.Text = recipe.IngredientCount.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ingredientTextBox.Text))
            {
                if(recipe.AddIngredient(ingredientTextBox.Text))
                {
                    ingredientsListBox.Items.Add(ingredientTextBox.Text);
                    ingredientTextBox.Text = string.Empty;
                    ingredientsCountLabel.Text = recipe.IngredientCount.ToString();
                    ingredientTextBox.Select();
                }
                else
                {
                    MessageBox.Show("Could not add ingredient!\n" +
                        "Either the maximum ingredients has been reached\n" +
                        "or the ingredient is already in the recipe.", "Error");
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(ingredientsListBox.SelectedIndex >= 0 && !string.IsNullOrEmpty(ingredientTextBox.Text))
            {
                if (recipe.EditIngredient(ingredientsListBox.Items[ingredientsListBox.SelectedIndex].ToString(),
                    ingredientTextBox.Text))
                {
                    ingredientsListBox.Items[ingredientsListBox.SelectedIndex] = ingredientTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Could not edit ingredient!\n" +
                        "Is the new ingredient already in the list of ingredients?", "Error");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(ingredientsListBox.SelectedIndex >= 0)
            {
                if(recipe.RemoveIngredient(ingredientsListBox.Items[ingredientsListBox.SelectedIndex].ToString()))
                {
                    ingredientsListBox.Items.RemoveAt(ingredientsListBox.SelectedIndex);
                    ingredientsCountLabel.Text = recipe.IngredientCount.ToString();
                }
                else
                {
                    MessageBox.Show("Could not remove ingredient because it doesn't exist!!!!", "Big Error");
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
