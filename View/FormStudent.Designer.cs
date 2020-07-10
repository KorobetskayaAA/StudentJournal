namespace Students
{
    partial class FormStudent
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Семестр 1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Семестр 2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Математика",
            "1",
            "Экзамен",
            "хорошо"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Базы данных",
            "2",
            "Зачет",
            "зачтено"}, -1);
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.textBoxStudbilet = new System.Windows.Forms.MaskedTextBox();
            this.labelStudbilet = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listViewGrades = new System.Windows.Forms.ListView();
            this.columnHeaderDicipline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSemestr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGradeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.maskedTextBoxPay = new System.Windows.Forms.MaskedTextBox();
            this.textBoxStipend = new System.Windows.Forms.TextBox();
            this.textBoxPaymentDebt = new System.Windows.Forms.TextBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.labelPaymentDebt = new System.Windows.Forms.Label();
            this.labelStipend = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(15, 13);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "&Фамилия";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurname.Location = new System.Drawing.Point(18, 29);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(388, 20);
            this.textBoxSurname.TabIndex = 1;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_RusOnly);
            this.textBoxSurname.Validating += new System.ComponentModel.CancelEventHandler(this.Validating_NonEmpty);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(18, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(388, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_RusOnly);
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.Validating_NonEmpty);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(18, 127);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(388, 20);
            this.textBoxPatronymic.TabIndex = 5;
            this.textBoxPatronymic.TextChanged += new System.EventHandler(this.textBoxPatronymic_TextChanged);
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(15, 111);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 4;
            this.labelPatronymic.Text = "Отчество";
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(18, 184);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerBirth.TabIndex = 7;
            this.dateTimePickerBirth.ValueChanged += new System.EventHandler(this.dateTimePickerBirth_ValueChanged);
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(17, 168);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(86, 13);
            this.labelBirthDate.TabIndex = 6;
            this.labelBirthDate.Text = "Дата рождения";
            // 
            // textBoxStudbilet
            // 
            this.textBoxStudbilet.Location = new System.Drawing.Point(18, 31);
            this.textBoxStudbilet.Mask = "00000000";
            this.textBoxStudbilet.Name = "textBoxStudbilet";
            this.textBoxStudbilet.PromptChar = '0';
            this.textBoxStudbilet.Size = new System.Drawing.Size(83, 20);
            this.textBoxStudbilet.TabIndex = 8;
            this.textBoxStudbilet.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBoxStudbilet_MaskInputRejected);
            // 
            // labelStudbilet
            // 
            this.labelStudbilet.AutoSize = true;
            this.labelStudbilet.Location = new System.Drawing.Point(15, 15);
            this.labelStudbilet.Name = "labelStudbilet";
            this.labelStudbilet.Size = new System.Drawing.Size(78, 13);
            this.labelStudbilet.TabIndex = 9;
            this.labelStudbilet.Text = "№ студбилета";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(15, 64);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(42, 13);
            this.labelGroup.TabIndex = 10;
            this.labelGroup.Text = "Группа";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listViewGrades
            // 
            this.listViewGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewGrades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDicipline,
            this.columnHeaderSemestr,
            this.columnHeaderType,
            this.columnHeaderGradeName});
            listViewGroup5.Header = "Семестр 1";
            listViewGroup5.Name = "listViewGroup1";
            listViewGroup6.Header = "Семестр 2";
            listViewGroup6.Name = "listViewGroup2";
            this.listViewGrades.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6});
            this.listViewGrades.HideSelection = false;
            listViewItem5.Group = listViewGroup5;
            listViewItem6.Group = listViewGroup6;
            this.listViewGrades.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listViewGrades.Location = new System.Drawing.Point(6, 6);
            this.listViewGrades.Name = "listViewGrades";
            this.listViewGrades.Size = new System.Drawing.Size(415, 263);
            this.listViewGrades.TabIndex = 13;
            this.listViewGrades.UseCompatibleStateImageBehavior = false;
            this.listViewGrades.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDicipline
            // 
            this.columnHeaderDicipline.Text = "Дисциплина";
            this.columnHeaderDicipline.Width = 150;
            // 
            // columnHeaderSemestr
            // 
            this.columnHeaderSemestr.Text = "Семестр";
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Тип";
            // 
            // columnHeaderGradeName
            // 
            this.columnHeaderGradeName.Text = "Оценка";
            this.columnHeaderGradeName.Width = 120;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(193, 275);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteGrade);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.Location = new System.Drawing.Point(99, 275);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.EditGrade);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(8, 275);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.AddGrade);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelSurname);
            this.tabPage1.Controls.Add(this.textBoxSurname);
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.labelPatronymic);
            this.tabPage1.Controls.Add(this.textBoxPatronymic);
            this.tabPage1.Controls.Add(this.dateTimePickerBirth);
            this.tabPage1.Controls.Add(this.labelBirthDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Личные данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.maskedTextBoxPay);
            this.tabPage2.Controls.Add(this.textBoxStipend);
            this.tabPage2.Controls.Add(this.textBoxPaymentDebt);
            this.tabPage2.Controls.Add(this.buttonPay);
            this.tabPage2.Controls.Add(this.buttonTransfer);
            this.tabPage2.Controls.Add(this.labelPaymentDebt);
            this.tabPage2.Controls.Add(this.labelStipend);
            this.tabPage2.Controls.Add(this.labelType);
            this.tabPage2.Controls.Add(this.comboBoxGroup);
            this.tabPage2.Controls.Add(this.labelStudbilet);
            this.tabPage2.Controls.Add(this.textBoxStudbilet);
            this.tabPage2.Controls.Add(this.labelGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(427, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Учеба";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(18, 80);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(392, 21);
            this.comboBoxGroup.TabIndex = 12;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listViewGrades);
            this.tabPage3.Controls.Add(this.buttonDelete);
            this.tabPage3.Controls.Add(this.buttonEdit);
            this.tabPage3.Controls.Add(this.buttonAdd);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(427, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Оценки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPay
            // 
            this.maskedTextBoxPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPay.HidePromptOnLeave = true;
            this.maskedTextBoxPay.Location = new System.Drawing.Point(335, 164);
            this.maskedTextBoxPay.Mask = "999,990.99";
            this.maskedTextBoxPay.Name = "maskedTextBoxPay";
            this.maskedTextBoxPay.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxPay.TabIndex = 55;
            // 
            // textBoxStipend
            // 
            this.textBoxStipend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStipend.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxStipend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStipend.Location = new System.Drawing.Point(76, 154);
            this.textBoxStipend.Name = "textBoxStipend";
            this.textBoxStipend.ReadOnly = true;
            this.textBoxStipend.Size = new System.Drawing.Size(61, 13);
            this.textBoxStipend.TabIndex = 54;
            this.textBoxStipend.Text = "2 000 р.";
            this.textBoxStipend.Visible = false;
            // 
            // textBoxPaymentDebt
            // 
            this.textBoxPaymentDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPaymentDebt.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPaymentDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPaymentDebt.Location = new System.Drawing.Point(150, 167);
            this.textBoxPaymentDebt.Name = "textBoxPaymentDebt";
            this.textBoxPaymentDebt.ReadOnly = true;
            this.textBoxPaymentDebt.Size = new System.Drawing.Size(51, 13);
            this.textBoxPaymentDebt.TabIndex = 53;
            this.textBoxPaymentDebt.Text = "10 000 р.";
            // 
            // buttonPay
            // 
            this.buttonPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPay.Location = new System.Drawing.Point(245, 161);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(75, 23);
            this.buttonPay.TabIndex = 52;
            this.buttonPay.Text = "Оплатить";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(207, 119);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(156, 23);
            this.buttonTransfer.TabIndex = 51;
            this.buttonTransfer.Text = "Перевести на бюджет";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // labelPaymentDebt
            // 
            this.labelPaymentDebt.AutoSize = true;
            this.labelPaymentDebt.Location = new System.Drawing.Point(15, 166);
            this.labelPaymentDebt.Name = "labelPaymentDebt";
            this.labelPaymentDebt.Size = new System.Drawing.Size(138, 13);
            this.labelPaymentDebt.TabIndex = 50;
            this.labelPaymentDebt.Text = "Долг по оплате обучения:";
            // 
            // labelStipend
            // 
            this.labelStipend.AutoSize = true;
            this.labelStipend.Location = new System.Drawing.Point(15, 153);
            this.labelStipend.Name = "labelStipend";
            this.labelStipend.Size = new System.Drawing.Size(64, 13);
            this.labelStipend.TabIndex = 49;
            this.labelStipend.Text = "Стипендия:";
            this.labelStipend.Visible = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(15, 124);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(192, 13);
            this.labelType.TabIndex = 48;
            this.labelType.Text = "Обучается на коммерческой основе";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 332);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(370, 370);
            this.Name = "FormStudent";
            this.Text = "Студент";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.MaskedTextBox textBoxStudbilet;
        private System.Windows.Forms.Label labelStudbilet;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListView listViewGrades;
        private System.Windows.Forms.ColumnHeader columnHeaderDicipline;
        private System.Windows.Forms.ColumnHeader columnHeaderSemestr;
        private System.Windows.Forms.ColumnHeader columnHeaderGradeName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPay;
        private System.Windows.Forms.TextBox textBoxStipend;
        private System.Windows.Forms.TextBox textBoxPaymentDebt;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Label labelPaymentDebt;
        private System.Windows.Forms.Label labelStipend;
        private System.Windows.Forms.Label labelType;
    }
}

