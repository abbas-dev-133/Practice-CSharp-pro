namespace WordCharAnalyzer
{
    partial class Form1
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
            this.txtGetWord = new System.Windows.Forms.TextBox();
            this.txtGetChar = new System.Windows.Forms.TextBox();
            this.btnWordCount = new System.Windows.Forms.Button();
            this.btnLetterCount = new System.Windows.Forms.Button();
            this.btnWordList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGetWord
            // 
            this.txtGetWord.Location = new System.Drawing.Point(134, 70);
            this.txtGetWord.Name = "txtGetWord";
            this.txtGetWord.Size = new System.Drawing.Size(176, 20);
            this.txtGetWord.TabIndex = 0;
            this.txtGetWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGetWord_KeyPress);
            // 
            // txtGetChar
            // 
            this.txtGetChar.Location = new System.Drawing.Point(134, 99);
            this.txtGetChar.MaxLength = 1;
            this.txtGetChar.Name = "txtGetChar";
            this.txtGetChar.Size = new System.Drawing.Size(176, 20);
            this.txtGetChar.TabIndex = 1;
            // 
            // btnWordCount
            // 
            this.btnWordCount.Location = new System.Drawing.Point(12, 15);
            this.btnWordCount.Name = "btnWordCount";
            this.btnWordCount.Size = new System.Drawing.Size(96, 49);
            this.btnWordCount.TabIndex = 2;
            this.btnWordCount.Text = "تعداد کلمه";
            this.btnWordCount.UseVisualStyleBackColor = true;
            // 
            // btnLetterCount
            // 
            this.btnLetterCount.Location = new System.Drawing.Point(12, 70);
            this.btnLetterCount.Name = "btnLetterCount";
            this.btnLetterCount.Size = new System.Drawing.Size(96, 49);
            this.btnLetterCount.TabIndex = 3;
            this.btnLetterCount.Text = "تعداد حرف";
            this.btnLetterCount.UseVisualStyleBackColor = true;
            // 
            // btnWordList
            // 
            this.btnWordList.Location = new System.Drawing.Point(12, 125);
            this.btnWordList.Name = "btnWordList";
            this.btnWordList.Size = new System.Drawing.Size(96, 53);
            this.btnWordList.TabIndex = 4;
            this.btnWordList.Text = "لیست کلمات";
            this.btnWordList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 190);
            this.Controls.Add(this.btnWordList);
            this.Controls.Add(this.btnLetterCount);
            this.Controls.Add(this.btnWordCount);
            this.Controls.Add(this.txtGetChar);
            this.Controls.Add(this.txtGetWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetWord;
        private System.Windows.Forms.TextBox txtGetChar;
        private System.Windows.Forms.Button btnWordCount;
        private System.Windows.Forms.Button btnLetterCount;
        private System.Windows.Forms.Button btnWordList;
    }
}

