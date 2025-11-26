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
        PersonManager personManager;
        public FrmPerson()
        {
            InitializeComponent();
            personManager = new PersonManager();
        }
        private void frmPerson_Load(object sender, EventArgs e)
        {
            FillDgv();
        }
        public void FillDgv()
        {

            dgvShowPerson.DataSource = personManager.GetPersons().ToList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var frm = new FrmNewPerson()
            {
                Text = "Add New Person"
            };

            if (frm.ShowDialog() == DialogResult.OK)
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
                string questionText = $"آیا از حذف  {personToDelete.FirstName} اطمینان دارید؟";
                var result = AlertHelper.Question(questionText);
                if (result == DialogResult.Yes)
                {
                    personManager.RemovePerson(personToDelete);
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
                var frm = new FrmNewPerson()
                {
                    Text = "Edit Person",
                    Person = personToEdit
                };
                if (frm.ShowDialog()==DialogResult.OK)
                    FillDgv();
            }

        }
    }
}
