using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagement
{
    public static class DgvExtentions
    {
        public static void BuildColumns<T>(this DataGridView dgv)
        {
            var properties = typeof(T).GetProperties();
            dgv.Columns.Clear();

            foreach (var p in properties)
            {
                var attr = p.GetCustomAttribute<DgvDisplayNameAttribute>(true);
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = p.Name,
                    HeaderText = attr == null ? p.Name : attr.DisplayName,
                    Name = p.Name
                });

                dgv.Columns[p.Name].Visible = attr != null;
            }
        }
    }
}
