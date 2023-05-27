namespace the_fan_s_guide.Forms
{
    partial class EditForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.recordsmanLabel = new System.Windows.Forms.Label();
            this.persRecordLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.sportLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.nationalityLabel = new System.Windows.Forms.Label();
            this.citizenshipLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.RecordsmanTextBox = new System.Windows.Forms.TextBox();
            this.PersRecordTextBox = new System.Windows.Forms.TextBox();
            this.TeamTextBox = new System.Windows.Forms.TextBox();
            this.SportTextBox = new System.Windows.Forms.TextBox();
            this.NationalityTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.CitizenshipTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.addformGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addformGroupBox
            // 
            this.addformGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addformGroupBox.Controls.Add(this.cancelButton);
            this.addformGroupBox.Controls.Add(this.okButton);
            this.addformGroupBox.Controls.Add(this.recordsmanLabel);
            this.addformGroupBox.Controls.Add(this.persRecordLabel);
            this.addformGroupBox.Controls.Add(this.teamLabel);
            this.addformGroupBox.Controls.Add(this.sportLabel);
            this.addformGroupBox.Controls.Add(this.heightLabel);
            this.addformGroupBox.Controls.Add(this.nationalityLabel);
            this.addformGroupBox.Controls.Add(this.citizenshipLabel);
            this.addformGroupBox.Controls.Add(this.nameLabel);
            this.addformGroupBox.Controls.Add(this.RecordsmanTextBox);
            this.addformGroupBox.Controls.Add(this.PersRecordTextBox);
            this.addformGroupBox.Controls.Add(this.TeamTextBox);
            this.addformGroupBox.Controls.Add(this.SportTextBox);
            this.addformGroupBox.Controls.Add(this.NationalityTextBox);
            this.addformGroupBox.Controls.Add(this.HeightTextBox);
            this.addformGroupBox.Controls.Add(this.CitizenshipTextBox);
            this.addformGroupBox.Controls.Add(this.NameTextBox);
            this.addformGroupBox.Location = new System.Drawing.Point(12, 1);
            this.addformGroupBox.Name = "addformGroupBox";
            this.addformGroupBox.Size = new System.Drawing.Size(776, 437);
            this.addformGroupBox.TabIndex = 1;
            this.addformGroupBox.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(474, 391);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(600, 391);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 29);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // recordsmanLabel
            // 
            this.recordsmanLabel.AutoSize = true;
            this.recordsmanLabel.Location = new System.Drawing.Point(41, 349);
            this.recordsmanLabel.Name = "recordsmanLabel";
            this.recordsmanLabel.Size = new System.Drawing.Size(165, 20);
            this.recordsmanLabel.TabIndex = 16;
            this.recordsmanLabel.Text = "Recordsman (yes or no)";
            // 
            // persRecordLabel
            // 
            this.persRecordLabel.AutoSize = true;
            this.persRecordLabel.Location = new System.Drawing.Point(95, 302);
            this.persRecordLabel.Name = "persRecordLabel";
            this.persRecordLabel.Size = new System.Drawing.Size(111, 20);
            this.persRecordLabel.TabIndex = 15;
            this.persRecordLabel.Text = "Personal record";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(161, 260);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(45, 20);
            this.teamLabel.TabIndex = 14;
            this.teamLabel.Text = "Team";
            // 
            // sportLabel
            // 
            this.sportLabel.AutoSize = true;
            this.sportLabel.Location = new System.Drawing.Point(111, 218);
            this.sportLabel.Name = "sportLabel";
            this.sportLabel.Size = new System.Drawing.Size(95, 20);
            this.sportLabel.TabIndex = 13;
            this.sportLabel.Text = "Kind of sport";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(125, 172);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(81, 20);
            this.heightLabel.TabIndex = 12;
            this.heightLabel.Text = "Height (m)";
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Location = new System.Drawing.Point(124, 130);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(82, 20);
            this.nationalityLabel.TabIndex = 11;
            this.nationalityLabel.Text = "Nationality";
            // 
            // citizenshipLabel
            // 
            this.citizenshipLabel.AutoSize = true;
            this.citizenshipLabel.Location = new System.Drawing.Point(125, 88);
            this.citizenshipLabel.Name = "citizenshipLabel";
            this.citizenshipLabel.Size = new System.Drawing.Size(81, 20);
            this.citizenshipLabel.TabIndex = 10;
            this.citizenshipLabel.Text = "Citizenship";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(157, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            // 
            // RecordsmanTextBox
            // 
            this.RecordsmanTextBox.Location = new System.Drawing.Point(238, 342);
            this.RecordsmanTextBox.Name = "RecordsmanTextBox";
            this.RecordsmanTextBox.Size = new System.Drawing.Size(456, 27);
            this.RecordsmanTextBox.TabIndex = 7;
            // 
            // PersRecordTextBox
            // 
            this.PersRecordTextBox.Location = new System.Drawing.Point(238, 295);
            this.PersRecordTextBox.Name = "PersRecordTextBox";
            this.PersRecordTextBox.Size = new System.Drawing.Size(456, 27);
            this.PersRecordTextBox.TabIndex = 6;
            // 
            // TeamTextBox
            // 
            this.TeamTextBox.Location = new System.Drawing.Point(238, 253);
            this.TeamTextBox.Name = "TeamTextBox";
            this.TeamTextBox.Size = new System.Drawing.Size(456, 27);
            this.TeamTextBox.TabIndex = 5;
            // 
            // SportTextBox
            // 
            this.SportTextBox.Location = new System.Drawing.Point(238, 211);
            this.SportTextBox.Name = "SportTextBox";
            this.SportTextBox.Size = new System.Drawing.Size(456, 27);
            this.SportTextBox.TabIndex = 4;
            // 
            // NationalityTextBox
            // 
            this.NationalityTextBox.Location = new System.Drawing.Point(238, 123);
            this.NationalityTextBox.Name = "NationalityTextBox";
            this.NationalityTextBox.Size = new System.Drawing.Size(456, 27);
            this.NationalityTextBox.TabIndex = 2;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(238, 165);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(456, 27);
            this.HeightTextBox.TabIndex = 3;
            // 
            // CitizenshipTextBox
            // 
            this.CitizenshipTextBox.Location = new System.Drawing.Point(238, 81);
            this.CitizenshipTextBox.Name = "CitizenshipTextBox";
            this.CitizenshipTextBox.Size = new System.Drawing.Size(456, 27);
            this.CitizenshipTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(238, 36);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(456, 27);
            this.NameTextBox.TabIndex = 0;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addformGroupBox);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.addformGroupBox.ResumeLayout(false);
            this.addformGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox addformGroupBox;
        private Button cancelButton;
        private Button okButton;
        private Label recordsmanLabel;
        private Label persRecordLabel;
        private Label teamLabel;
        private Label sportLabel;
        private Label heightLabel;
        private Label nationalityLabel;
        private Label citizenshipLabel;
        private Label nameLabel;
        private TextBox RecordsmanTextBox;
        private TextBox PersRecordTextBox;
        private TextBox TeamTextBox;
        private TextBox SportTextBox;
        private TextBox NationalityTextBox;
        private TextBox HeightTextBox;
        private TextBox CitizenshipTextBox;
        private TextBox NameTextBox;
    }
}