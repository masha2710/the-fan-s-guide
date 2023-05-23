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
            this.sportsmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsmanGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalRecordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportsmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsmanGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sportsmenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 28);
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
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // sportsmenToolStripMenuItem
            // 
            this.sportsmenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.sportsmenToolStripMenuItem.Name = "sportsmenToolStripMenuItem";
            this.sportsmenToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.sportsmenToolStripMenuItem.Text = "Sportsmen";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
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
            this.sportsmanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sportsmanGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.citizenshipDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.sportDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.personalRecordDataGridViewTextBoxColumn,
            this.recordsmanDataGridViewTextBoxColumn});
            this.sportsmanGridView.DataSource = this.sportsmanBindingSource;
            this.sportsmanGridView.Location = new System.Drawing.Point(12, 195);
            this.sportsmanGridView.Name = "sportsmanGridView";
            this.sportsmanGridView.ReadOnly = true;
            this.sportsmanGridView.RowHeadersWidth = 51;
            this.sportsmanGridView.RowTemplate.Height = 29;
            this.sportsmanGridView.Size = new System.Drawing.Size(792, 244);
            this.sportsmanGridView.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 451);
            this.Controls.Add(this.sportsmanGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportsmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsmanGridView)).EndInit();
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
        private DataGridView sportsmanGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn citizenshipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sportDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personalRecordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recordsmanDataGridViewTextBoxColumn;
    }
}