namespace PersonManagement
{
    partial class CustomTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCustom
            // 
            this.txtCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustom.Location = new System.Drawing.Point(0, 0);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(144, 20);
            this.txtCustom.TabIndex = 0;
            this.txtCustom.Enter += new System.EventHandler(this.txtCustom_Enter);
            this.txtCustom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustom_KeyDown);
            this.txtCustom.Leave += new System.EventHandler(this.txtCustom_Leave);
            // 
            // CustomTextBox
            // 
            this.Controls.Add(this.txtCustom);
            this.Size = new System.Drawing.Size(148, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustom;
    }
}
