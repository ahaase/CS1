namespace Assignment4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader nameCol;
            this.addNewRecipeGroupBox = new System.Windows.Forms.GroupBox();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.instructionsInputTextBox = new System.Windows.Forms.TextBox();
            this.addIngredientsButton = new System.Windows.Forms.Button();
            this.foodCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameOfRecipeLabel = new System.Windows.Forms.Label();
            this.recipeListView = new System.Windows.Forms.ListView();
            this.categoryCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noOfIngredientsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editBeginButton = new System.Windows.Forms.Button();
            this.editFinishButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addNewRecipeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameCol
            // 
            nameCol.Text = "Name";
            nameCol.Width = 200;
            // 
            // addNewRecipeGroupBox
            // 
            this.addNewRecipeGroupBox.Controls.Add(this.addRecipeButton);
            this.addNewRecipeGroupBox.Controls.Add(this.instructionsInputTextBox);
            this.addNewRecipeGroupBox.Controls.Add(this.addIngredientsButton);
            this.addNewRecipeGroupBox.Controls.Add(this.foodCategoryComboBox);
            this.addNewRecipeGroupBox.Controls.Add(this.categoryLabel);
            this.addNewRecipeGroupBox.Controls.Add(this.nameTextBox);
            this.addNewRecipeGroupBox.Controls.Add(this.nameOfRecipeLabel);
            this.addNewRecipeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addNewRecipeGroupBox.Name = "addNewRecipeGroupBox";
            this.addNewRecipeGroupBox.Size = new System.Drawing.Size(389, 360);
            this.addNewRecipeGroupBox.TabIndex = 0;
            this.addNewRecipeGroupBox.TabStop = false;
            this.addNewRecipeGroupBox.Text = "Add new recipe";
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Location = new System.Drawing.Point(9, 325);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(370, 23);
            this.addRecipeButton.TabIndex = 7;
            this.addRecipeButton.Text = "Add Recipe";
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.addRecipeButton_Click);
            // 
            // instructionsInputTextBox
            // 
            this.instructionsInputTextBox.Location = new System.Drawing.Point(9, 98);
            this.instructionsInputTextBox.Multiline = true;
            this.instructionsInputTextBox.Name = "instructionsInputTextBox";
            this.instructionsInputTextBox.Size = new System.Drawing.Size(370, 221);
            this.instructionsInputTextBox.TabIndex = 6;
            // 
            // addIngredientsButton
            // 
            this.addIngredientsButton.Location = new System.Drawing.Point(242, 58);
            this.addIngredientsButton.Name = "addIngredientsButton";
            this.addIngredientsButton.Size = new System.Drawing.Size(137, 24);
            this.addIngredientsButton.TabIndex = 5;
            this.addIngredientsButton.Text = "Add Ingredients";
            this.addIngredientsButton.UseVisualStyleBackColor = true;
            this.addIngredientsButton.Click += new System.EventHandler(this.addIngredientsButton_Click);
            // 
            // foodCategoryComboBox
            // 
            this.foodCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodCategoryComboBox.FormattingEnabled = true;
            this.foodCategoryComboBox.Location = new System.Drawing.Point(123, 59);
            this.foodCategoryComboBox.Name = "foodCategoryComboBox";
            this.foodCategoryComboBox.Size = new System.Drawing.Size(113, 24);
            this.foodCategoryComboBox.TabIndex = 3;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(6, 58);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(65, 17);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(123, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(256, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameOfRecipeLabel
            // 
            this.nameOfRecipeLabel.AutoSize = true;
            this.nameOfRecipeLabel.Location = new System.Drawing.Point(6, 26);
            this.nameOfRecipeLabel.Name = "nameOfRecipeLabel";
            this.nameOfRecipeLabel.Size = new System.Drawing.Size(104, 17);
            this.nameOfRecipeLabel.TabIndex = 0;
            this.nameOfRecipeLabel.Text = "Name of recipe";
            // 
            // recipeListView
            // 
            this.recipeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            nameCol,
            this.categoryCol,
            this.noOfIngredientsCol});
            this.recipeListView.FullRowSelect = true;
            this.recipeListView.HideSelection = false;
            this.recipeListView.Location = new System.Drawing.Point(407, 12);
            this.recipeListView.MultiSelect = false;
            this.recipeListView.Name = "recipeListView";
            this.recipeListView.Size = new System.Drawing.Size(504, 307);
            this.recipeListView.TabIndex = 1;
            this.recipeListView.UseCompatibleStateImageBehavior = false;
            this.recipeListView.View = System.Windows.Forms.View.Details;
            this.recipeListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.recipeListView_MouseDoubleClick);
            // 
            // categoryCol
            // 
            this.categoryCol.Text = "Category";
            this.categoryCol.Width = 67;
            // 
            // noOfIngredientsCol
            // 
            this.noOfIngredientsCol.Text = "No. of ingredients";
            this.noOfIngredientsCol.Width = 170;
            // 
            // editBeginButton
            // 
            this.editBeginButton.Location = new System.Drawing.Point(407, 325);
            this.editBeginButton.Name = "editBeginButton";
            this.editBeginButton.Size = new System.Drawing.Size(102, 23);
            this.editBeginButton.TabIndex = 2;
            this.editBeginButton.Text = "Edit-Begin";
            this.editBeginButton.UseVisualStyleBackColor = true;
            this.editBeginButton.Click += new System.EventHandler(this.editBeginButton_Click);
            // 
            // editFinishButton
            // 
            this.editFinishButton.Location = new System.Drawing.Point(539, 325);
            this.editFinishButton.Name = "editFinishButton";
            this.editFinishButton.Size = new System.Drawing.Size(103, 23);
            this.editFinishButton.TabIndex = 3;
            this.editFinishButton.Text = "Edit-Finish";
            this.editFinishButton.UseVisualStyleBackColor = true;
            this.editFinishButton.Click += new System.EventHandler(this.editFinishButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(676, 325);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Location = new System.Drawing.Point(790, 325);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(121, 23);
            this.clearSelectionButton.TabIndex = 5;
            this.clearSelectionButton.Text = "Clear Selection";
            this.clearSelectionButton.UseVisualStyleBackColor = true;
            this.clearSelectionButton.Click += new System.EventHandler(this.clearSelectionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(465, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Double click on an item for ingredients & cooking instructions!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearSelectionButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editFinishButton);
            this.Controls.Add(this.editBeginButton);
            this.Controls.Add(this.recipeListView);
            this.Controls.Add(this.addNewRecipeGroupBox);
            this.Name = "MainForm";
            this.Text = "Apu recipe book";
            this.addNewRecipeGroupBox.ResumeLayout(false);
            this.addNewRecipeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox addNewRecipeGroupBox;
        private System.Windows.Forms.Button addRecipeButton;
        private System.Windows.Forms.TextBox instructionsInputTextBox;
        private System.Windows.Forms.Button addIngredientsButton;
        private System.Windows.Forms.ComboBox foodCategoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameOfRecipeLabel;
        private System.Windows.Forms.ListView recipeListView;
        private System.Windows.Forms.ColumnHeader categoryCol;
        private System.Windows.Forms.ColumnHeader noOfIngredientsCol;
        private System.Windows.Forms.Button editBeginButton;
        private System.Windows.Forms.Button editFinishButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearSelectionButton;
        private System.Windows.Forms.Label label1;
    }
}

