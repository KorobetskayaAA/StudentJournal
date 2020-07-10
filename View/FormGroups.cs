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
    public partial class FormGroups : Form
    {
        List<Group> groups;
        public FormGroups(List<Group> groups)
        {
            InitializeComponent();

            this.groups = groups;

            (dataGridViewGroups.Columns[1] as DataGridViewComboBoxColumn).Items.Clear();
            (dataGridViewGroups.Columns[1] as DataGridViewComboBoxColumn).Items.AddRange(Group.EducationForms);

            dataGridViewGroups.DataSource = groups;
        }

        public void UpdateDataSource()
        {
            dataGridViewGroups.DataSource = null;
            dataGridViewGroups.DataSource = groups;
        }

        private void AddGroup(object sender, EventArgs e)
        {
            groups.Add(new Group());
            UpdateDataSource();
        }

        private void DeleteGroup(object sender, EventArgs e)
        {
            var group = dataGridViewGroups.CurrentRow.DataBoundItem as Group;
            if (group.Students.Count > 0)
            {
                MessageBox.Show("Нельзя удалить группу, в которой есть студенты.", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            groups.Remove(group);
            UpdateDataSource();
        }

        private void FormGroups_Activated(object sender, EventArgs e)
        {
            UpdateDataSource();
        }
    }
}
