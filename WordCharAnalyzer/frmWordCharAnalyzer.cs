using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WordCharAnalyzer
{
    public partial class frmWordCharAnalyzer : Form
    {
        public int CharCount(string text, string search)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(search))
                return 0;
            int count = 0;
            foreach (char c in text)
            {
                if (c.ToString().Equals(search, StringComparison.OrdinalIgnoreCase))
                    count++;
            }
            return count;

        }
        public string WordList(string text, string search)
        {
            if(string.IsNullOrEmpty(text))
                return string.Empty;
            string result = "";
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(search))
                {
                    result += words[i];
                    if (i != words.Length - 1)
                        result += Environment.NewLine;
                    
                }
            }

            return result;

        }
        public int WordCount(string text, string search)
        {
            var word = text.Split(' ');
            var count = 0;
            foreach (var item in word)
            {
                if (item.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
                    count++;
            }
            return count;
        }
        public bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtInputText.Text) || string.IsNullOrEmpty(txtSearchChar.Text))
            {
                MessageBox.Show("لطفا متن و حرف مورد نظر را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public frmWordCharAnalyzer()
        {
            InitializeComponent();
        }

        private void txtGetWord_MouseEnter(object sender, EventArgs e)
        {
            ttGetWord.SetToolTip(txtInputText, "لطفا یک رشته وارد نمایید");
        }

        private void txtCharSearch_MouseEnter(object sender, EventArgs e)
        {
            ttCharSearch.SetToolTip(txtSearchChar, "لطفا یک حرف وارد نمایید");
        }

        private void txtSearchChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnGetWordList_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            string result = WordList(txtInputText.Text, txtSearchChar.Text);
            lblWordList.Text = result;
        }

        private void btnCountWordsContaining_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            int result = WordCount(txtInputText.Text, txtSearchChar.Text);
            txtWordCountResult.Text = result.ToString();
        }

        private void btnCountCharacterOccurrences_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            int count = CharCount(txtInputText.Text, txtSearchChar.Text);
            txtLetterCountResult.Text = count.ToString();
        }

      
    }
}
