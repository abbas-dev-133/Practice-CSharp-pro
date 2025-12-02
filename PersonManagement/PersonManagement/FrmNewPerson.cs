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
    public partial class FrmNewPerson : Form
    {
        private Person _person;
        private bool _isNew = false;
        public FrmNewPerson(Person person = null)
        {
            InitializeComponent();
            if (person == null)
            {
                person = new Person();
                _isNew = true;
            }

            _person = person;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _person.Name = txtName.Text;
            _person.FamilyName = txtFamilyName.Text;
            _person.NationalCode = txtNationalCode.Text;
            if (rbMale.Checked)
                _person.Gender = GenderType.Male;
            else if (rbFemale.Checked)
                _person.Gender = GenderType.Female;
            else
                _person.Gender = GenderType.Unknown;
            var result = _person.Validate();
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var frmPerson = Application.OpenForms[nameof(FrmPerson)] as FrmPerson;
            if (frmPerson != null)
            {
                if (_isNew)
                    frmPerson.persons.Add(_person);

                frmPerson.FillDgv();
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

        private void frmNewPerson_Load(object sender, EventArgs e)
        {
            txtName.Text = _person.Name;
            txtFamilyName.Text = _person.FamilyName;
            txtNationalCode.Text = _person.NationalCode;
            if (_person.Gender == GenderType.Male)
                rbMale.Checked = true;
            else if (_person.Gender == GenderType.Female)
                rbFemale.Checked = true;
        }
    }
}
