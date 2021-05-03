namespace Assignment3
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.unitGroupBox = new System.Windows.Forms.GroupBox();
            this.imperialRadioButton = new System.Windows.Forms.RadioButton();
            this.metricRadioButton = new System.Windows.Forms.RadioButton();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.normalWeightLabel = new System.Windows.Forms.Label();
            this.weightCategoryTextBox = new System.Windows.Forms.TextBox();
            this.weightCategoryLabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.BMILabel = new System.Windows.Forms.Label();
            this.heightTextBoxInches = new System.Windows.Forms.TextBox();
            this.fuelGroupBox = new System.Windows.Forms.GroupBox();
            this.fuelResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.costKmTextBox = new System.Windows.Forms.TextBox();
            this.literSweMilFCTextBox = new System.Windows.Forms.TextBox();
            this.literMetricMileFCTextBox = new System.Windows.Forms.TextBox();
            this.literKmFCTextBox = new System.Windows.Forms.TextBox();
            this.kmLiterFCTextBox = new System.Windows.Forms.TextBox();
            this.costKmLabel = new System.Windows.Forms.Label();
            this.literSweMilFCLabel = new System.Windows.Forms.Label();
            this.literMetricMileFCLabel = new System.Windows.Forms.Label();
            this.literKmFCLabel = new System.Windows.Forms.Label();
            this.kmLiterFCLabel = new System.Windows.Forms.Label();
            this.calculateFuelButton = new System.Windows.Forms.Button();
            this.literPriceTextBox = new System.Windows.Forms.TextBox();
            this.fuelTankedTextBox = new System.Windows.Forms.TextBox();
            this.previousOdometerTextBox = new System.Windows.Forms.TextBox();
            this.currentOdometerTextBox = new System.Windows.Forms.TextBox();
            this.literPriceLabel = new System.Windows.Forms.Label();
            this.fuelTankedLabel = new System.Windows.Forms.Label();
            this.previousOdometerLabel = new System.Windows.Forms.Label();
            this.currentOdometerLabel = new System.Windows.Forms.Label();
            this.BMRGroupBox = new System.Windows.Forms.GroupBox();
            this.activityLevelGroupBox = new System.Windows.Forms.GroupBox();
            this.extraActiveRadioButton = new System.Windows.Forms.RadioButton();
            this.veryActiveRadioButton = new System.Windows.Forms.RadioButton();
            this.moderatelyActiveRadioButton = new System.Windows.Forms.RadioButton();
            this.lightlyActiveRadioButton = new System.Windows.Forms.RadioButton();
            this.sedentaryRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateBMRButton = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.BMRResultsTextBox = new System.Windows.Forms.TextBox();
            this.unitGroupBox.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.fuelGroupBox.SuspendLayout();
            this.fuelResultsGroupBox.SuspendLayout();
            this.BMRGroupBox.SuspendLayout();
            this.activityLevelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(79, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Your Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(153, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(118, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(22, 62);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(81, 17);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height (cm)";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(153, 58);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(56, 22);
            this.heightTextBox.TabIndex = 3;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(22, 93);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(81, 17);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "Weight (kg)";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(153, 89);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(56, 22);
            this.weightTextBox.TabIndex = 6;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Location = new System.Drawing.Point(141, 121);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(130, 49);
            this.CalculateBMIButton.TabIndex = 7;
            this.CalculateBMIButton.Text = "Calculate";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // unitGroupBox
            // 
            this.unitGroupBox.Controls.Add(this.imperialRadioButton);
            this.unitGroupBox.Controls.Add(this.metricRadioButton);
            this.unitGroupBox.Location = new System.Drawing.Point(292, 30);
            this.unitGroupBox.Name = "unitGroupBox";
            this.unitGroupBox.Size = new System.Drawing.Size(164, 100);
            this.unitGroupBox.TabIndex = 8;
            this.unitGroupBox.TabStop = false;
            this.unitGroupBox.Text = "Unit";
            // 
            // imperialRadioButton
            // 
            this.imperialRadioButton.AutoSize = true;
            this.imperialRadioButton.Location = new System.Drawing.Point(16, 57);
            this.imperialRadioButton.Name = "imperialRadioButton";
            this.imperialRadioButton.Size = new System.Drawing.Size(142, 21);
            this.imperialRadioButton.TabIndex = 1;
            this.imperialRadioButton.TabStop = true;
            this.imperialRadioButton.Text = "Imperial (foot, lbs)";
            this.imperialRadioButton.UseVisualStyleBackColor = true;
            this.imperialRadioButton.CheckedChanged += new System.EventHandler(this.imperialRadioButton_CheckedChanged);
            // 
            // metricRadioButton
            // 
            this.metricRadioButton.AutoSize = true;
            this.metricRadioButton.Location = new System.Drawing.Point(16, 30);
            this.metricRadioButton.Name = "metricRadioButton";
            this.metricRadioButton.Size = new System.Drawing.Size(122, 21);
            this.metricRadioButton.TabIndex = 0;
            this.metricRadioButton.TabStop = true;
            this.metricRadioButton.Text = "Metric (kg, cm)";
            this.metricRadioButton.UseVisualStyleBackColor = true;
            this.metricRadioButton.CheckedChanged += new System.EventHandler(this.metricRadioButton_CheckedChanged);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.normalWeightLabel);
            this.resultsGroupBox.Controls.Add(this.weightCategoryTextBox);
            this.resultsGroupBox.Controls.Add(this.weightCategoryLabel);
            this.resultsGroupBox.Controls.Add(this.BMITextBox);
            this.resultsGroupBox.Controls.Add(this.BMILabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(25, 201);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(425, 170);
            this.resultsGroupBox.TabIndex = 10;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results for ";
            // 
            // normalWeightLabel
            // 
            this.normalWeightLabel.AutoSize = true;
            this.normalWeightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.normalWeightLabel.Location = new System.Drawing.Point(51, 128);
            this.normalWeightLabel.Name = "normalWeightLabel";
            this.normalWeightLabel.Size = new System.Drawing.Size(0, 17);
            this.normalWeightLabel.TabIndex = 4;
            // 
            // weightCategoryTextBox
            // 
            this.weightCategoryTextBox.Location = new System.Drawing.Point(283, 81);
            this.weightCategoryTextBox.Name = "weightCategoryTextBox";
            this.weightCategoryTextBox.ReadOnly = true;
            this.weightCategoryTextBox.Size = new System.Drawing.Size(100, 22);
            this.weightCategoryTextBox.TabIndex = 3;
            // 
            // weightCategoryLabel
            // 
            this.weightCategoryLabel.AutoSize = true;
            this.weightCategoryLabel.Location = new System.Drawing.Point(13, 81);
            this.weightCategoryLabel.Name = "weightCategoryLabel";
            this.weightCategoryLabel.Size = new System.Drawing.Size(113, 17);
            this.weightCategoryLabel.TabIndex = 2;
            this.weightCategoryLabel.Text = "Weight Category";
            // 
            // BMITextBox
            // 
            this.BMITextBox.Location = new System.Drawing.Point(283, 45);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.ReadOnly = true;
            this.BMITextBox.Size = new System.Drawing.Size(100, 22);
            this.BMITextBox.TabIndex = 1;
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Location = new System.Drawing.Point(13, 45);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(65, 17);
            this.BMILabel.TabIndex = 0;
            this.BMILabel.Text = "Your BMI";
            // 
            // heightTextBoxInches
            // 
            this.heightTextBoxInches.Location = new System.Drawing.Point(215, 58);
            this.heightTextBoxInches.Name = "heightTextBoxInches";
            this.heightTextBoxInches.Size = new System.Drawing.Size(56, 22);
            this.heightTextBoxInches.TabIndex = 4;
            this.heightTextBoxInches.Visible = false;
            // 
            // fuelGroupBox
            // 
            this.fuelGroupBox.Controls.Add(this.fuelResultsGroupBox);
            this.fuelGroupBox.Controls.Add(this.calculateFuelButton);
            this.fuelGroupBox.Controls.Add(this.literPriceTextBox);
            this.fuelGroupBox.Controls.Add(this.fuelTankedTextBox);
            this.fuelGroupBox.Controls.Add(this.previousOdometerTextBox);
            this.fuelGroupBox.Controls.Add(this.currentOdometerTextBox);
            this.fuelGroupBox.Controls.Add(this.literPriceLabel);
            this.fuelGroupBox.Controls.Add(this.fuelTankedLabel);
            this.fuelGroupBox.Controls.Add(this.previousOdometerLabel);
            this.fuelGroupBox.Controls.Add(this.currentOdometerLabel);
            this.fuelGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fuelGroupBox.Location = new System.Drawing.Point(462, 12);
            this.fuelGroupBox.Name = "fuelGroupBox";
            this.fuelGroupBox.Size = new System.Drawing.Size(378, 412);
            this.fuelGroupBox.TabIndex = 11;
            this.fuelGroupBox.TabStop = false;
            this.fuelGroupBox.Text = "Fuel";
            // 
            // fuelResultsGroupBox
            // 
            this.fuelResultsGroupBox.Controls.Add(this.costKmTextBox);
            this.fuelResultsGroupBox.Controls.Add(this.literSweMilFCTextBox);
            this.fuelResultsGroupBox.Controls.Add(this.literMetricMileFCTextBox);
            this.fuelResultsGroupBox.Controls.Add(this.literKmFCTextBox);
            this.fuelResultsGroupBox.Controls.Add(this.kmLiterFCTextBox);
            this.fuelResultsGroupBox.Controls.Add(this.costKmLabel);
            this.fuelResultsGroupBox.Controls.Add(this.literSweMilFCLabel);
            this.fuelResultsGroupBox.Controls.Add(this.literMetricMileFCLabel);
            this.fuelResultsGroupBox.Controls.Add(this.literKmFCLabel);
            this.fuelResultsGroupBox.Controls.Add(this.kmLiterFCLabel);
            this.fuelResultsGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fuelResultsGroupBox.Location = new System.Drawing.Point(6, 201);
            this.fuelResultsGroupBox.Name = "fuelResultsGroupBox";
            this.fuelResultsGroupBox.Size = new System.Drawing.Size(366, 205);
            this.fuelResultsGroupBox.TabIndex = 9;
            this.fuelResultsGroupBox.TabStop = false;
            this.fuelResultsGroupBox.Text = "Results";
            // 
            // costKmTextBox
            // 
            this.costKmTextBox.Location = new System.Drawing.Point(260, 145);
            this.costKmTextBox.Name = "costKmTextBox";
            this.costKmTextBox.ReadOnly = true;
            this.costKmTextBox.Size = new System.Drawing.Size(100, 22);
            this.costKmTextBox.TabIndex = 9;
            // 
            // literSweMilFCTextBox
            // 
            this.literSweMilFCTextBox.Location = new System.Drawing.Point(260, 117);
            this.literSweMilFCTextBox.Name = "literSweMilFCTextBox";
            this.literSweMilFCTextBox.ReadOnly = true;
            this.literSweMilFCTextBox.Size = new System.Drawing.Size(100, 22);
            this.literSweMilFCTextBox.TabIndex = 8;
            // 
            // literMetricMileFCTextBox
            // 
            this.literMetricMileFCTextBox.Location = new System.Drawing.Point(260, 89);
            this.literMetricMileFCTextBox.Name = "literMetricMileFCTextBox";
            this.literMetricMileFCTextBox.ReadOnly = true;
            this.literMetricMileFCTextBox.Size = new System.Drawing.Size(100, 22);
            this.literMetricMileFCTextBox.TabIndex = 7;
            // 
            // literKmFCTextBox
            // 
            this.literKmFCTextBox.Location = new System.Drawing.Point(260, 61);
            this.literKmFCTextBox.Name = "literKmFCTextBox";
            this.literKmFCTextBox.ReadOnly = true;
            this.literKmFCTextBox.Size = new System.Drawing.Size(100, 22);
            this.literKmFCTextBox.TabIndex = 6;
            // 
            // kmLiterFCTextBox
            // 
            this.kmLiterFCTextBox.Location = new System.Drawing.Point(260, 33);
            this.kmLiterFCTextBox.Name = "kmLiterFCTextBox";
            this.kmLiterFCTextBox.ReadOnly = true;
            this.kmLiterFCTextBox.Size = new System.Drawing.Size(100, 22);
            this.kmLiterFCTextBox.TabIndex = 5;
            // 
            // costKmLabel
            // 
            this.costKmLabel.AutoSize = true;
            this.costKmLabel.Location = new System.Drawing.Point(19, 145);
            this.costKmLabel.Name = "costKmLabel";
            this.costKmLabel.Size = new System.Drawing.Size(122, 17);
            this.costKmLabel.TabIndex = 4;
            this.costKmLabel.Text = "Cost per kilometer";
            // 
            // literSweMilFCLabel
            // 
            this.literSweMilFCLabel.AutoSize = true;
            this.literSweMilFCLabel.Location = new System.Drawing.Point(19, 117);
            this.literSweMilFCLabel.Name = "literSweMilFCLabel";
            this.literSweMilFCLabel.Size = new System.Drawing.Size(196, 17);
            this.literSweMilFCLabel.TabIndex = 3;
            this.literSweMilFCLabel.Text = "Fuel Consumption (lit/Swe mil)";
            // 
            // literMetricMileFCLabel
            // 
            this.literMetricMileFCLabel.AutoSize = true;
            this.literMetricMileFCLabel.Location = new System.Drawing.Point(19, 89);
            this.literMetricMileFCLabel.Name = "literMetricMileFCLabel";
            this.literMetricMileFCLabel.Size = new System.Drawing.Size(216, 17);
            this.literMetricMileFCLabel.TabIndex = 2;
            this.literMetricMileFCLabel.Text = "Fuel Consumption (lit/metric mile)";
            // 
            // literKmFCLabel
            // 
            this.literKmFCLabel.AutoSize = true;
            this.literKmFCLabel.Location = new System.Drawing.Point(19, 61);
            this.literKmFCLabel.Name = "literKmFCLabel";
            this.literKmFCLabel.Size = new System.Drawing.Size(167, 17);
            this.literKmFCLabel.TabIndex = 1;
            this.literKmFCLabel.Text = "Fuel Consumption (lit/km)";
            // 
            // kmLiterFCLabel
            // 
            this.kmLiterFCLabel.AutoSize = true;
            this.kmLiterFCLabel.Location = new System.Drawing.Point(19, 33);
            this.kmLiterFCLabel.Name = "kmLiterFCLabel";
            this.kmLiterFCLabel.Size = new System.Drawing.Size(167, 17);
            this.kmLiterFCLabel.TabIndex = 0;
            this.kmLiterFCLabel.Text = "Fuel Consumption (km/lit)";
            // 
            // calculateFuelButton
            // 
            this.calculateFuelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateFuelButton.Location = new System.Drawing.Point(22, 135);
            this.calculateFuelButton.Name = "calculateFuelButton";
            this.calculateFuelButton.Size = new System.Drawing.Size(89, 34);
            this.calculateFuelButton.TabIndex = 8;
            this.calculateFuelButton.Text = "Calculate";
            this.calculateFuelButton.UseVisualStyleBackColor = true;
            this.calculateFuelButton.Click += new System.EventHandler(this.calculateFuelButton_Click);
            // 
            // literPriceTextBox
            // 
            this.literPriceTextBox.Location = new System.Drawing.Point(266, 109);
            this.literPriceTextBox.Name = "literPriceTextBox";
            this.literPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.literPriceTextBox.TabIndex = 7;
            // 
            // fuelTankedTextBox
            // 
            this.fuelTankedTextBox.Location = new System.Drawing.Point(266, 81);
            this.fuelTankedTextBox.Name = "fuelTankedTextBox";
            this.fuelTankedTextBox.Size = new System.Drawing.Size(100, 22);
            this.fuelTankedTextBox.TabIndex = 6;
            // 
            // previousOdometerTextBox
            // 
            this.previousOdometerTextBox.Location = new System.Drawing.Point(266, 53);
            this.previousOdometerTextBox.Name = "previousOdometerTextBox";
            this.previousOdometerTextBox.Size = new System.Drawing.Size(100, 22);
            this.previousOdometerTextBox.TabIndex = 5;
            // 
            // currentOdometerTextBox
            // 
            this.currentOdometerTextBox.Location = new System.Drawing.Point(266, 25);
            this.currentOdometerTextBox.Name = "currentOdometerTextBox";
            this.currentOdometerTextBox.Size = new System.Drawing.Size(100, 22);
            this.currentOdometerTextBox.TabIndex = 4;
            // 
            // literPriceLabel
            // 
            this.literPriceLabel.AutoSize = true;
            this.literPriceLabel.Location = new System.Drawing.Point(19, 109);
            this.literPriceLabel.Name = "literPriceLabel";
            this.literPriceLabel.Size = new System.Drawing.Size(92, 17);
            this.literPriceLabel.TabIndex = 3;
            this.literPriceLabel.Text = "Price per liter";
            // 
            // fuelTankedLabel
            // 
            this.fuelTankedLabel.AutoSize = true;
            this.fuelTankedLabel.Location = new System.Drawing.Point(19, 81);
            this.fuelTankedLabel.Name = "fuelTankedLabel";
            this.fuelTankedLabel.Size = new System.Drawing.Size(190, 17);
            this.fuelTankedLabel.TabIndex = 2;
            this.fuelTankedLabel.Text = "Amount of fuel tanked (liters)";
            // 
            // previousOdometerLabel
            // 
            this.previousOdometerLabel.AutoSize = true;
            this.previousOdometerLabel.Location = new System.Drawing.Point(19, 53);
            this.previousOdometerLabel.Name = "previousOdometerLabel";
            this.previousOdometerLabel.Size = new System.Drawing.Size(219, 17);
            this.previousOdometerLabel.TabIndex = 1;
            this.previousOdometerLabel.Text = "Previous Odometer Reading (km)";
            // 
            // currentOdometerLabel
            // 
            this.currentOdometerLabel.AutoSize = true;
            this.currentOdometerLabel.Location = new System.Drawing.Point(19, 25);
            this.currentOdometerLabel.Name = "currentOdometerLabel";
            this.currentOdometerLabel.Size = new System.Drawing.Size(211, 17);
            this.currentOdometerLabel.TabIndex = 0;
            this.currentOdometerLabel.Text = "Current Odometer Reading (km)";
            // 
            // BMRGroupBox
            // 
            this.BMRGroupBox.Controls.Add(this.BMRResultsTextBox);
            this.BMRGroupBox.Controls.Add(this.activityLevelGroupBox);
            this.BMRGroupBox.Controls.Add(this.calculateBMRButton);
            this.BMRGroupBox.Controls.Add(this.ageTextBox);
            this.BMRGroupBox.Controls.Add(this.ageLabel);
            this.BMRGroupBox.Controls.Add(this.maleRadioButton);
            this.BMRGroupBox.Controls.Add(this.femaleRadioButton);
            this.BMRGroupBox.Location = new System.Drawing.Point(12, 424);
            this.BMRGroupBox.Name = "BMRGroupBox";
            this.BMRGroupBox.Size = new System.Drawing.Size(828, 246);
            this.BMRGroupBox.TabIndex = 13;
            this.BMRGroupBox.TabStop = false;
            this.BMRGroupBox.Text = "BMR";
            // 
            // activityLevelGroupBox
            // 
            this.activityLevelGroupBox.Controls.Add(this.extraActiveRadioButton);
            this.activityLevelGroupBox.Controls.Add(this.veryActiveRadioButton);
            this.activityLevelGroupBox.Controls.Add(this.moderatelyActiveRadioButton);
            this.activityLevelGroupBox.Controls.Add(this.lightlyActiveRadioButton);
            this.activityLevelGroupBox.Controls.Add(this.sedentaryRadioButton);
            this.activityLevelGroupBox.Location = new System.Drawing.Point(6, 76);
            this.activityLevelGroupBox.Name = "activityLevelGroupBox";
            this.activityLevelGroupBox.Size = new System.Drawing.Size(347, 158);
            this.activityLevelGroupBox.TabIndex = 6;
            this.activityLevelGroupBox.TabStop = false;
            this.activityLevelGroupBox.Text = "Activity level per week";
            // 
            // extraActiveRadioButton
            // 
            this.extraActiveRadioButton.AutoSize = true;
            this.extraActiveRadioButton.Location = new System.Drawing.Point(3, 126);
            this.extraActiveRadioButton.Name = "extraActiveRadioButton";
            this.extraActiveRadioButton.Size = new System.Drawing.Size(243, 21);
            this.extraActiveRadioButton.TabIndex = 4;
            this.extraActiveRadioButton.TabStop = true;
            this.extraActiveRadioButton.Text = "Extra Active, hard exercises or job";
            this.extraActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // veryActiveRadioButton
            // 
            this.veryActiveRadioButton.AutoSize = true;
            this.veryActiveRadioButton.Location = new System.Drawing.Point(3, 99);
            this.veryActiveRadioButton.Name = "veryActiveRadioButton";
            this.veryActiveRadioButton.Size = new System.Drawing.Size(186, 21);
            this.veryActiveRadioButton.TabIndex = 3;
            this.veryActiveRadioButton.TabStop = true;
            this.veryActiveRadioButton.Text = "Very active (6 to 7 times)";
            this.veryActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // moderatelyActiveRadioButton
            // 
            this.moderatelyActiveRadioButton.AutoSize = true;
            this.moderatelyActiveRadioButton.Location = new System.Drawing.Point(3, 72);
            this.moderatelyActiveRadioButton.Name = "moderatelyActiveRadioButton";
            this.moderatelyActiveRadioButton.Size = new System.Drawing.Size(227, 21);
            this.moderatelyActiveRadioButton.TabIndex = 2;
            this.moderatelyActiveRadioButton.TabStop = true;
            this.moderatelyActiveRadioButton.Text = "Moderately active (3 to 5 times)";
            this.moderatelyActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // lightlyActiveRadioButton
            // 
            this.lightlyActiveRadioButton.AutoSize = true;
            this.lightlyActiveRadioButton.Location = new System.Drawing.Point(3, 45);
            this.lightlyActiveRadioButton.Name = "lightlyActiveRadioButton";
            this.lightlyActiveRadioButton.Size = new System.Drawing.Size(198, 21);
            this.lightlyActiveRadioButton.TabIndex = 1;
            this.lightlyActiveRadioButton.TabStop = true;
            this.lightlyActiveRadioButton.Text = "Lightly active (1 to 3 times)";
            this.lightlyActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // sedentaryRadioButton
            // 
            this.sedentaryRadioButton.AutoSize = true;
            this.sedentaryRadioButton.Location = new System.Drawing.Point(3, 18);
            this.sedentaryRadioButton.Name = "sedentaryRadioButton";
            this.sedentaryRadioButton.Size = new System.Drawing.Size(226, 21);
            this.sedentaryRadioButton.TabIndex = 0;
            this.sedentaryRadioButton.TabStop = true;
            this.sedentaryRadioButton.Text = "Sedentary (little or no exercise)";
            this.sedentaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculateBMRButton
            // 
            this.calculateBMRButton.Location = new System.Drawing.Point(251, 21);
            this.calculateBMRButton.Name = "calculateBMRButton";
            this.calculateBMRButton.Size = new System.Drawing.Size(102, 49);
            this.calculateBMRButton.TabIndex = 4;
            this.calculateBMRButton.Text = "Calculate";
            this.calculateBMRButton.UseVisualStyleBackColor = true;
            this.calculateBMRButton.Click += new System.EventHandler(this.calculateBMRButton_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(145, 48);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 22);
            this.ageTextBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(6, 51);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 17);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(145, 21);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.maleRadioButton.TabIndex = 1;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(6, 21);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.femaleRadioButton.TabIndex = 0;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // BMRResultsTextBox
            // 
            this.BMRResultsTextBox.Location = new System.Drawing.Point(360, 21);
            this.BMRResultsTextBox.Multiline = true;
            this.BMRResultsTextBox.Name = "BMRResultsTextBox";
            this.BMRResultsTextBox.ReadOnly = true;
            this.BMRResultsTextBox.Size = new System.Drawing.Size(468, 219);
            this.BMRResultsTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 676);
            this.Controls.Add(this.BMRGroupBox);
            this.Controls.Add(this.fuelGroupBox);
            this.Controls.Add(this.heightTextBoxInches);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.unitGroupBox);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Body-Mass Index (BMI)";
            this.unitGroupBox.ResumeLayout(false);
            this.unitGroupBox.PerformLayout();
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.fuelGroupBox.ResumeLayout(false);
            this.fuelGroupBox.PerformLayout();
            this.fuelResultsGroupBox.ResumeLayout(false);
            this.fuelResultsGroupBox.PerformLayout();
            this.BMRGroupBox.ResumeLayout(false);
            this.BMRGroupBox.PerformLayout();
            this.activityLevelGroupBox.ResumeLayout(false);
            this.activityLevelGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.GroupBox unitGroupBox;
        private System.Windows.Forms.RadioButton imperialRadioButton;
        private System.Windows.Forms.RadioButton metricRadioButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox weightCategoryTextBox;
        private System.Windows.Forms.Label weightCategoryLabel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Label normalWeightLabel;
        private System.Windows.Forms.TextBox heightTextBoxInches;
        private System.Windows.Forms.GroupBox fuelGroupBox;
        private System.Windows.Forms.GroupBox fuelResultsGroupBox;
        private System.Windows.Forms.Button calculateFuelButton;
        private System.Windows.Forms.TextBox literPriceTextBox;
        private System.Windows.Forms.TextBox fuelTankedTextBox;
        private System.Windows.Forms.TextBox previousOdometerTextBox;
        private System.Windows.Forms.TextBox currentOdometerTextBox;
        private System.Windows.Forms.Label literPriceLabel;
        private System.Windows.Forms.Label fuelTankedLabel;
        private System.Windows.Forms.Label previousOdometerLabel;
        private System.Windows.Forms.Label currentOdometerLabel;
        private System.Windows.Forms.TextBox costKmTextBox;
        private System.Windows.Forms.TextBox literSweMilFCTextBox;
        private System.Windows.Forms.TextBox literMetricMileFCTextBox;
        private System.Windows.Forms.TextBox literKmFCTextBox;
        private System.Windows.Forms.TextBox kmLiterFCTextBox;
        private System.Windows.Forms.Label costKmLabel;
        private System.Windows.Forms.Label literSweMilFCLabel;
        private System.Windows.Forms.Label literMetricMileFCLabel;
        private System.Windows.Forms.Label literKmFCLabel;
        private System.Windows.Forms.Label kmLiterFCLabel;
        private System.Windows.Forms.GroupBox BMRGroupBox;
        private System.Windows.Forms.GroupBox activityLevelGroupBox;
        private System.Windows.Forms.RadioButton extraActiveRadioButton;
        private System.Windows.Forms.RadioButton veryActiveRadioButton;
        private System.Windows.Forms.RadioButton moderatelyActiveRadioButton;
        private System.Windows.Forms.RadioButton lightlyActiveRadioButton;
        private System.Windows.Forms.RadioButton sedentaryRadioButton;
        private System.Windows.Forms.Button calculateBMRButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.TextBox BMRResultsTextBox;
    }
}

