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
    public partial class FormForAdminUsers : Form
    {
        public FormForAdminUsers()
        {
            InitializeComponent();
        }

        private void FormForAdminUsers_Load(object sender, EventArgs e)
        {
            DBConnect.getAllUsers(ref dataGridViewAllUsers);
            dataGridViewAllUsers.Columns["col1"].Visible = false;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            //var test = Convert.ToInt32(dataGridViewAllUsers.SelectedRows[0].Cells["col1"].Value);
            //int n = int.Parse(dataGridViewAllUsers.CurrentRow.Cells[0].Value.ToString());
            int userId = Convert.ToInt32(dataGridViewAllUsers.SelectedRows[0].Cells["col1"].Value);
            DBConnect.deleteUser(userId);
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            dataGridViewAllUsers.Rows.Clear();
            dataGridViewAllUsers.Columns.Clear();
            DBConnect.getAllUsers(ref dataGridViewAllUsers);
            dataGridViewAllUsers.Columns["col1"].Visible = false;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            using (FormAddUser form = new FormAddUser())
            {
                form.ShowDialog(this);
            }
        }


        //private int GetIdFromRow()
        //{
        //    try
        //    {
        //        return Convert.ToInt32(dataGridViewAllUsers.Rows[dataGridViewAllUsers.SelectedCells[0].RowIndex].Cells["col1"].Value);
        //    }
        //    catch (Exception ex)
        //    {
        //        DBConnect.ShowError(ex.ToString());
        //        return 0;
        //    }
        //}
    }
}
