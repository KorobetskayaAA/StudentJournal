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
    public partial class FormGrade : Form
    {
        public Grade Grade { get; set; }
        public FormGrade()
        {
            InitializeComponent();

            GetTypes();
        }

        public FormGrade(Grade grade)
        {
            InitializeComponent();

            Grade = grade;
            GetTypes();
            textBoxDicipline.Text = Grade.Dicipline;
            numericUpDownSemestr.Value = Grade.Semestr;
            comboBoxType.SelectedIndex = (int)Grade.Type;
            comboBoxGrade.Text = Grade.Name;
        }
        void GetTypes()
        {
            comboBoxType.Items.Clear();
            comboBoxType.Items.AddRange(Enum.GetNames(typeof(GradeType)));
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Grade == null)
            {
                Grade = new Grade(textBoxDicipline.Text,
                    (int)numericUpDownSemestr.Value,
                    (GradeType)comboBoxType.SelectedIndex, 
                    comboBoxGrade.Text);
            }
            else
            {
                Grade.Dicipline = textBoxDicipline.Text;
                Grade.Semestr = (int)numericUpDownSemestr.Value;
                Grade.Type = (GradeType)comboBoxType.SelectedIndex;
                Grade.Name = comboBoxGrade.Text;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGrade.Items.Clear();
            comboBoxGrade.Items.AddRange(
                Grade.GetGradeNames(
                    (GradeType)comboBoxType.SelectedIndex
                )
            );
        }
    }
}
