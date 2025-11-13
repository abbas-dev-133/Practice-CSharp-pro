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
    public partial class frmPerson : Form
    {
        public List<Person> people = new List<Person>();
        public frmPerson()
        {
            InitializeComponent();
        }

        public void FillDGV()
        {
            dgvShowPerson.DataSource = null;
            dgvShowPerson.DataSource = people.ToList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var frm = new frmNewPerson();
            frm.Text = "Insert New Person";
            frm.ShowDialog();
            FillDGV();


        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShowPerson.CurrentRow != null)
            {
                var personToDelete = dgvShowPerson.CurrentRow.DataBoundItem as Person;
                var result = MessageBox.Show(
                $"آیا میخواهید {personToDelete.Name} را حذف کنید؟",
                 "تایید حذف",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
                 );
                if (result== DialogResult.Yes)
                {
                    people.Remove(personToDelete);
                    FillDGV();
                }
                else
                   MessageBox.Show("یک ردیف را انتخاب کنید", "خطا"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }
    }
}
