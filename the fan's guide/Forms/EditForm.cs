using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using the_fan_s_guide.Models;

namespace the_fan_s_guide.Forms
{
    public partial class EditForm : Form
    {
        public Sportsman Sportsman;
        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(Sportsman sportsman)
        {
            InitializeComponent();
            Sportsman = sportsman;
            editNameTextBox.Text = sportsman.Name;
            editCitizenshipTextBox.Text = sportsman.Citizenship;
            editNationalityTextBox.Text = sportsman.Nationality;
            editHeightTextBox.Text = sportsman.Height;
            editSportTextBox.Text = sportsman.Sport;
            editTeamTextBox.Text = sportsman.Team;
            editPersRecordTextBox.Text = sportsman.PersonalRecord;
            editRecordsmanTextBox.Text = sportsman.Recordsman;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Sportsman.Name = editNameTextBox.Text;
            Sportsman.Citizenship = editCitizenshipTextBox.Text;
            Sportsman.Nationality = editNationalityTextBox.Text;
            Sportsman.Height = editHeightTextBox.Text;
            Sportsman.Sport = editHeightTextBox.Text;
            Sportsman.Team = editTeamTextBox.Text;
            Sportsman.PersonalRecord = editPersRecordTextBox.Text;
            Sportsman.Recordsman = editRecordsmanTextBox.Text;
            DialogResult= DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
