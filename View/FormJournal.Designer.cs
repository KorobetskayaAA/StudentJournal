namespace Students
{
    partial class FormJournal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewJournal = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxGroup = new System.Windows.Forms.GroupBox();
            this.buttonEditGroups = new System.Windows.Forms.Button();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.studbiletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournal)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxStudent.SuspendLayout();
            this.groupBoxGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJournal
            // 
            this.dataGridViewJournal.AutoGenerateColumns = false;
            this.dataGridViewJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studbiletDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn});
            this.dataGridViewJournal.DataSource = this.studentBindingSource;
            this.dataGridViewJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewJournal.Location = new System.Drawing.Point(0, 53);
            this.dataGridViewJournal.Name = "dataGridViewJournal";
            this.dataGridViewJournal.ReadOnly = true;
            this.dataGridViewJournal.Size = new System.Drawing.Size(693, 331);
            this.dataGridViewJournal.TabIndex = 0;
            this.dataGridViewJournal.DoubleClick += new System.EventHandler(this.EditStudent);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxGroup);
            this.panel1.Controls.Add(this.groupBoxStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 53);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.buttonDelete);
            this.groupBoxStudent.Controls.Add(this.buttonEdit);
            this.groupBoxStudent.Controls.Add(this.buttonAdd);
            this.groupBoxStudent.Location = new System.Drawing.Point(12, 3);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(259, 46);
            this.groupBoxStudent.TabIndex = 5;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Студент";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(168, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteStudent);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(87, 16);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.EditStudent);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 16);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.AddStudent);
            // 
            // groupBoxGroup
            // 
            this.groupBoxGroup.Controls.Add(this.buttonEditGroups);
            this.groupBoxGroup.Controls.Add(this.comboBoxGroup);
            this.groupBoxGroup.Location = new System.Drawing.Point(280, 3);
            this.groupBoxGroup.Name = "groupBoxGroup";
            this.groupBoxGroup.Size = new System.Drawing.Size(265, 45);
            this.groupBoxGroup.TabIndex = 6;
            this.groupBoxGroup.TabStop = false;
            this.groupBoxGroup.Text = "Группа";
            // 
            // buttonEditGroups
            // 
            this.buttonEditGroups.Location = new System.Drawing.Point(231, 16);
            this.buttonEditGroups.Name = "buttonEditGroups";
            this.buttonEditGroups.Size = new System.Drawing.Size(24, 21);
            this.buttonEditGroups.TabIndex = 6;
            this.buttonEditGroups.Text = "...";
            this.buttonEditGroups.UseVisualStyleBackColor = true;
            this.buttonEditGroups.Click += new System.EventHandler(this.buttonEditGroups_Click);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(6, 16);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(219, 21);
            this.comboBoxGroup.TabIndex = 5;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // studbiletDataGridViewTextBoxColumn
            // 
            this.studbiletDataGridViewTextBoxColumn.DataPropertyName = "Studbilet";
            this.studbiletDataGridViewTextBoxColumn.HeaderText = "№ студбилета";
            this.studbiletDataGridViewTextBoxColumn.Name = "studbiletDataGridViewTextBoxColumn";
            this.studbiletDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 59;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupDataGridViewTextBoxColumn.Width = 67;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Students.Model.Student);
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 384);
            this.Controls.Add(this.dataGridViewJournal);
            this.Controls.Add(this.panel1);
            this.Name = "FormJournal";
            this.Text = "Журнал";
            this.Activated += new System.EventHandler(this.FormJournal_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJournal;
        private System.Windows.Forms.DataGridViewTextBoxColumn studbiletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxGroup;
        private System.Windows.Forms.Button buttonEditGroups;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}