namespace Students
{
    partial class FormGrade
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
            this.labelDicipline = new System.Windows.Forms.Label();
            this.textBoxDicipline = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSemestr = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemestr)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDicipline
            // 
            this.labelDicipline.AutoSize = true;
            this.labelDicipline.Location = new System.Drawing.Point(12, 14);
            this.labelDicipline.Name = "labelDicipline";
            this.labelDicipline.Size = new System.Drawing.Size(64, 13);
            this.labelDicipline.TabIndex = 0;
            this.labelDicipline.Text = "Дициплина";
            // 
            // textBoxDicipline
            // 
            this.textBoxDicipline.Location = new System.Drawing.Point(15, 30);
            this.textBoxDicipline.Multiline = true;
            this.textBoxDicipline.Name = "textBoxDicipline";
            this.textBoxDicipline.Size = new System.Drawing.Size(340, 71);
            this.textBoxDicipline.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Семестр";
            // 
            // numericUpDownSemestr
            // 
            this.numericUpDownSemestr.Location = new System.Drawing.Point(15, 126);
            this.numericUpDownSemestr.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownSemestr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSemestr.Name = "numericUpDownSemestr";
            this.numericUpDownSemestr.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownSemestr.TabIndex = 3;
            this.numericUpDownSemestr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Оценка";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(89, 164);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(190, 164);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "отлично",
            "хорошо",
            "удовлетворительно",
            "неудовлетворительно"});
            this.comboBoxGrade.Location = new System.Drawing.Point(190, 125);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(165, 21);
            this.comboBoxGrade.TabIndex = 8;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Экзамен"});
            this.comboBoxType.Location = new System.Drawing.Point(76, 125);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(101, 21);
            this.comboBoxType.TabIndex = 10;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(73, 109);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(26, 13);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Тип";
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 205);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSemestr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDicipline);
            this.Controls.Add(this.labelDicipline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGrade";
            this.Text = "Редактирование оценки";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemestr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDicipline;
        private System.Windows.Forms.TextBox textBoxDicipline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSemestr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
    }
}