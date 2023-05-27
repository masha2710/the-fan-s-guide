using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using the_fan_s_guide.Forms_Validation;
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
            NameTextBox.Text = sportsman.Name;
            CitizenshipTextBox.Text = sportsman.Citizenship;
            NationalityTextBox.Text = sportsman.Nationality;
            HeightTextBox.Text = sportsman.Height;
            SportTextBox.Text = sportsman.Sport;
            TeamTextBox.Text = sportsman.Team;
            PersRecordTextBox.Text = sportsman.PersonalRecord;
            RecordsmanTextBox.Text = sportsman.Recordsman;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string problemMessage = FieldsValidation.GetProblemMessage(NameTextBox.Text, CitizenshipTextBox.Text, NationalityTextBox.Text, HeightTextBox.Text, SportTextBox.Text, TeamTextBox.Text, PersRecordTextBox.Text, RecordsmanTextBox.Text);
            if (problemMessage != "")
            {
                MessageBox.Show(problemMessage, "Problems:");
                return;
            }
            Sportsman.Name = NameTextBox.Text;
            Sportsman.Citizenship = CitizenshipTextBox.Text;
            Sportsman.Nationality = NationalityTextBox.Text;
            Sportsman.Height = HeightTextBox.Text;
            Sportsman.Sport = SportTextBox.Text;
            Sportsman.Team = TeamTextBox.Text;
            Sportsman.PersonalRecord = PersRecordTextBox.Text;
            Sportsman.Recordsman = RecordsmanTextBox.Text;
            DialogResult= DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
