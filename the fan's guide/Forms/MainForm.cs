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
            sportbase.TestData(100);
            sportsmanBindingSource.DataSource = sportbase.Sportsmen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Save(sportbase);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Load(sportbase);
            sportsmanBindingSource.ResetBindings(true);
            sportsmanBindingSource.DataSource = sportbase.Sportsmen;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sportbase.Sportsmen.Clear();
            sportsmanBindingSource.ResetBindings(true);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddForm(sportbase);
            var dialogResult = form.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                sportbase.Sportsmen.Add(form.Sportsman);
                sportsmanBindingSource.ResetBindings(true);
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
            }

        }
    }
}
