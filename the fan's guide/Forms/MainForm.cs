using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using the_fan_s_guide.Data;
using the_fan_s_guide.Models;

namespace the_fan_s_guide.Forms
{
    public partial class MainForm : Form
    {
        SportBase sportbase; 
        public MainForm()
        {
            InitializeComponent();
            sportbase = new SportBase();
            //sportbase.TestData(100);
            sportsmanBindingSource.DataSource = sportbase.Sportsmen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataAccess.Load(sportbase);
            sportsmanBindingSource.ResetBindings(true);
            sportsmanBindingSource.DataSource = sportbase.Sportsmen;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveRes = MessageBox.Show("Do you want to save information?", "Confirmation", MessageBoxButtons.YesNo);
            if (saveRes == DialogResult.Yes)
            {
                DataAccess.Save(sportbase);
            }
            if(saveRes== DialogResult.No)
            {
                return;
            }
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Load(sportbase);
            sportsmanBindingSource.ResetBindings(true);
            sportsmanBindingSource.DataSource = sportbase.Sportsmen;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clearRes = MessageBox.Show("Are you sure you want to clear all information?", "Confirmation", MessageBoxButtons.YesNo);
           if(DialogResult.Yes == clearRes)
            {
                sportbase.Sportsmen.Clear();
                sportsmanBindingSource.ResetBindings(true);
                sportbase.Changed = true;
            }
           if(DialogResult== DialogResult.No)
            {
                return;
            }
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddForm(sportbase);
            var dialogResult = form.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                sportbase.Sportsmen.Add(form.Sportsman);
                sportsmanBindingSource.ResetBindings(true);
                sportbase.Changed = true;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = sportsmanGridView.CurrentRow;
            if (selectedRow == null)
            {
                return;
            }

            var selectedSportsman = selectedRow.DataBoundItem as Sportsman;

            if (selectedSportsman == null)
            {
                return;
            }

            var form = new EditForm(selectedSportsman);
            if(form.ShowDialog() == DialogResult.OK)
            {
                sportsmanBindingSource.ResetBindings(true);
                sportbase.Changed = true;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!sportbase.Changed)
            {
                return;
            }
            var result = MessageBox.Show("Do you want to save changes?", "Сonfirmation", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    DataAccess.Save(sportbase);
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            List<Sportsman> res = sportbase.SearchSportsmen(searchTextBox.Text); 
            sportsmanBindingSource.DataSource = res;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedSportsman = sportsmanBindingSource.Current as Sportsman;

            if (selectedSportsman == null)
            {
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete this sportsman?", "Сonfirmation", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    sportsmanBindingSource.Remove(selectedSportsman);
                    sportbase.Changed = true;
                    break;
                case DialogResult.No:
                    break;
            }
            sportbase.Changed = true;
        }

        private void recordsmanButton_Click(object sender, EventArgs e)
        {
            List<Sportsman> recordsmanRes = sportbase.SearchRecordsman(searchTextBox.Text);
            sportsmanBindingSource.DataSource = recordsmanRes;
        }
    }
}
