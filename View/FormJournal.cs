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
    public partial class FormJournal : Form
    {
        const string fileName = "journal.xml";
        Journal journal;
        FormGroups formGroups;
        public FormJournal()
        {
            InitializeComponent();

            journal = FileHelper.LoadFromXml(fileName);

            //LoadTestData();

            dataGridViewJournal.DataSource = journal.Students;
            comboBoxGroup.DataSource = journal.Groups;
            formGroups = new FormGroups(journal.Groups);
        }

        private void LoadTestData()
        {
            journal.AddGroup(new Group(1, Group.EducationForms[0], "ПИЭЭ1"));
            journal.AddGroup(new Group(2, Group.EducationForms[1], "ПИЭЭ1"));
            journal.AddGroup(new Group(1, Group.EducationForms[1], "ПИЭЭ2"));
            // Тестовые примеры
            journal.AddStudent(new Student()
            {
                Studbilet = "18123456",
                Surname = "Иванов",
                Name = "Сергей",
                Patronymic = "Петрович",
                Group = journal.Groups[0]
            }
            );
            journal.Students[0].Grades.Add(
                new Grade("Математика", 1, GradeType.Экзамен, "хорошо")
            );
            journal.Students[0].Grades.Add(
                new Grade("БД", 2, GradeType.Зачет, "зачтено")
            );
            journal.AddStudent(new Student()
            {
                Studbilet = "18004398",
                Surname = "Канунников",
                Name = "Артем",
                Patronymic = "Валерьянович",
                Group = journal.Groups[0]
            }
            );
            journal.Students[1].Grades.Add(
                new Grade("Математика", 1, GradeType.Экзамен, "отлично")
            );
            journal.Students[1].Grades.Add(
                new Grade("БД", 2, GradeType.Зачет, "зачтено")
            );
            journal.AddStudent(new Student()
            {
                Studbilet = "17009999",
                Surname = "Петрова",
                Name = "Мария",
                Patronymic = "Георгиевна",
                Group = journal.Groups[1]
            }
            );
            /*
            journal.AddStudent(new Student() { Studbilet = "18004398", Surname = "Канунников", Name = "Артем", Patronymic = "Валерьянович", BirthDate = new DateTime(1999, 10, 7), Group = "1к ПИ(заочная)" });
            journal.AddStudent(new Student() { Studbilet = "18001893", Surname = "Дюков", Name = "Антип", Patronymic = "Афанасиевич", BirthDate = new DateTime(1999, 5, 22), Group = "1к ПИ(заочная)" });
            journal.AddStudent(new Student() { Studbilet = "18004997", Surname = "Васнецов-Белозерский", Name = "Максимильян", Patronymic = "Иннокентиевич", BirthDate = new DateTime(1960, 1, 1), Group = "1к ПИ(заочная)" });
            journal.AddStudent(new Student() { Studbilet = "18001255", Surname = "Степнов", Name = "Осип", Patronymic = "Платонович", BirthDate = new DateTime(1999, 8, 7), Group = "1к ПИ(очная)" });
            journal.AddStudent(new Student() { Studbilet = "18005666", Surname = "Михайлов", Name = "Карл", Patronymic = "Геннадиевич", BirthDate = new DateTime(1999, 12, 7), Group = "1к ПИ(очная)" });
            journal.AddStudent(new Student() { Studbilet = "18001382", Surname = "Веденеева", Name = "Берта", Patronymic = "Семеновна", BirthDate = new DateTime(1999, 12, 3), Group = "1к ПИ(очная)" });
            journal.AddStudent(new Student() { Studbilet = "18000111", Surname = "Баренцев", Name = "Герман", Patronymic = "Панкратиевич", BirthDate = new DateTime(2000, 5, 11), Group = "1к ПИ(очная)" });
            journal.AddStudent(new Student() { Studbilet = "18006367", Surname = "Парамонов", Name = "Семен", Patronymic = "Зиновиевич", BirthDate = new DateTime(2000, 3, 4), Group = "1к ПИ(очная)" });
            journal.AddStudent(new Student() { Studbilet = "18008569", Surname = "Левкович", Name = "Даниил", Patronymic = "Андриянович", BirthDate = new DateTime(2000, 6, 3), Group = "1к ПИ(очная)" });
            journal.AddStudent(new Student() { Studbilet = "18007168", Surname = "Панарина", Name = "Пелагея", Patronymic = "Давидовна", BirthDate = new DateTime(1999, 8, 15), Group = "1к ПИ(очная)" });
            journal.AddStudent(new Student() { Studbilet = "18002768", Surname = "Махнер", Name = "Ярослав", Patronymic = "Родионович", BirthDate = new DateTime(1999, 5, 12), Group = "1к ПИ(очная)" });
            journal.AddStudent(new Student() { Studbilet = "18005341", Surname = "Якшилов", Name = "Эрнест", Patronymic = "Михаилович", BirthDate = new DateTime(2000, 5, 25), Group = "1к ПИ(очная)" });
            */
        }

        private void FormJournal_Activated(object sender, EventArgs e)
        {
            UpdateDataSource();
        }
        void UpdateDataSource()
        {
            comboBoxGroup.DataSource = null;
            comboBoxGroup.DataSource = journal.Groups;

            UpdateDataSourceGridView();
            // Сохраняем каждое обновление.
            FileHelper.SaveToXml(fileName, journal);
        }

        void UpdateDataSourceGridView()
        {
            dataGridViewJournal.DataSource = null;
            if (comboBoxGroup.SelectedItem != null)
                dataGridViewJournal.DataSource = checkBoxRatio.Checked ?
                    (comboBoxGroup.SelectedItem as Group).Rating :
                    (comboBoxGroup.SelectedItem as Group).Alphabetical;
            else
                dataGridViewJournal.DataSource = journal.Students;
        }

        Student SelectedStudent
        {
            get => dataGridViewJournal.CurrentRow.DataBoundItem as Student;
        }
        private void EditStudent(object sender, EventArgs e)
        {
            new FormStudent(SelectedStudent, journal.Groups).Show();
            UpdateDataSource();
        }
        private void AddStudent(object sender, EventArgs e)
        {
            var newStudent = new Student();
            journal.AddStudent(newStudent);
            new FormStudent(newStudent, journal.Groups).Show();
            UpdateDataSource();
        }

        private void DeleteStudent(object sender, EventArgs e)
        {
            journal.RemoveStudent(SelectedStudent);
            UpdateDataSource();
        }

        private void buttonEditGroups_Click(object sender, EventArgs e)
        {
            formGroups.ShowDialog();
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataSourceGridView();
        }

        private void checkBoxRatio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataSourceGridView();
        }

        private void buttonSearchFIO_Click(object sender, EventArgs e)
        {
            SearchInColumn(1);
        }
        private void buttonSearchStudbilet_Click(object sender, EventArgs e)
        {
            SearchInColumn(0);
        }

        private void SearchInColumn(int col)
        {
            int i = 0;
            if (dataGridViewJournal.CurrentCell.ColumnIndex == col &&
                dataGridViewJournal.CurrentCell.FormattedValue.ToString().Contains(textBoxSearch.Text))
            {
                i = dataGridViewJournal.CurrentCell.RowIndex + 1;
            }
            while (i < dataGridViewJournal.RowCount)
            {
                if (dataGridViewJournal[col, i].FormattedValue.ToString().Contains(textBoxSearch.Text))
                {
                    dataGridViewJournal.CurrentCell = dataGridViewJournal[col, i];
                    return;
                }
                i++;
            }
            MessageBox.Show("Ничего не найдено!");
        }
    }
}
