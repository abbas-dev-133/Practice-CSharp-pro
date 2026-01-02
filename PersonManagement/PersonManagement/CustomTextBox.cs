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
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            _defaultBackColor = BackColor;
            BackColor = Color.LightYellow;
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            BackColor = _defaultBackColor;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Parent.SelectNextControl(
                                    this,
                                    true,
                                    true,
                                    true,
                                    true
                                );
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
