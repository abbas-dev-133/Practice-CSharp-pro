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
        public string MobileNumber {  get; set; }
        private Teacher teacherToEdit;
        private Teacher editedTeacher;
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

                teacherToEdit = result.Data;
                var clone = teacherToEdit.Clone();

                txtFirstName.Text = clone.FirstName;
                txtLastName.Text = clone.LastName;
                txtNationalCode.Text = clone.NationalCode;
                txtMobile.Text = clone.Mobile;
                txtField.Text = clone.Field;
                txtAddress.Text = clone.Address;
                txtMobile.Enabled = false;
                if (clone.Gender == Genders.Male)
                    rbMale.Checked = true;
                else if (clone.Gender == Genders.Female)
                    rbFemale.Checked = true;
                else if (clone.Gender == Genders.Unknown)
                    rbUnknown.Checked = true;
                editedTeacher = clone;

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editedTeacher == null)
                editedTeacher = new Teacher(txtMobile.Text);
            editedTeacher.FirstName = txtFirstName.Text;
            editedTeacher.LastName = txtLastName.Text;
            editedTeacher.NationalCode = txtNationalCode.Text;
            editedTeacher.Address = txtAddress.Text;
            editedTeacher.Mobile = txtMobile.Text;
            editedTeacher.Field = txtField.Text;

            if (rbMale.Checked)
                editedTeacher.Gender = Genders.Male;
            else if (rbFemale.Checked)
                editedTeacher.Gender = Genders.Female;
            else if (rbUnknown.Checked)
                editedTeacher.Gender = Genders.Unknown;
            else
                editedTeacher.Gender = Genders.None;

            OperationResult result;
            if (teacherToEdit == null)
            {
                result = teacherManager.Add(editedTeacher);
                if (!result.IsSuccess)
                {
                    MessageBoxHelper.Error(result.Message);
                    return;
                }
                teacherToEdit = editedTeacher;
            }
            else
            {

                result = teacherManager.Edit(editedTeacher);
                if (!result.IsSuccess)
                {
                    MessageBoxHelper.Error(result.Message);
                    return;
                }
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
            txtMobile.Clear();
            txtAddress.Clear();
            txtField.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbUnknown.Checked = false;
        }
        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            btnSaveAndClose.PerformClick();
            if (DialogResult == DialogResult.OK)
            {
                Save?.Invoke(teacherToEdit);
                ResetFormForNewEntry();
                DialogResult = DialogResult.None;
            }
        }
        public Action<Teacher> Save { get; set; }
    }
}
