namespace Assignment4
{
    partial class FormIngredients
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
            this.numberOfIngredientsLabel = new System.Windows.Forms.Label();
            this.ingredientsCountLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.ingredientTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberOfIngredientsLabel
            // 
            this.numberOfIngredientsLabel.AutoSize = true;
            this.numberOfIngredientsLabel.Location = new System.Drawing.Point(9, 18);
            this.numberOfIngredientsLabel.Name = "numberOfIngredientsLabel";
            this.numberOfIngredientsLabel.Size = new System.Drawing.Size(148, 17);
            this.numberOfIngredientsLabel.TabIndex = 0;
            this.numberOfIngredientsLabel.Text = "Number of ingredients";
            // 
            // ingredientsCountLabel
            // 
            this.ingredientsCountLabel.AutoSize = true;
            this.ingredientsCountLabel.Location = new System.Drawing.Point(411, 18);
            this.ingredientsCountLabel.Name = "ingredientsCountLabel";
            this.ingredientsCountLabel.Size = new System.Drawing.Size(16, 17);
            this.ingredientsCountLabel.TabIndex = 1;
            this.ingredientsCountLabel.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.ingredientsListBox);
            this.groupBox1.Controls.Add(this.ingredientTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 326);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredient";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(326, 79);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(326, 50);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(326, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 16;
            this.ingredientsListBox.Location = new System.Drawing.Point(6, 49);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(314, 260);
            this.ingredientsListBox.TabIndex = 1;
            // 
            // ingredientTextBox
            // 
            this.ingredientTextBox.Location = new System.Drawing.Point(6, 21);
            this.ingredientTextBox.Name = "ingredientTextBox";
            this.ingredientTextBox.Size = new System.Drawing.Size(314, 22);
            this.ingredientTextBox.TabIndex = 0;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(168, 382);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(106, 23);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 417);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ingredientsCountLabel);
            this.Controls.Add(this.numberOfIngredientsLabel);
            this.Name = "FormIngredients";
            this.Text = "FormIngredients";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfIngredientsLabel;
        private System.Windows.Forms.Label ingredientsCountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox ingredientTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ListBox ingredientsListBox;
    }
}