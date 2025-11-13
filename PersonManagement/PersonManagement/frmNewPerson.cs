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
        public frmNewPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var people = new Person();
            people.Name= txtName.Text;
            people.FamilyName= txtFamilyName.Text;
            people.NationalCode= txtNationalCode.Text;
            if (rbMale.Checked)
                people.Gender = "Male";
            else 
                if (rbFemale.Checked)
                    people.Gender= "Female";
            else
                people.Gender= "Unknown";

            var frmPerson = Application.OpenForms["frmPerson"] as frmPerson;
            frmPerson.people.Add(people);
            this.Close();



        }

       
    }
}
