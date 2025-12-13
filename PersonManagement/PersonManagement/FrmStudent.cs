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
        public Student student { get; set; }
        private bool isEdit = true;
        public FrmStudent()
        {
            InitializeComponent();
            studentManager = new StudentManager();
        }
        private void frmNewPerson_Load(object sender, EventArgs e)
        {
            if (student != null)
            {
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtNationalCode.Text = student.NationalCode;
                txtGrade.Text = student.Grade;
                txtStudentCode.Text = student.StudentCode;
                if (student.Gender == Genders.Male)
                    rbMale.Checked = true;
                else if (student.Gender == Genders.Female)
                    rbFemale.Checked = true;
                else if (student.Gender == Genders.Unknown)
                    rbUnknown.Checked = true;
            }
            if (Text == "Edit Student")
            {
                btnSaveAndNew.Visible = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (student == null)
            {
                student = new Student(txtStudentCode.Text);
                isEdit = false;
            }
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.NationalCode = txtNationalCode.Text;
            student.Grade = txtGrade.Text;

            if (rbMale.Checked)
                student.Gender = Genders.Male;
            else if (rbFemale.Checked)
                student.Gender = Genders.Female;
            else if (rbUnknown.Checked)
                student.Gender = Genders.Unknown;
            else
                student.Gender = Genders.None;

            OperationResult result;
            if (!isEdit)
            {
                result = studentManager.Add(student);
            }
            else
                result = studentManager.Edit(student);

            if (!result.IsSuccess)
            {
                MessageBoxHelper.Error(result.Message);
                if (!isEdit)
                    student = null;
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
            student = null;
            isEdit = false;
        }
        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
            if(DialogResult  == DialogResult.OK)
            {
                Save?.Invoke(student);
                ResetFormForNewEntry();
                DialogResult = DialogResult.None;
            }        
        }
        public Action<Student> Save { get; set; }
    }
}
