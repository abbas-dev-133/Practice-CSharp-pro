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
    public partial class FrmPerson : Form
    {
        PersonManager personManager;
        public Person Person { get; set; }
        private bool isEdit = true;
        public FrmPerson()
        {
            InitializeComponent();
            personManager = new PersonManager();
        }
        private void frmNewPerson_Load(object sender, EventArgs e)
        {
            if (Person != null)
            {
                txtFirstName.Text = Person.FirstName;
                txtLastName.Text = Person.LastName;
                txtNationalCode.Text = Person.NationalCode;
                if (Person.Gender == Genders.Male)
                    rbMale.Checked = true;
                else if (Person.Gender == Genders.Female)
                    rbFemale.Checked = true;
                else if (Person.Gender == Genders.Unknown)
                    rbUnknown.Checked = true;
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Person == null)
            {
                Person = new Person();
                isEdit = false;
            }
            Person.FirstName = txtFirstName.Text;
            Person.LastName = txtLastName.Text;
            Person.NationalCode = txtNationalCode.Text;


            if (rbMale.Checked)
                Person.Gender = Genders.Male;
            else if (rbFemale.Checked)
                Person.Gender = Genders.Female;
            else if (rbUnknown.Checked)
                Person.Gender = Genders.Unknown;
            else
                Person.Gender = Genders.None;

            OperationResult result;
            if (!isEdit)
            {
                result = personManager.AddPerson(Person);
            }
            else
                result = Person.Validate();

            if (!result.IsSuccess)
            {
                MessageBoxHelper.Error(result.Message);
                if(!isEdit)
                Person = null;
                return;
            }


            DialogResult = DialogResult.OK;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
