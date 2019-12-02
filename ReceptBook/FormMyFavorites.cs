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
    public partial class FormMyFavorites : Form
    {
        public FormMyFavorites()
        {
            InitializeComponent();
        }

        private void FormMyFavorites_Load(object sender, EventArgs e)
        {
            DBConnect.getAllRecepts(ref dataGridViewFavRecept);
            dataGridViewFavRecept.Columns["col1"].Visible = false;
        }


        private int GetIdFromRow()
        {
            try
            {
                return Convert.ToInt32(dataGridViewFavRecept.Rows[dataGridViewFavRecept.SelectedCells[0].RowIndex].Cells["col1"].Value);
            }
            catch (Exception ex)
            {
                DBConnect.ShowError(ex.ToString());
                return 0;
            }

        }
        private void dataGridViewFavRecept_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (ViewRecept form = new ViewRecept(GetIdFromRow()))
            {
                form.ShowDialog(this);
            }
        }
    }
}
