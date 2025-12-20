using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagement
{
    public partial class CustomTextBox : TextBox
    {
        private Color _defaultBackColor;

        public CustomTextBox()
        {
            this.Enter += txtCustom_Enter;
            this.Leave += txtCustom_Leave;
            this.KeyDown += txtCustom_KeyDown;
        }

        private void txtCustom_Enter(object sender, EventArgs e)
        {
            _defaultBackColor = this.BackColor;
            this.BackColor = Color.WhiteSmoke;
        }

        private void txtCustom_Leave(object sender, EventArgs e)
        {
            this.BackColor = _defaultBackColor;
        }

        private void txtCustom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.Parent.SelectNextControl(this, true, true, true, true);
            }
        }

       
    }
}
