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
    public partial class frmNewPerson : Form
    {
        private Person people = new Person();
        public frmNewPerson()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            people.Name = txtName.Text;
            people.FamilyName = txtFamilyName.Text;
            people.NationalCode = txtNationalCode.Text;
            if (rbMale.Checked)
                people.Gender = GenderType.Male;
            else
                if (rbFemale.Checked)
                people.Gender = GenderType.Female;
            else
                people.Gender = GenderType.Unknown;
            var result = people.Validate();
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var frmPerson= Application.OpenForms[nameof(FrmPerson)] as FrmPerson;
            if (frmPerson != null)
            {
                frmPerson.people.Add(people);
                frmPerson.FillDGV();
            }
            this.Close();



        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
