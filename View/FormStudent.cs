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
    public partial class FormStudent : Form
    {
        Student student;
        Journal journal;

        public FormStudent(Student student, Journal journal)
        {
            InitializeComponent();
            this.student = student;
            this.Text = $"Студент {student.FIO}";

            this.journal = journal;

            comboBoxGroup.Items.Clear();
            comboBoxGroup.Items.AddRange(journal.Groups.ToArray());

            LoadStudentData();
        }

        void LoadStudentData()
        {
            if (student is StudentCommercial)
            {
                labelType.Text = "Обучается на коммерческой основе";
                buttonTransfer.Text = "Перевести на бюджет";

                labelStipend.Visible = false;
                textBoxStipend.Visible = false;

                labelPaymentDebt.Visible = true;
                textBoxPaymentDebt.Visible = true;
                textBoxPaymentDebt.Text = (student as StudentCommercial).PaymentDebt.ToString("## ##0,00 p.");
                buttonPay.Visible = true;
                maskedTextBoxPay.Visible = true;
            }
            else if (student is StudentBudget)
            {
                labelType.Text = "Обучается на бюджетной основе";
                buttonTransfer.Text = "Перевести на коммерцию";

                labelStipend.Visible = true;
                textBoxStipend.Visible = true;
                textBoxStipend.Text = (student as StudentBudget).Stipend.ToString("## ##0,00 p.");

                labelPaymentDebt.Visible = false;
                textBoxPaymentDebt.Visible = false;
                buttonPay.Visible = false;
                maskedTextBoxPay.Visible = false;
            }
            else
            {
                throw new InvalidCastException("Неверный тип студента");
            }

            textBoxSurname.Text = student.Surname;
            textBoxName.Text = student.Name;
            textBoxPatronymic.Text = student.Patronymic;
            dateTimePickerBirth.Value = student.BirthDate;
            textBoxStudbilet.Text = student.Studbilet;
            comboBoxGroup.SelectedItem = student.Group;

            listViewGrades.Groups.Clear();
            for (int i = 1; i <= 12; i++)
            {
                listViewGrades.Groups.Add(i.ToString(), "Семестр " + i);
            }
            UpdateGrades();
        }

        void UpdateGrades()
        {
            listViewGrades.Items.Clear();
            foreach (var grade in student.Grades)
            {
                var item = listViewGrades.Items.Add(grade.Dicipline);
                item.Group = listViewGrades.Groups[grade.Semestr.ToString()];
                item.SubItems.Add(grade.Semestr.ToString());
                item.SubItems.Add(grade.Type.ToString());
                item.SubItems.Add(grade.Name);
            }
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            student.Surname = textBoxSurname.Text;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            student.Name = textBoxName.Text;
        }

        private void textBoxPatronymic_TextChanged(object sender, EventArgs e)
        {
            student.Patronymic = textBoxPatronymic.Text;
        }

        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            student.BirthDate = dateTimePickerBirth.Value;
        }

        private void textBoxStudbilet_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            student.Studbilet = textBoxStudbilet.Text;
        }

        private void KeyPress_RusOnly(object sender, KeyPressEventArgs e)
        {
            char c = char.ToLower(e.KeyChar);
            if (char.IsControl(c))
            {
                return;
            }
            if (!(c >= 'а' && c <= 'я' || c == ' ' || c == '-'))
            {
                e.Handled = true;
            }
        }

        private void Validating_NonEmpty(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(sender as TextBox,
                    "Введите не пустое значение");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void AddGrade(object sender, EventArgs e)
        {
            var formGrade = new FormGrade();
            if (formGrade.ShowDialog() == DialogResult.OK)
            {
                student.Grades.Add(formGrade.Grade);
                UpdateGrades();
            }
        }

        private void EditGrade(object sender, EventArgs e)
        {
            var formGrade = new FormGrade(student.Grades[listViewGrades.FocusedItem.Index]);
            formGrade.ShowDialog();
            UpdateGrades();
        }

        private void DeleteGrade(object sender, EventArgs e)
        {
            if (listViewGrades.FocusedItem != null)
            {
                student.Grades.RemoveAt(listViewGrades.FocusedItem.Index);
                UpdateGrades();
            }
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            student.Group = comboBoxGroup.SelectedItem as Group;
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            if (student is StudentCommercial)
            {
                student = journal.MoveToBudget(student);
            }
            else if (student is StudentBudget)
            {
                student = journal.MoveToCommercial(student);
            }
            LoadStudentData();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (student is StudentCommercial)
            {
                if (decimal.TryParse(maskedTextBoxPay.Text, out decimal sum))
                {
                    (student as StudentCommercial).Pay(sum);
                }
            }
        }
    }
}
