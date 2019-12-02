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
    }
}
