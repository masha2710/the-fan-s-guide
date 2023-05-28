namespace the_fan_s_guide.Forms
{
    partial class AddForm
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
            this.addformGroupBox = new System.Windows.Forms.GroupBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nationalityTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.recordsmanLabel = new System.Windows.Forms.Label();
            this.persRecordLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.sportLabel = new System.Windows.Forms.Label();
            this.nationalityLabel = new System.Windows.Forms.Label();
            this.citizenshipLabel = new System.Windows.Forms.Label();
            this.recordsmanTextBox = new System.Windows.Forms.TextBox();
            this.persRecordTextBox = new System.Windows.Forms.TextBox();
            this.teamTextBox = new System.Windows.Forms.TextBox();
            this.sportTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.citizenshipTextBox = new System.Windows.Forms.TextBox();
            this.addformGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addformGroupBox
            // 
            this.addformGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addformGroupBox.Controls.Add(this.lastNameLabel);
            this.addformGroupBox.Controls.Add(this.nationalityTextBox);
            this.addformGroupBox.Controls.Add(this.firstNameTextBox);
            this.addformGroupBox.Controls.Add(this.heightLabel);
            this.addformGroupBox.Controls.Add(this.firstNameLabel);
            this.addformGroupBox.Controls.Add(this.lastNameTextBox);
            this.addformGroupBox.Controls.Add(this.cancelButton);
            this.addformGroupBox.Controls.Add(this.okButton);
            this.addformGroupBox.Controls.Add(this.recordsmanLabel);
            this.addformGroupBox.Controls.Add(this.persRecordLabel);
            this.addformGroupBox.Controls.Add(this.teamLabel);
            this.addformGroupBox.Controls.Add(this.sportLabel);
            this.addformGroupBox.Controls.Add(this.nationalityLabel);
            this.addformGroupBox.Controls.Add(this.citizenshipLabel);
            this.addformGroupBox.Controls.Add(this.recordsmanTextBox);
            this.addformGroupBox.Controls.Add(this.persRecordTextBox);
            this.addformGroupBox.Controls.Add(this.teamTextBox);
            this.addformGroupBox.Controls.Add(this.sportTextBox);
            this.addformGroupBox.Controls.Add(this.heightTextBox);
            this.addformGroupBox.Controls.Add(this.citizenshipTextBox);
            this.addformGroupBox.Location = new System.Drawing.Point(12, 0);
            this.addformGroupBox.Name = "addformGroupBox";
            this.addformGroupBox.Size = new System.Drawing.Size(776, 438);
            this.addformGroupBox.TabIndex = 0;
            this.addformGroupBox.TabStop = false;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(138, 77);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 20);
            this.lastNameLabel.TabIndex = 21;
            this.lastNameLabel.Text = "Last name";
            // 
            // nationalityTextBox
            // 
            this.nationalityTextBox.Location = new System.Drawing.Point(238, 156);
            this.nationalityTextBox.Name = "nationalityTextBox";
            this.nationalityTextBox.Size = new System.Drawing.Size(456, 27);
            this.nationalityTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(238, 26);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(456, 27);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(131, 206);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(88, 20);
            this.heightLabel.TabIndex = 18;
            this.heightLabel.Text = "Height (cm)";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(138, 33);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(77, 20);
            this.firstNameLabel.TabIndex = 17;
            this.firstNameLabel.Text = "First name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(238, 70);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(456, 27);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(475, 409);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(600, 409);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 29);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // recordsmanLabel
            // 
            this.recordsmanLabel.AutoSize = true;
            this.recordsmanLabel.Location = new System.Drawing.Point(52, 377);
            this.recordsmanLabel.Name = "recordsmanLabel";
            this.recordsmanLabel.Size = new System.Drawing.Size(161, 20);
            this.recordsmanLabel.TabIndex = 16;
            this.recordsmanLabel.Text = "Recordsman(yes or no)";
            // 
            // persRecordLabel
            // 
            this.persRecordLabel.AutoSize = true;
            this.persRecordLabel.Location = new System.Drawing.Point(102, 332);
            this.persRecordLabel.Name = "persRecordLabel";
            this.persRecordLabel.Size = new System.Drawing.Size(111, 20);
            this.persRecordLabel.TabIndex = 15;
            this.persRecordLabel.Text = "Personal record";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(168, 290);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(45, 20);
            this.teamLabel.TabIndex = 14;
            this.teamLabel.Text = "Team";
            // 
            // sportLabel
            // 
            this.sportLabel.AutoSize = true;
            this.sportLabel.Location = new System.Drawing.Point(118, 248);
            this.sportLabel.Name = "sportLabel";
            this.sportLabel.Size = new System.Drawing.Size(95, 20);
            this.sportLabel.TabIndex = 13;
            this.sportLabel.Text = "Kind of sport";
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Location = new System.Drawing.Point(132, 163);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(82, 20);
            this.nationalityLabel.TabIndex = 11;
            this.nationalityLabel.Text = "Nationality";
            // 
            // citizenshipLabel
            // 
            this.citizenshipLabel.AutoSize = true;
            this.citizenshipLabel.Location = new System.Drawing.Point(132, 120);
            this.citizenshipLabel.Name = "citizenshipLabel";
            this.citizenshipLabel.Size = new System.Drawing.Size(81, 20);
            this.citizenshipLabel.TabIndex = 10;
            this.citizenshipLabel.Text = "Citizenship";
            // 
            // recordsmanTextBox
            // 
            this.recordsmanTextBox.Location = new System.Drawing.Point(238, 370);
            this.recordsmanTextBox.Name = "recordsmanTextBox";
            this.recordsmanTextBox.Size = new System.Drawing.Size(456, 27);
            this.recordsmanTextBox.TabIndex = 8;
            // 
            // persRecordTextBox
            // 
            this.persRecordTextBox.Location = new System.Drawing.Point(238, 325);
            this.persRecordTextBox.Name = "persRecordTextBox";
            this.persRecordTextBox.Size = new System.Drawing.Size(456, 27);
            this.persRecordTextBox.TabIndex = 7;
            // 
            // teamTextBox
            // 
            this.teamTextBox.Location = new System.Drawing.Point(238, 283);
            this.teamTextBox.Name = "teamTextBox";
            this.teamTextBox.Size = new System.Drawing.Size(456, 27);
            this.teamTextBox.TabIndex = 6;
            // 
            // sportTextBox
            // 
            this.sportTextBox.Location = new System.Drawing.Point(238, 241);
            this.sportTextBox.Name = "sportTextBox";
            this.sportTextBox.Size = new System.Drawing.Size(456, 27);
            this.sportTextBox.TabIndex = 5;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(238, 199);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(456, 27);
            this.heightTextBox.TabIndex = 4;
            // 
            // citizenshipTextBox
            // 
            this.citizenshipTextBox.Location = new System.Drawing.Point(238, 113);
            this.citizenshipTextBox.Name = "citizenshipTextBox";
            this.citizenshipTextBox.Size = new System.Drawing.Size(456, 27);
            this.citizenshipTextBox.TabIndex = 2;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addformGroupBox);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.addformGroupBox.ResumeLayout(false);
            this.addformGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox addformGroupBox;
        private TextBox citizenshipTextBox;
        private TextBox heightTextBox;
        private TextBox teamTextBox;
        private TextBox sportTextBox;
        private TextBox recordsmanTextBox;
        private TextBox persRecordTextBox;
        private Label citizenshipLabel;
        private Label nationalityLabel;
        private Label recordsmanLabel;
        private Label persRecordLabel;
        private Label teamLabel;
        private Label sportLabel;
        private Button cancelButton;
        private Button okButton;
        private TextBox lastNameTextBox;
        private Label firstNameLabel;
        private Label heightLabel;
        private TextBox firstNameTextBox;
        private TextBox nationalityTextBox;
        private Label lastNameLabel;
    }
}