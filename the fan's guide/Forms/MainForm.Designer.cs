namespace the_fan_s_guide.Forms
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportsmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportsmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsmanGridView = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.recordsmanButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportsmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsmanGridView)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sportsmenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sportsmenToolStripMenuItem
            // 
            this.sportsmenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.sportsmenToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sportsmenToolStripMenuItem.Name = "sportsmenToolStripMenuItem";
            this.sportsmenToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
            this.sportsmenToolStripMenuItem.Text = "Sportsmen";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sportsmanBindingSource
            // 
            this.sportsmanBindingSource.DataSource = typeof(the_fan_s_guide.Models.Sportsman);
            // 
            // sportsmanGridView
            // 
            this.sportsmanGridView.AllowUserToAddRows = false;
            this.sportsmanGridView.AllowUserToDeleteRows = false;
            this.sportsmanGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sportsmanGridView.AutoGenerateColumns = false;
            this.sportsmanGridView.BackgroundColor = System.Drawing.Color.White;
            this.sportsmanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sportsmanGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.citizenshipDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.sportDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.personalRecordDataGridViewTextBoxColumn,
            this.recordsmanDataGridViewTextBoxColumn});
            this.sportsmanGridView.DataSource = this.sportsmanBindingSource;
            this.sportsmanGridView.Location = new System.Drawing.Point(0, 183);
            this.sportsmanGridView.Name = "sportsmanGridView";
            this.sportsmanGridView.ReadOnly = true;
            this.sportsmanGridView.RowHeadersWidth = 51;
            this.sportsmanGridView.RowTemplate.Height = 29;
            this.sportsmanGridView.Size = new System.Drawing.Size(766, 223);
            this.sportsmanGridView.TabIndex = 2;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // citizenshipDataGridViewTextBoxColumn
            // 
            this.citizenshipDataGridViewTextBoxColumn.DataPropertyName = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.HeaderText = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.citizenshipDataGridViewTextBoxColumn.Name = "citizenshipDataGridViewTextBoxColumn";
            this.citizenshipDataGridViewTextBoxColumn.ReadOnly = true;
            this.citizenshipDataGridViewTextBoxColumn.Width = 125;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            this.nationalityDataGridViewTextBoxColumn.Width = 125;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            this.heightDataGridViewTextBoxColumn.Width = 125;
            // 
            // sportDataGridViewTextBoxColumn
            // 
            this.sportDataGridViewTextBoxColumn.DataPropertyName = "Sport";
            this.sportDataGridViewTextBoxColumn.HeaderText = "Sport";
            this.sportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sportDataGridViewTextBoxColumn.Name = "sportDataGridViewTextBoxColumn";
            this.sportDataGridViewTextBoxColumn.ReadOnly = true;
            this.sportDataGridViewTextBoxColumn.Width = 125;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Width = 125;
            // 
            // personalRecordDataGridViewTextBoxColumn
            // 
            this.personalRecordDataGridViewTextBoxColumn.DataPropertyName = "PersonalRecord";
            this.personalRecordDataGridViewTextBoxColumn.HeaderText = "PersonalRecord";
            this.personalRecordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personalRecordDataGridViewTextBoxColumn.Name = "personalRecordDataGridViewTextBoxColumn";
            this.personalRecordDataGridViewTextBoxColumn.ReadOnly = true;
            this.personalRecordDataGridViewTextBoxColumn.Width = 125;
            // 
            // recordsmanDataGridViewTextBoxColumn
            // 
            this.recordsmanDataGridViewTextBoxColumn.DataPropertyName = "Recordsman";
            this.recordsmanDataGridViewTextBoxColumn.HeaderText = "Recordsman";
            this.recordsmanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recordsmanDataGridViewTextBoxColumn.Name = "recordsmanDataGridViewTextBoxColumn";
            this.recordsmanDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordsmanDataGridViewTextBoxColumn.Width = 125;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGroupBox.Controls.Add(this.recordsmanButton);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchGroupBox.Location = new System.Drawing.Point(19, 43);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(727, 125);
            this.searchGroupBox.TabIndex = 3;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search ";
            // 
            // recordsmanButton
            // 
            this.recordsmanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(97)))));
            this.recordsmanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.recordsmanButton.ForeColor = System.Drawing.Color.Snow;
            this.recordsmanButton.Location = new System.Drawing.Point(94, 90);
            this.recordsmanButton.Name = "recordsmanButton";
            this.recordsmanButton.Size = new System.Drawing.Size(157, 29);
            this.recordsmanButton.TabIndex = 2;
            this.recordsmanButton.Text = "find recordsman";
            this.recordsmanButton.UseVisualStyleBackColor = false;
            this.recordsmanButton.Click += new System.EventHandler(this.recordsmanButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(77)))), ((int)(((byte)(97)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.ForeColor = System.Drawing.Color.Snow;
            this.searchButton.Location = new System.Drawing.Point(333, 90);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(141, 29);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(67, 42);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(446, 30);
            this.searchTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(766, 405);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.sportsmanGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1197, 670);
            this.MinimumSize = new System.Drawing.Size(579, 452);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportsmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsmanGridView)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private BindingSource sportsmanBindingSource;
        private DataGridViewTextBoxColumn isRecordsmanDataGridViewTextBoxColumn;
        private ToolStripMenuItem sportsmenToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private ToolStripMenuItem editToolStripMenuItem;
        private DataGridView sportsmanGridView;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn citizenshipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sportDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personalRecordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recordsmanDataGridViewTextBoxColumn;
        private GroupBox searchGroupBox;
        private TextBox searchTextBox;
        private Button searchButton;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button recordsmanButton;
    }
}