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
        bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtFamilyName.Text))
            {
                MessageBox.Show("لطفا همه فیلدها را پر کنید.", "خطا",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("لطفا جنسیت را انتخاب کنید", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNationalCode.Text) || txtNationalCode.Text.Length != 10)
            {
                MessageBox.Show("لطفا کد ملی معتبر ۱۰ رقمی وارد کنید.", "خطا",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public frmNewPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            var people = new Person();
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

            var frmPerson = Application.OpenForms["frmPerson"] as frmPerson;
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
