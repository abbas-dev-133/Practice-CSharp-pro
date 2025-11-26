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
        PersonManager personManager;
        public Person Person {  get; set; }
        public FrmNewPerson()
        {
            personManager = new PersonManager();
            InitializeComponent();
        }
        private void frmNewPerson_Load(object sender, EventArgs e)
        {
            if(Person!= null)
            {
                txtFirstName.Text = Person.FirstName;
                txtLastName.Text = Person.LastName;
                txtNationalCode.Text = Person.NationalCode;
                if (Person.Gender == Genders.Male)
                    rbMale.Checked = true;
                else if (Person.Gender == Genders.Female)
                    rbFemale.Checked = true;
            }
          
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isNew = true;
            if(Person== null)
                Person = new Person();
            else
            {
                isNew = false;
            }
            Person.FirstName = txtFirstName.Text;
            Person.LastName = txtLastName.Text;
            Person.NationalCode = txtNationalCode.Text;


            if (rbMale.Checked)
                Person.Gender = Genders.Male;
            else if (rbFemale.Checked)
                Person.Gender = Genders.Female;
            else
                Person.Gender = Genders.Unknown;
            if(isNew)
                personManager.AddPerson(Person);
            DialogResult = DialogResult.OK;
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
