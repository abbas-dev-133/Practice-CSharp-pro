namespace WordCharAnalyzer
{
    partial class frmWordCharAnalyzer
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
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.txtSearchChar = new System.Windows.Forms.TextBox();
            this.btnCountWordsContaining = new System.Windows.Forms.Button();
            this.btnCountCharacterOccurrences = new System.Windows.Forms.Button();
            this.btnGetWordList = new System.Windows.Forms.Button();
            this.ttGetWord = new System.Windows.Forms.ToolTip(this.components);
            this.ttCharSearch = new System.Windows.Forms.ToolTip(this.components);
            this.txtLetterCountResult = new System.Windows.Forms.TextBox();
            this.txtWordCountResult = new System.Windows.Forms.TextBox();
            this.lblWordList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInputText
            // 
            this.txtInputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputText.Location = new System.Drawing.Point(12, 15);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(261, 99);
            this.txtInputText.TabIndex = 0;
            this.txtInputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchChar_KeyPress);
            this.txtInputText.MouseEnter += new System.EventHandler(this.txtGetWord_MouseEnter);
            // 
            // txtSearchChar
            // 
            this.txtSearchChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchChar.Location = new System.Drawing.Point(12, 120);
            this.txtSearchChar.MaxLength = 1;
            this.txtSearchChar.Name = "txtSearchChar";
            this.txtSearchChar.Size = new System.Drawing.Size(261, 20);
            this.txtSearchChar.TabIndex = 1;
            this.txtSearchChar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchChar_KeyPress);
            this.txtSearchChar.MouseEnter += new System.EventHandler(this.txtCharSearch_MouseEnter);
            // 
            // btnCountWordsContaining
            // 
            this.btnCountWordsContaining.Location = new System.Drawing.Point(12, 146);
            this.btnCountWordsContaining.Name = "btnCountWordsContaining";
            this.btnCountWordsContaining.Size = new System.Drawing.Size(78, 27);
            this.btnCountWordsContaining.TabIndex = 2;
            this.btnCountWordsContaining.Text = "تعداد کلمه";
            this.btnCountWordsContaining.UseVisualStyleBackColor = true;
            this.btnCountWordsContaining.Click += new System.EventHandler(this.btnCountWordsContaining_Click);
            // 
            // btnCountCharacterOccurrences
            // 
            this.btnCountCharacterOccurrences.Location = new System.Drawing.Point(12, 235);
            this.btnCountCharacterOccurrences.Name = "btnCountCharacterOccurrences";
            this.btnCountCharacterOccurrences.Size = new System.Drawing.Size(78, 25);
            this.btnCountCharacterOccurrences.TabIndex = 3;
            this.btnCountCharacterOccurrences.Text = "تعداد حرف";
            this.btnCountCharacterOccurrences.UseVisualStyleBackColor = true;
            this.btnCountCharacterOccurrences.Click += new System.EventHandler(this.btnCountCharacterOccurrences_Click);
            // 
            // btnGetWordList
            // 
            this.btnGetWordList.Location = new System.Drawing.Point(165, 150);
            this.btnGetWordList.Name = "btnGetWordList";
            this.btnGetWordList.Size = new System.Drawing.Size(108, 27);
            this.btnGetWordList.TabIndex = 4;
            this.btnGetWordList.Text = "لیست کلمات";
            this.btnGetWordList.UseVisualStyleBackColor = true;
            this.btnGetWordList.Click += new System.EventHandler(this.btnGetWordList_Click);
            // 
            // txtLetterCountResult
            // 
            this.txtLetterCountResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLetterCountResult.Location = new System.Drawing.Point(96, 235);
            this.txtLetterCountResult.Name = "txtLetterCountResult";
            this.txtLetterCountResult.ReadOnly = true;
            this.txtLetterCountResult.Size = new System.Drawing.Size(46, 20);
            this.txtLetterCountResult.TabIndex = 5;
            // 
            // txtWordCountResult
            // 
            this.txtWordCountResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWordCountResult.Location = new System.Drawing.Point(96, 150);
            this.txtWordCountResult.Name = "txtWordCountResult";
            this.txtWordCountResult.ReadOnly = true;
            this.txtWordCountResult.Size = new System.Drawing.Size(46, 20);
            this.txtWordCountResult.TabIndex = 5;
            // 
            // lblWordList
            // 
            this.lblWordList.Location = new System.Drawing.Point(165, 180);
            this.lblWordList.Name = "lblWordList";
            this.lblWordList.Size = new System.Drawing.Size(108, 115);
            this.lblWordList.TabIndex = 6;
            // 
            // frmWordCharAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 304);
            this.Controls.Add(this.lblWordList);
            this.Controls.Add(this.txtWordCountResult);
            this.Controls.Add(this.txtLetterCountResult);
            this.Controls.Add(this.btnGetWordList);
            this.Controls.Add(this.btnCountCharacterOccurrences);
            this.Controls.Add(this.btnCountWordsContaining);
            this.Controls.Add(this.txtSearchChar);
            this.Controls.Add(this.txtInputText);
            this.Name = "frmWordCharAnalyzer";
            this.Text = "WordCharAnalyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.TextBox txtSearchChar;
        private System.Windows.Forms.Button btnCountWordsContaining;
        private System.Windows.Forms.Button btnCountCharacterOccurrences;
        private System.Windows.Forms.Button btnGetWordList;
        private System.Windows.Forms.ToolTip ttGetWord;
        private System.Windows.Forms.ToolTip ttCharSearch;
        private System.Windows.Forms.TextBox txtLetterCountResult;
        private System.Windows.Forms.TextBox txtWordCountResult;
        private System.Windows.Forms.Label lblWordList;
    }
}

