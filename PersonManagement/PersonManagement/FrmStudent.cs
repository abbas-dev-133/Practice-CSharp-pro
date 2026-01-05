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
        public string StudentId { get; set; }
        private Student student;

        public FrmStudent()
        {
            InitializeComponent();
            studentManager = new StudentManager();
        }

        private void frmNewPerson_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(StudentId))
            {
                btnSaveAndNew.Visible = false;
                var result = studentManager.GetByStudentCode(StudentId);
                if (!result.IsSuccess)
                {
                    MessageBoxHelper.Error(result.Message);
                    Close();
                    return;
                }
                var clone = result.Data.Clone();
                txtFirstName.Text = clone.FirstName;
                txtLastName.Text = clone.LastName;
                txtNationalCode.Text = clone.NationalCode;
                txtGrade.Text = clone.Grade;
                txtStudentCode.Text = clone.StudentCode;
                txtStudentCode.Enabled = false;
                if (clone.Gender == Genders.Male) rbMale.Checked = true;
                else if (clone.Gender == Genders.Female) rbFemale.Checked = true;
                else rbUnknown.Checked = true;
                student = clone;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (student == null) student = new Student(txtStudentCode.Text);
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.NationalCode = txtNationalCode.Text;
            student.Grade = txtGrade.Text;
            if (rbMale.Checked) student.Gender = Genders.Male;
            else if (rbFemale.Checked) student.Gender = Genders.Female;
            else student.Gender = Genders.Unknown;
            OperationResult result;
            if (string.IsNullOrEmpty(StudentId))
            {
                result = studentManager.Add(student);
                if (!result.IsSuccess) { MessageBoxHelper.Error(result.Message); return; }
            }
            else
            {
                result = studentManager.Edit(student);
                if (!result.IsSuccess) { MessageBoxHelper.Error(result.Message); return; }
            }
            DialogResult = DialogResult.OK;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ') e.Handled = true;
        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
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
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
            if (DialogResult == DialogResult.OK)
            {
                Save?.Invoke(student);
                ResetFormForNewEntry();
                DialogResult = DialogResult.None;
            }
        }

        public Action<Student> Save { get; set; }
    }
}
