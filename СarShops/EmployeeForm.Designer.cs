namespace СarShops
{
    partial class EmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SalaryTb = new System.Windows.Forms.TextBox();
            this.Lalala = new System.Windows.Forms.Label();
            this.AgeTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BirthdayDp = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SAVE = new System.Windows.Forms.Button();
            this.PositionCb = new System.Windows.Forms.ComboBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.Surnametb = new System.Windows.Forms.TextBox();
            this.labelEducation = new System.Windows.Forms.Label();
            this.EducationCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary";
            // 
            // SalaryTb
            // 
            this.SalaryTb.Location = new System.Drawing.Point(307, 43);
            this.SalaryTb.Name = "SalaryTb";
            this.SalaryTb.Size = new System.Drawing.Size(125, 27);
            this.SalaryTb.TabIndex = 1;
            // 
            // Lalala
            // 
            this.Lalala.AutoSize = true;
            this.Lalala.Location = new System.Drawing.Point(48, 153);
            this.Lalala.Name = "Lalala";
            this.Lalala.Size = new System.Drawing.Size(61, 20);
            this.Lalala.TabIndex = 2;
            this.Lalala.Text = "Position";
            // 
            // AgeTb
            // 
            this.AgeTb.Location = new System.Drawing.Point(470, 43);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(125, 27);
            this.AgeTb.TabIndex = 5;
            this.AgeTb.TextChanged += new System.EventHandler(this.AgeTb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // BirthdayDp
            // 
            this.BirthdayDp.Location = new System.Drawing.Point(470, 193);
            this.BirthdayDp.Name = "BirthdayDp";
            this.BirthdayDp.Size = new System.Drawing.Size(250, 27);
            this.BirthdayDp.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birthday";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(12, 42);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(125, 27);
            this.NameTb.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(48, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 20);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name";
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(12, 409);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(776, 29);
            this.SAVE.TabIndex = 39;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // PositionCb
            // 
            this.PositionCb.FormattingEnabled = true;
            this.PositionCb.Location = new System.Drawing.Point(12, 192);
            this.PositionCb.Name = "PositionCb";
            this.PositionCb.Size = new System.Drawing.Size(151, 28);
            this.PositionCb.TabIndex = 40;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(187, 19);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 20);
            this.labelSurname.TabIndex = 41;
            this.labelSurname.Text = "Surname";
            this.labelSurname.Click += new System.EventHandler(this.labelSurname_Click);
            // 
            // Surnametb
            // 
            this.Surnametb.Location = new System.Drawing.Point(159, 42);
            this.Surnametb.Name = "Surnametb";
            this.Surnametb.Size = new System.Drawing.Size(125, 27);
            this.Surnametb.TabIndex = 42;
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Location = new System.Drawing.Point(243, 153);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(75, 20);
            this.labelEducation.TabIndex = 43;
            this.labelEducation.Text = "Education";
            // 
            // EducationCb
            // 
            this.EducationCb.FormattingEnabled = true;
            this.EducationCb.Location = new System.Drawing.Point(208, 192);
            this.EducationCb.Name = "EducationCb";
            this.EducationCb.Size = new System.Drawing.Size(151, 28);
            this.EducationCb.TabIndex = 44;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EducationCb);
            this.Controls.Add(this.labelEducation);
            this.Controls.Add(this.Surnametb);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.PositionCb);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BirthdayDp);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lalala);
            this.Controls.Add(this.SalaryTb);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalaryTb;
        private System.Windows.Forms.Label Lalala;
        private System.Windows.Forms.TextBox AgeTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker BirthdayDp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.ComboBox PositionCb;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox Surnametb;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.ComboBox EducationCb;
    }
}