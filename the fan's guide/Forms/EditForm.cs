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
            lastNameTextBox.Text = sportsman.LastName;
            citizenshipTextBox.Text = sportsman.Citizenship;
            nationalityTextBox.Text = sportsman.Nationality;
            heightTextBox.Text = sportsman.Height.ToString();
            sportTextBox.Text = sportsman.Sport;
            teamTextBox.Text = sportsman.Team;
            persRecordTextBox.Text = sportsman.PersonalRecord;
            recordsmanTextBox.Text = sportsman.Recordsman;
        }

        private void okButton_Click_1(object sender, EventArgs e)
        {
            string problemMessage = FieldsValidation.GetProblemMessage(firstNameTextBox.Text, lastNameTextBox.Text,
                citizenshipTextBox.Text, nationalityTextBox.Text, heightTextBox.Text, sportTextBox.Text,teamTextBox.Text,
                persRecordTextBox.Text, recordsmanTextBox.Text);
            if (problemMessage != "")
            {
                MessageBox.Show(problemMessage, "Problems:");
                return;
            }
            Sportsman.FirstName = firstNameTextBox.Text;
            Sportsman.LastName = lastNameTextBox.Text;
            Sportsman.Citizenship = citizenshipTextBox.Text;
            Sportsman.Nationality = nationalityTextBox.Text;
            Sportsman.Height = Convert.ToInt32(heightTextBox.Text);
            Sportsman.Sport = sportTextBox.Text;
            Sportsman.Team = teamTextBox.Text;
            Sportsman.PersonalRecord = persRecordTextBox.Text;
            Sportsman.Recordsman = recordsmanTextBox.Text;
            var editRes = MessageBox.Show("Are you sure you want to edit information?", "Confirmation", 
                MessageBoxButtons.YesNo);
            if (editRes == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
            if (editRes == DialogResult.No)
            {
                return;
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
