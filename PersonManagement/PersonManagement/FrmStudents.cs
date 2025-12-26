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
    public partial class FrmStudents : Form
    {
        StudentManager studentManager;
        public FrmStudents()
        {
            InitializeComponent();
            studentManager = new StudentManager();
        }
        private void frmPerson_Load(object sender, EventArgs e)
        { 
            FillDgv();
        }
        private void FillDgv()
        {
            dgvShowStudent.DataSource = studentManager.GetAll().ToList();
        }
        private void SaveStudent(Student student)
        {
            studentManager.Add(student);
            FillDgv();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            var frm = new FrmStudent()
            {
                Text = "Add New Student",
                Save = SaveStudent,
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
                var studentToDelete = dgvShowStudent.CurrentRow.DataBoundItem as Student;
                string questionText = $"آیا از حذف  {studentToDelete.FirstName} اطمینان دارید؟";
                var result = MessageBoxHelper.Question(questionText);
                if (result == DialogResult.Yes)
                {
                    studentManager.Remove(studentToDelete);
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
                var studentToEdit = dgvShowStudent.CurrentRow.DataBoundItem as Student;
                var frm = new FrmStudent()
                {
                    Text = "Edit Student",
                    studentId = studentToEdit.StudentCode
                };
                if (frm.ShowDialog() == DialogResult.OK)
                    FillDgv();
            }

        }
    }
}
