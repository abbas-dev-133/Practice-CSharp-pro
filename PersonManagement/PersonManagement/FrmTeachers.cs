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
    public partial class FrmTeachers : Form
    {
        TeacherManager teacherManager;
        public FrmTeachers()
        {
            InitializeComponent();
            teacherManager = new TeacherManager();
        }
        private void frmPerson_Load(object sender, EventArgs e)
        {
            FillDgv();
        }
        private void FillDgv()
        {

            dgvShowStudent.DataSource = teacherManager.GetAll().ToList();
        }
        private void SaveTeacher(Teacher teacher)
        {
            teacherManager.Add(teacher);
            FillDgv();                  
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            var frm = new FrmTeacher()
            {
                Text = "Add New Teacher",
                Save = SaveTeacher
            };

            if (frm.ShowDialog() == DialogResult.OK)
                FillDgv();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShowStudent.CurrentRow == null)
            {
                MessageBoxHelper.Error("یک ردیف را انتخاب کنید");
            }
            else
            {
                var teacherToDelete = dgvShowStudent.CurrentRow.DataBoundItem as Teacher;
                string questionText = $"آیا از حذف  {teacherToDelete.FirstName} اطمینان دارید؟";
                var result = MessageBoxHelper.Question(questionText);
                if (result == DialogResult.Yes)
                {
                    teacherManager.Remove(teacherToDelete);
                    FillDgv();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvShowStudent.CurrentRow == null)
            {
                MessageBoxHelper.Error("یک ردیف را انتخاب کنید");
            }
            else
            {
                var teacherToEdit = dgvShowStudent.CurrentRow.DataBoundItem as Teacher;
                var frm = new FrmTeacher()
                {
                    Text = "Edit Teacher",
                    teacher = teacherToEdit,
                };
                if (frm.ShowDialog() == DialogResult.OK)
                    FillDgv();
            }

        }
    }
}
