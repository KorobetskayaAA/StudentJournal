namespace Students
{
    partial class FormNewStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCommercial = new System.Windows.Forms.RadioButton();
            this.radioButtonBudget = new System.Windows.Forms.RadioButton();
            this.textBoxStudBilet = new System.Windows.Forms.MaskedTextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.pickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblStudBilet = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCommercial);
            this.groupBox1.Controls.Add(this.radioButtonBudget);
            this.groupBox1.Location = new System.Drawing.Point(24, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 50);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обучается на";
            // 
            // radioButtonCommercial
            // 
            this.radioButtonCommercial.AutoSize = true;
            this.radioButtonCommercial.Checked = true;
            this.radioButtonCommercial.Location = new System.Drawing.Point(204, 19);
            this.radioButtonCommercial.Name = "radioButtonCommercial";
            this.radioButtonCommercial.Size = new System.Drawing.Size(139, 17);
            this.radioButtonCommercial.TabIndex = 1;
            this.radioButtonCommercial.TabStop = true;
            this.radioButtonCommercial.Text = "коммерческой основе";
            this.radioButtonCommercial.UseVisualStyleBackColor = true;
            // 
            // radioButtonBudget
            // 
            this.radioButtonBudget.AutoSize = true;
            this.radioButtonBudget.Location = new System.Drawing.Point(47, 19);
            this.radioButtonBudget.Name = "radioButtonBudget";
            this.radioButtonBudget.Size = new System.Drawing.Size(121, 17);
            this.radioButtonBudget.TabIndex = 0;
            this.radioButtonBudget.Text = "бюджетной основе";
            this.radioButtonBudget.UseVisualStyleBackColor = true;
            // 
            // textBoxStudBilet
            // 
            this.textBoxStudBilet.Location = new System.Drawing.Point(24, 126);
            this.textBoxStudBilet.Mask = "00000000";
            this.textBoxStudBilet.Name = "textBoxStudBilet";
            this.textBoxStudBilet.PromptChar = '0';
            this.textBoxStudBilet.Size = new System.Drawing.Size(75, 20);
            this.textBoxStudBilet.TabIndex = 29;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(310, 18);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(86, 13);
            this.lblBirthDate.TabIndex = 26;
            this.lblBirthDate.Text = "Дата рождения";
            // 
            // pickerBirthDate
            // 
            this.pickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerBirthDate.Location = new System.Drawing.Point(313, 34);
            this.pickerBirthDate.Name = "pickerBirthDate";
            this.pickerBirthDate.Size = new System.Drawing.Size(104, 20);
            this.pickerBirthDate.TabIndex = 25;
            // 
            // lblStudBilet
            // 
            this.lblStudBilet.AutoSize = true;
            this.lblStudBilet.Location = new System.Drawing.Point(21, 109);
            this.lblStudBilet.Name = "lblStudBilet";
            this.lblStudBilet.Size = new System.Drawing.Size(78, 13);
            this.lblStudBilet.TabIndex = 24;
            this.lblStudBilet.Text = "№ студбилета";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(219, 73);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(198, 20);
            this.textBoxPatronymic.TabIndex = 23;
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(216, 57);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(54, 13);
            this.lblPatronymic.TabIndex = 22;
            this.lblPatronymic.Text = "Отчество";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(24, 73);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(189, 20);
            this.textBoxFirstName.TabIndex = 21;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(21, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 20;
            this.lblFirstName.Text = "Имя";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(21, 18);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Фамилия";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(24, 34);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(283, 20);
            this.textBoxLastName.TabIndex = 18;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(245, 238);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(117, 238);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 31;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(114, 110);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(42, 13);
            this.labelGroup.TabIndex = 35;
            this.labelGroup.Text = "Группа";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.Location = new System.Drawing.Point(117, 126);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(300, 21);
            this.comboBoxGroup.TabIndex = 36;
            // 
            // FormNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 277);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxStudBilet);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.pickerBirthDate);
            this.Controls.Add(this.lblStudBilet);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.textBoxLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormNewStudent";
            this.Text = "Добавление нового студента";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCommercial;
        private System.Windows.Forms.RadioButton radioButtonBudget;
        private System.Windows.Forms.MaskedTextBox textBoxStudBilet;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker pickerBirthDate;
        private System.Windows.Forms.Label lblStudBilet;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox comboBoxGroup;
    }
}