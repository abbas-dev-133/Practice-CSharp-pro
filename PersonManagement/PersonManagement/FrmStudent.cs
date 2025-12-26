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
    public partial class FrmStudent : Form
    {
        StudentManager studentManager;
        public string studentId { get; set; }
        private Student studentToEdit;
        public FrmStudent()
        {
            InitializeComponent();
            studentManager = new StudentManager();
        }
        private void frmNewPerson_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(studentId))
            {
                btnSaveAndNew.Visible = false;
                studentToEdit = studentManager.Get(studentId);
                txtFirstName.Text = studentToEdit.FirstName;
                txtLastName.Text = studentToEdit.LastName;
                txtNationalCode.Text = studentToEdit.NationalCode;
                txtGrade.Text = studentToEdit.Grade;
                txtStudentCode.Text = studentToEdit.StudentCode;
                txtStudentCode.Enabled = false;
                if(studentToEdit.Gender== Genders.Male)
                    rbMale.Checked = true;
                else if(studentToEdit.Gender== Genders.Female)
                    rbFemale.Checked = true;
                else if(studentToEdit.Gender==Genders.Unknown)
                    rbUnknown.Checked = true;
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (studentToEdit == null)
                studentToEdit = new Student(txtStudentCode.Text);
            studentToEdit.FirstName = txtFirstName.Text;
            studentToEdit.LastName = txtLastName.Text;
            studentToEdit.Grade = txtGrade.Text;
            studentToEdit.NationalCode = txtNationalCode.Text;
            if(rbMale.Checked) studentToEdit.Gender = Genders.Male;
            else if (rbFemale.Checked) studentToEdit.Gender = Genders.Female;
            else if (rbUnknown.Checked) studentToEdit.Gender = Genders.Unknown;
            OperationResult result;
            if (string.IsNullOrEmpty(studentId))
                result = studentManager.Add(studentToEdit);
            else
                result = studentManager.Edit(studentToEdit);

            if (!result.IsSuccess)
            {
                MessageBoxHelper.Error(result.Message);
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
        private void ResetFormForNewEntry()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNationalCode.Clear();
            txtStudentCode.Clear();
            txtGrade.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbUnknown.Checked = false;
        }
        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
           
            if (DialogResult == DialogResult.OK)
            {
                Save?.Invoke(studentToEdit);
                ResetFormForNewEntry();
                DialogResult = DialogResult.None;
            }
        }
        public Action<Student> Save { get; set; }
    }
}
