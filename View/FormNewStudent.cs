using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Students.Model;

namespace Students
{
    public partial class FormNewStudent : Form
    {
        List<Group> groups;
        public Student NewStudent { get; private set; }

        public FormNewStudent(List<Group> groups)
        {
            InitializeComponent();

            NewStudent = null;
            comboBoxGroup.Items.Clear();
            comboBoxGroup.Items.AddRange(groups.ToArray());

            pickerBirthDate.Value = DateTime.Today.AddYears(-18);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (radioButtonBudget.Checked)
            {
                NewStudent = new StudentBudget();
            }
            else
            {
                NewStudent = new StudentCommercial();
            }

            NewStudent.Name = textBoxFirstName.Text;
            NewStudent.Patronymic = textBoxPatronymic.Text;
            NewStudent.Surname = textBoxLastName.Text;
            NewStudent.BirthDate = pickerBirthDate.Value;

            NewStudent.Studbilet = textBoxStudBilet.Text;
            NewStudent.Group = groups[comboBoxGroup.SelectedIndex];

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
