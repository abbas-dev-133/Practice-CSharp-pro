namespace PersonManagement
{
    partial class FrmTeacher
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.lblMobile = new System.Windows.Forms.Label();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.txtAddress = new PersonManagement.CustomTextBox();
            this.txtField = new PersonManagement.CustomTextBox();
            this.txtMobile = new PersonManagement.CustomTextBox();
            this.txtNationalCode = new PersonManagement.CustomTextBox();
            this.txtLastName = new PersonManagement.CustomTextBox();
            this.txtFirstName = new PersonManagement.CustomTextBox();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGender
            // 
            this.gbGender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gbGender.Controls.Add(this.rbUnknown);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(89, 298);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(164, 135);
            this.gbGender.TabIndex = 6;
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
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(259, 178);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Address";
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveAndNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndNew.Location = new System.Drawing.Point(89, 480);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(138, 35);
            this.btnSaveAndNew.TabIndex = 8;
            this.btnSaveAndNew.TabStop = false;
            this.btnSaveAndNew.Text = "Save And New";
            this.btnSaveAndNew.UseVisualStyleBackColor = true;
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(259, 117);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(55, 20);
            this.lblMobile.TabIndex = 20;
            this.lblMobile.Text = "Mobile";
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndClose.Location = new System.Drawing.Point(89, 439);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(138, 35);
            this.btnSaveAndClose.TabIndex = 7;
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
            this.lblNationalCode.Location = new System.Drawing.Point(259, 85);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(105, 20);
            this.lblNationalCode.TabIndex = 21;
            this.lblNationalCode.Text = "NationalCode";
            // 
            // lblFamilyName
            // 
            this.lblFamilyName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFamilyName.AutoSize = true;
            this.lblFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilyName.Location = new System.Drawing.Point(259, 47);
            this.lblFamilyName.Name = "lblFamilyName";
            this.lblFamilyName.Size = new System.Drawing.Size(100, 20);
            this.lblFamilyName.TabIndex = 22;
            this.lblFamilyName.Text = "Family Name";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(259, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // lblField
            // 
            this.lblField.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField.Location = new System.Drawing.Point(259, 146);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(43, 20);
            this.lblField.TabIndex = 20;
            this.lblField.Text = "Field";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(89, 180);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(160, 112);
            this.txtAddress.TabIndex = 5;
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(89, 146);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(160, 20);
            this.txtField.TabIndex = 4;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(89, 114);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(160, 20);
            this.txtMobile.TabIndex = 3;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(89, 85);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(160, 20);
            this.txtNationalCode.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(89, 49);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(89, 15);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // FrmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 531);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.btnSaveAndNew);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblFamilyName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Name = "FrmTeacher";
            this.Text = "FrmTeacher";
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
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblFamilyName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblField;
        private CustomTextBox txtNationalCode;
        private CustomTextBox txtLastName;
        private CustomTextBox txtFirstName;
        private CustomTextBox txtMobile;
        private CustomTextBox txtField;
        private CustomTextBox txtAddress;
    }
}