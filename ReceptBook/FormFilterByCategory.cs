using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptBook
{
    public partial class FormFilterByCategory : Form
    {
        private BindingList<string> categoriesRecept;
        private SortedSet<string> category;

        public FormFilterByCategory()
        {
            InitializeComponent();
            categoriesRecept = new BindingList<string>();
            category = new SortedSet<string>();
        }

        private void FormFilterByCategory_Load(object sender, EventArgs e)
        {
            DBConnect.FillBindingList(ref categoriesRecept, "KATEGORIA_RECEPT", "NAME_KATEG_REC");
            comboBoxSelectedCategories.DataSource = categoriesRecept;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string nameCategory = comboBoxSelectedCategories.SelectedValue.ToString();
            DBConnect.FillDataGridViewWithReceiptsByCateg(ref dataGridView, nameCategory);
            dataGridView.Columns["col1"].Visible = false;
        }
        private int GetIdFromRow()
        {
            try
            {
                return Convert.ToInt32(dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].Cells["col1"].Value);
            }
            catch (Exception ex)
            {
                DBConnect.ShowError(ex.ToString());
                return 0;
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (ViewRecept form = new ViewRecept(GetIdFromRow()))
            {
                form.ShowDialog(this);
            }
        }
    }
}
