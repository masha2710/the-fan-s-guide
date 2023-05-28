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
            firstNameTextBox.Text = sportsman.FirstName;
            citizenshipTextBox.Text = sportsman.Citizenship;
            nationalityTextBox.Text = sportsman.Nationality;
            heightTextBox.Text = sportsman.Height;
            sportTextBox.Text = sportsman.Sport;
            teamTextBox.Text = sportsman.Team;
            persRecordTextBox.Text = sportsman.PersonalRecord;
            recordsmanTextBox.Text = sportsman.Recordsman;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string problemMessage = FieldsValidation.GetProblemMessage(firstNameTextBox.Text, lastNameTextBox.Text, citizenshipTextBox.Text, nationalityTextBox.Text, heightTextBox.Text, sportTextBox.Text, recordsmanTextBox.Text);
            if (problemMessage != "")
            {
                MessageBox.Show(problemMessage, "Problems:");
                return;
            }
            Sportsman.FirstName = firstNameTextBox.Text;
            Sportsman.LastName = lastNameTextBox.Text;
            Sportsman.Citizenship = citizenshipTextBox.Text;
            Sportsman.Nationality = nationalityTextBox.Text;
            Sportsman.Height = heightTextBox.Text;
            Sportsman.Sport = sportTextBox.Text;
            Sportsman.Team = teamTextBox.Text;
            Sportsman.PersonalRecord = persRecordTextBox.Text;
            Sportsman.Recordsman = recordsmanTextBox.Text;
            DialogResult= DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
