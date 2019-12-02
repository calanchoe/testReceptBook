using FirebirdSql.Data.FirebirdClient;
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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myCabinetToolStripMenuItem.Visible = false;
            userNameLabel.Visible = false;
            loginToolStripMenuItem.Visible = true;
            //FbConnection conn = DBConnect.GetConnection();
            //MessageBox.Show(conn.State.ToString());

            /* FbConnectionStringBuilder sb = new FbConnectionStringBuilder
             {
                 //DataSource = "localhost",
                 Database = "cookingDB.fdb",
                 UserID = "SYSDBA",
                 Password = "masterkey",
                 Charset = "UTF8",
                 Pooling = false,
                 ServerType = FbServerType.Embedded,
             };
             conn = new FbConnection(sb.ToString());*/

            DBConnect.getAllRecepts(ref dataGridViewAllRecepts);
            dataGridViewAllRecepts.Columns["col1"].Visible = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Authorization form = new Authorization())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    myCabinetToolStripMenuItem.Visible = true;
                    userNameLabel.Text = DBConnect.GetSessionVar("UserName")
                                         + " " + DBConnect.GetSessionVar("UserSurname");
                    userNameLabel.Visible = true;
                    loginToolStripMenuItem.Visible = false;
                    //if (form.ShowDialog(this) != DialogResult.OK)
                    //{
                    //    MessageBox.Show("Для роботи у програмі потрібно авторизуватися.");
                    //    Close();
                    //}
                    //else
                    //{
                    //    //labelGreetings.Text += DBHelper.GetSessionVar("UserSurname")
                    //    //                    + " " + DBHelper.GetSessionVar("UserName")
                    //    //                    + " " + DBHelper.GetSessionVar("UserPatronymic");
                    //    //labelUserRole.Text += DBHelper.GetSessionVar("UserRole");
                    //    //statusLabel.Text = "Готово | Користувач: " + DBHelper.GetSessionVar("UserLogin");
                    //}
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBConnect.RemoveSessionAll();
            Form1_Load(sender, e);
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Filter form = new Filter())
            {
                form.ShowDialog(this);
            }
        }

        private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormMyFavorites form = new FormMyFavorites())
            {
                form.ShowDialog(this);
            }
        }
        private int GetIdFromRow()
        {
            try
            {
                return Convert.ToInt32(dataGridViewAllRecepts.Rows[dataGridViewAllRecepts.SelectedCells[0].RowIndex].Cells["col1"].Value);
            }
            catch (Exception ex)
            {
                DBConnect.ShowError(ex.ToString());
                return 0;
            }

        }
        private void dataGridViewAllRecepts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (ViewRecept form = new ViewRecept(GetIdFromRow()))
            {
                form.ShowDialog(this);
            }
        }

        private void CatalogyByReceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormFilterByCategory form = new FormFilterByCategory())
            {
                form.ShowDialog(this);
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormForAdminUsers form = new FormForAdminUsers())
            {
                form.ShowDialog(this);
            }
        }

        private void receptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormForAdminRecept form = new FormForAdminRecept())
            {
                form.ShowDialog(this);
            }
        }
    }
}
