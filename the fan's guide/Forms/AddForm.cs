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
    public partial class AddForm : Form
    {
        public Sportsman Sportsman;
        SportBase _sportBase;
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(SportBase sportBase)
        {
            InitializeComponent();
            _sportBase = sportBase;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string problemMessage = FieldsValidation.GetProblemMessage(firstNameTextBox.Text, lastNameTextBox.Text,
                citizenshipTextBox.Text, nationalityTextBox.Text, heightTextBox.Text, sportTextBox.Text,teamTextBox.Text,
                persRecordTextBox.Text, recordsmanTextBox.Text);
            if (problemMessage != "")
            {
                MessageBox.Show(problemMessage, "Problems:");
                return;
            }
            Sportsman = new Sportsman()
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Citizenship = citizenshipTextBox.Text,
                Nationality = nationalityTextBox.Text,
                Height = Convert.ToInt32(heightTextBox.Text),
                Sport = sportTextBox.Text,
                Team = teamTextBox.Text,
                PersonalRecord = persRecordTextBox.Text,
                Recordsman = recordsmanTextBox.Text,
            };

            var addRes = MessageBox.Show("Are you sure you want to add this sportsman?", "Confirmation",
                MessageBoxButtons.YesNo);

            if (addRes == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }

            if (addRes== DialogResult.No)
            {
                return;
            }
        }

    }
}
