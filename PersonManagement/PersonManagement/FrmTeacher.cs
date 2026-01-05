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
    public partial class FrmTeacher : Form
    {
        TeacherManager teacherManager;
        public string MobileNumber { get; set; }
        private Teacher teacher;

        public FrmTeacher()
        {
            InitializeComponent();
            teacherManager = new TeacherManager();
        }

        private void frmNewPerson_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MobileNumber))
            {
                btnSaveAndNew.Visible = false;
                var result = teacherManager.GetByMobile(MobileNumber);
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
                txtMobile.Text = clone.Mobile;
                txtField.Text = clone.Field;
                txtAddress.Text = clone.Address;
                txtMobile.Enabled = false;
                if (clone.Gender == Genders.Male) rbMale.Checked = true;
                else if (clone.Gender == Genders.Female) rbFemale.Checked = true;
                else rbUnknown.Checked = true;
                teacher = clone;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (teacher == null) teacher = new Teacher(txtMobile.Text);
            teacher.FirstName = txtFirstName.Text;
            teacher.LastName = txtLastName.Text;
            teacher.NationalCode = txtNationalCode.Text;
            teacher.Address = txtAddress.Text;
            teacher.Mobile = txtMobile.Text;
            teacher.Field = txtField.Text;
            if (rbMale.Checked) teacher.Gender = Genders.Male;
            else if (rbFemale.Checked) teacher.Gender = Genders.Female;
            else if (rbUnknown.Checked) teacher.Gender = Genders.Unknown;
            else teacher.Gender = Genders.None;
            OperationResult result;
            if (string.IsNullOrEmpty(MobileNumber))
            {
                result = teacherManager.Add(teacher);
                if (!result.IsSuccess) { MessageBoxHelper.Error(result.Message); return; }
            }
            else
            {
                result = teacherManager.Edit(teacher);
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
            txtMobile.Clear();
            txtAddress.Clear();
            txtField.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbUnknown.Checked = false;
            teacher = null;
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            btnSaveAndClose.PerformClick();
            if (DialogResult == DialogResult.OK)
            {
                Save?.Invoke(teacher);
                ResetFormForNewEntry();
                DialogResult = DialogResult.None;
            }
        }

        public Action<Teacher> Save { get; set; }
    }
}
