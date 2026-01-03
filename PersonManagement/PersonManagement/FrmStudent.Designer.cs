namespace PersonManagement
{
    partial class FrmStudent
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
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbUnknown = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.lblStudentCode = new System.Windows.Forms.Label();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGender
            // 
            this.gbGender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gbGender.Controls.Add(this.rbUnknown);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(70, 228);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(164, 135);
            this.gbGender.TabIndex = 5;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbUnknown
            // 
            this.rbUnknown.AutoSize = true;
            this.rbUnknown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUnknown.Location = new System.Drawing.Point(12, 95);
            this.rbUnknown.Name = "rbUnknown";
            this.rbUnknown.Size = new System.Drawing.Size(94, 24);
            this.rbUnknown.TabIndex = 0;
            this.rbUnknown.TabStop = true;
            this.rbUnknown.Text = "Unkowon";
            this.rbUnknown.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(12, 59);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(80, 24);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(12, 29);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(61, 24);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGrade
            // 
            this.lblGrade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(240, 202);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(54, 20);
            this.lblGrade.TabIndex = 6;
            this.lblGrade.Text = "Grade";
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveAndNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndNew.Location = new System.Drawing.Point(70, 410);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(138, 35);
            this.btnSaveAndNew.TabIndex = 7;
            this.btnSaveAndNew.TabStop = false;
            this.btnSaveAndNew.Text = "Save And New";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // lblStudentCode
            // 
            this.lblStudentCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStudentCode.AutoSize = true;
            this.lblStudentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCode.Location = new System.Drawing.Point(240, 168);
            this.lblStudentCode.Name = "lblStudentCode";
            this.lblStudentCode.Size = new System.Drawing.Size(104, 20);
            this.lblStudentCode.TabIndex = 7;
            this.lblStudentCode.Text = "StudentCode";
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndClose.Location = new System.Drawing.Point(70, 369);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(138, 35);
            this.btnSaveAndClose.TabIndex = 6;
            this.btnSaveAndClose.TabStop = false;
            this.btnSaveAndClose.Text = "Save And Close";
            this.btnSaveAndClose.UseVisualStyleBackColor = true;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalCode.Location = new System.Drawing.Point(240, 136);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(105, 20);
            this.lblNationalCode.TabIndex = 8;
            this.lblNationalCode.Text = "NationalCode";
            // 
            // lblFamilyName
            // 
            this.lblFamilyName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFamilyName.AutoSize = true;
            this.lblFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilyName.Location = new System.Drawing.Point(240, 98);
            this.lblFamilyName.Name = "lblFamilyName";
            this.lblFamilyName.Size = new System.Drawing.Size(100, 20);
            this.lblFamilyName.TabIndex = 9;
            this.lblFamilyName.Text = "Family Name";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(240, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(70, 66);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(164, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(70, 136);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(164, 20);
            this.txtNationalCode.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(70, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(164, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(70, 198);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(164, 20);
            this.txtGrade.TabIndex = 4;
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(70, 162);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(164, 20);
            this.txtStudentCode.TabIndex = 3;
            // 
            // FrmStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(413, 481);
            this.Controls.Add(this.txtStudentCode);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.lblStudentCode);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblFamilyName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(429, 520);
            this.MinimumSize = new System.Drawing.Size(429, 520);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.frmNewPerson_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbUnknown;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Label lblStudentCode;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblFamilyName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtStudentCode;
    }
}