namespace PersonManagement
{
    partial class FrmMenu
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
            this.btnStudentManagement = new System.Windows.Forms.Button();
            this.btnTeacherManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.Location = new System.Drawing.Point(106, 124);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new System.Drawing.Size(137, 47);
            this.btnStudentManagement.TabIndex = 0;
            this.btnStudentManagement.Text = "Student Management";
            this.btnStudentManagement.UseVisualStyleBackColor = true;
            this.btnStudentManagement.Click += new System.EventHandler(this.btnStudentManagement_Click);
            // 
            // btnTeacherManagement
            // 
            this.btnTeacherManagement.Location = new System.Drawing.Point(106, 177);
            this.btnTeacherManagement.Name = "btnTeacherManagement";
            this.btnTeacherManagement.Size = new System.Drawing.Size(137, 47);
            this.btnTeacherManagement.TabIndex = 0;
            this.btnTeacherManagement.Text = "Teacher Management";
            this.btnTeacherManagement.UseVisualStyleBackColor = true;
            this.btnTeacherManagement.Click += new System.EventHandler(this.btnTeacherManagement_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 390);
            this.Controls.Add(this.btnTeacherManagement);
            this.Controls.Add(this.btnStudentManagement);
            this.MaximumSize = new System.Drawing.Size(399, 390);
            this.MinimumSize = new System.Drawing.Size(399, 390);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentManagement;
        private System.Windows.Forms.Button btnTeacherManagement;
    }
}