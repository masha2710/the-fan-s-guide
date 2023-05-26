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
            Sportsman = new Sportsman()
            {
                Name = addNameTextBox.Text,
                Citizenship = addCitizenshipTextBox.Text,
                Nationality = addNationalityTextBox.Text,
                Height = addHeightTextBox.Text,
                Sport = addHeightTextBox.Text,
                Team = addTeamTextBox.Text,
                PersonalRecord = addPersRecordTextBox.Text,
                Recordsman = addRecordsmanTextBox.Text,
            };
            this.DialogResult= DialogResult.OK;
        }
    }
}
