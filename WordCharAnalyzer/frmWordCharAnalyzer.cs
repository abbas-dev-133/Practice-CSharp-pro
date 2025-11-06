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
    public partial class Form1 : Form
    {
        public int WordCount(string text, string search)
        {


            var word = text.Split(' ');
            var count = 0;
            foreach (var item in word)
            {
                if (item.Contains(search))
                    count++;
            }
            return count;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtGetWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;


        }

        private void btnWordCount_Click(object sender, EventArgs e)
        {
            var text = txtGetWord.Text;
            var search = btnCharSearch.Text;
            int count = WordCount(text, search);
            MessageBox.Show($"تعداد حرف {search}  موجود در رشته  برابر است با: {count}"
                ,"پیام", MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
        }


        private void txtGetChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
