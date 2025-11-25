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
        public List<Person> persons = new List<Person>();
        public FrmPerson()
        {
            InitializeComponent();
        }

        public void FillDgv()
        {
            dgvShowPerson.DataSource = null;
            dgvShowPerson.DataSource = persons.ToList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var frm = new FrmNewPerson();
            frm.Text = "Insert New Person";
            frm.ShowDialog();
            FillDgv();


        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            FillDgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShowPerson.CurrentRow == null)
            {
                AlertHelper.Eror("یک ردیف را انتخاب کنید");
            }
            else
            {
                var personToDelete = dgvShowPerson.CurrentRow.DataBoundItem as Person;
                string questionText = $"آیا از حذف  {personToDelete.Name} اطمینان دارید؟";
                var result = AlertHelper.Question(questionText);
                if (result == DialogResult.Yes)
                {
                    persons.Remove(personToDelete);
                    FillDgv();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvShowPerson.CurrentRow == null)
            {
                AlertHelper.Eror("یک ردیف را انتخاب کنید");
            }
            else
            {
                var personToEdit = dgvShowPerson.CurrentRow.DataBoundItem as Person;
                var frm = new FrmNewPerson(personToEdit);
                frm.Text = "Edit Person";



                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                    FillDgv();
            }

        }
    }
}
