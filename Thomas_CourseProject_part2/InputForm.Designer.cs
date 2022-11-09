namespace Thomas_CourseProject_part2
{
    partial class InputForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.HireDateTextBox = new System.Windows.Forms.TextBox();
            this.HireDateLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BenefitsGroupBox = new System.Windows.Forms.GroupBox();
            this.VacationTextBox = new System.Windows.Forms.TextBox();
            this.VacationLabel = new System.Windows.Forms.Label();
            this.LifeInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.LifeInsuranceLabel = new System.Windows.Forms.Label();
            this.HealthInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.HealthInsuranceLabel = new System.Windows.Forms.Label();
            this.HourlyRadioButton = new System.Windows.Forms.RadioButton();
            this.SalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.Pay1TextBox = new System.Windows.Forms.TextBox();
            this.Pay1Label = new System.Windows.Forms.Label();
            this.Pay2TextBox = new System.Windows.Forms.TextBox();
            this.Pay2Label = new System.Windows.Forms.Label();
            this.BenefitsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(115, 74);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(112, 25);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name:";
            this.FirstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(267, 71);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(237, 30);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(267, 107);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(237, 30);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(115, 110);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(112, 25);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Location = new System.Drawing.Point(267, 143);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(237, 30);
            this.SSNTextBox.TabIndex = 4;
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Location = new System.Drawing.Point(115, 146);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(60, 25);
            this.SSNLabel.TabIndex = 4;
            this.SSNLabel.Text = "SSN:";
            // 
            // HireDateTextBox
            // 
            this.HireDateTextBox.Location = new System.Drawing.Point(267, 179);
            this.HireDateTextBox.Name = "HireDateTextBox";
            this.HireDateTextBox.Size = new System.Drawing.Size(237, 30);
            this.HireDateTextBox.TabIndex = 5;
            // 
            // HireDateLabel
            // 
            this.HireDateLabel.AutoSize = true;
            this.HireDateLabel.Location = new System.Drawing.Point(115, 182);
            this.HireDateLabel.Name = "HireDateLabel";
            this.HireDateLabel.Size = new System.Drawing.Size(99, 25);
            this.HireDateLabel.TabIndex = 6;
            this.HireDateLabel.Text = "Hire Date:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(159, 498);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(129, 66);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(331, 498);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(129, 66);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BenefitsGroupBox
            // 
            this.BenefitsGroupBox.Controls.Add(this.VacationTextBox);
            this.BenefitsGroupBox.Controls.Add(this.VacationLabel);
            this.BenefitsGroupBox.Controls.Add(this.LifeInsuranceTextBox);
            this.BenefitsGroupBox.Controls.Add(this.LifeInsuranceLabel);
            this.BenefitsGroupBox.Controls.Add(this.HealthInsuranceTextBox);
            this.BenefitsGroupBox.Controls.Add(this.HealthInsuranceLabel);
            this.BenefitsGroupBox.Location = new System.Drawing.Point(68, 298);
            this.BenefitsGroupBox.Name = "BenefitsGroupBox";
            this.BenefitsGroupBox.Size = new System.Drawing.Size(483, 180);
            this.BenefitsGroupBox.TabIndex = 8;
            this.BenefitsGroupBox.TabStop = false;
            this.BenefitsGroupBox.Text = "Benefits";
            // 
            // VacationTextBox
            // 
            this.VacationTextBox.Location = new System.Drawing.Point(197, 116);
            this.VacationTextBox.Name = "VacationTextBox";
            this.VacationTextBox.Size = new System.Drawing.Size(237, 30);
            this.VacationTextBox.TabIndex = 2;
            // 
            // VacationLabel
            // 
            this.VacationLabel.AutoSize = true;
            this.VacationLabel.Location = new System.Drawing.Point(26, 119);
            this.VacationLabel.Name = "VacationLabel";
            this.VacationLabel.Size = new System.Drawing.Size(145, 25);
            this.VacationLabel.TabIndex = 6;
            this.VacationLabel.Text = "Vacation Days:";
            // 
            // LifeInsuranceTextBox
            // 
            this.LifeInsuranceTextBox.Location = new System.Drawing.Point(197, 80);
            this.LifeInsuranceTextBox.Name = "LifeInsuranceTextBox";
            this.LifeInsuranceTextBox.Size = new System.Drawing.Size(237, 30);
            this.LifeInsuranceTextBox.TabIndex = 1;
            // 
            // LifeInsuranceLabel
            // 
            this.LifeInsuranceLabel.AutoSize = true;
            this.LifeInsuranceLabel.Location = new System.Drawing.Point(26, 83);
            this.LifeInsuranceLabel.Name = "LifeInsuranceLabel";
            this.LifeInsuranceLabel.Size = new System.Drawing.Size(140, 25);
            this.LifeInsuranceLabel.TabIndex = 4;
            this.LifeInsuranceLabel.Text = "Life Insurance:";
            // 
            // HealthInsuranceTextBox
            // 
            this.HealthInsuranceTextBox.Location = new System.Drawing.Point(197, 44);
            this.HealthInsuranceTextBox.Name = "HealthInsuranceTextBox";
            this.HealthInsuranceTextBox.Size = new System.Drawing.Size(237, 30);
            this.HealthInsuranceTextBox.TabIndex = 0;
            // 
            // HealthInsuranceLabel
            // 
            this.HealthInsuranceLabel.AutoSize = true;
            this.HealthInsuranceLabel.Location = new System.Drawing.Point(26, 47);
            this.HealthInsuranceLabel.Name = "HealthInsuranceLabel";
            this.HealthInsuranceLabel.Size = new System.Drawing.Size(165, 25);
            this.HealthInsuranceLabel.TabIndex = 2;
            this.HealthInsuranceLabel.Text = "Health Insurance:";
            // 
            // HourlyRadioButton
            // 
            this.HourlyRadioButton.AutoSize = true;
            this.HourlyRadioButton.Checked = true;
            this.HourlyRadioButton.Location = new System.Drawing.Point(120, 27);
            this.HourlyRadioButton.Name = "HourlyRadioButton";
            this.HourlyRadioButton.Size = new System.Drawing.Size(89, 29);
            this.HourlyRadioButton.TabIndex = 0;
            this.HourlyRadioButton.TabStop = true;
            this.HourlyRadioButton.Text = "Hourly";
            this.HourlyRadioButton.UseVisualStyleBackColor = true;
            this.HourlyRadioButton.CheckedChanged += new System.EventHandler(this.HourlyRadioButton_CheckedChanged);
            // 
            // SalaryRadioButton
            // 
            this.SalaryRadioButton.AutoSize = true;
            this.SalaryRadioButton.Location = new System.Drawing.Point(251, 27);
            this.SalaryRadioButton.Name = "SalaryRadioButton";
            this.SalaryRadioButton.Size = new System.Drawing.Size(89, 29);
            this.SalaryRadioButton.TabIndex = 1;
            this.SalaryRadioButton.Text = "Salary";
            this.SalaryRadioButton.UseVisualStyleBackColor = true;
            this.SalaryRadioButton.CheckedChanged += new System.EventHandler(this.SalaryRadioButton_CheckedChanged);
            // 
            // Pay1TextBox
            // 
            this.Pay1TextBox.Location = new System.Drawing.Point(267, 215);
            this.Pay1TextBox.Name = "Pay1TextBox";
            this.Pay1TextBox.Size = new System.Drawing.Size(237, 30);
            this.Pay1TextBox.TabIndex = 6;
            // 
            // Pay1Label
            // 
            this.Pay1Label.AutoSize = true;
            this.Pay1Label.Location = new System.Drawing.Point(115, 218);
            this.Pay1Label.Name = "Pay1Label";
            this.Pay1Label.Size = new System.Drawing.Size(119, 25);
            this.Pay1Label.TabIndex = 13;
            this.Pay1Label.Text = "Hourly Rate:";
            // 
            // Pay2TextBox
            // 
            this.Pay2TextBox.Location = new System.Drawing.Point(267, 251);
            this.Pay2TextBox.Name = "Pay2TextBox";
            this.Pay2TextBox.Size = new System.Drawing.Size(237, 30);
            this.Pay2TextBox.TabIndex = 7;
            // 
            // Pay2Label
            // 
            this.Pay2Label.AutoSize = true;
            this.Pay2Label.Location = new System.Drawing.Point(115, 254);
            this.Pay2Label.Name = "Pay2Label";
            this.Pay2Label.Size = new System.Drawing.Size(144, 25);
            this.Pay2Label.TabIndex = 15;
            this.Pay2Label.Text = "Hours Worked:";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 602);
            this.Controls.Add(this.Pay2TextBox);
            this.Controls.Add(this.Pay2Label);
            this.Controls.Add(this.Pay1TextBox);
            this.Controls.Add(this.Pay1Label);
            this.Controls.Add(this.SalaryRadioButton);
            this.Controls.Add(this.HourlyRadioButton);
            this.Controls.Add(this.BenefitsGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.HireDateTextBox);
            this.Controls.Add(this.HireDateLabel);
            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.SSNLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InputForm";
            this.Text = "Employee Input Form";
            this.BenefitsGroupBox.ResumeLayout(false);
            this.BenefitsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.Label HireDateLabel;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox LastNameTextBox;
        public System.Windows.Forms.TextBox SSNTextBox;
        public System.Windows.Forms.TextBox HireDateTextBox;
        private System.Windows.Forms.GroupBox BenefitsGroupBox;
        public System.Windows.Forms.TextBox VacationTextBox;
        private System.Windows.Forms.Label VacationLabel;
        public System.Windows.Forms.TextBox LifeInsuranceTextBox;
        private System.Windows.Forms.Label LifeInsuranceLabel;
        public System.Windows.Forms.TextBox HealthInsuranceTextBox;
        private System.Windows.Forms.Label HealthInsuranceLabel;
        public System.Windows.Forms.Button SubmitButton;
        public System.Windows.Forms.TextBox Pay1TextBox;
        private System.Windows.Forms.Label Pay1Label;
        public System.Windows.Forms.TextBox Pay2TextBox;
        private System.Windows.Forms.Label Pay2Label;
        public System.Windows.Forms.RadioButton HourlyRadioButton;
        public System.Windows.Forms.RadioButton SalaryRadioButton;
    }
}