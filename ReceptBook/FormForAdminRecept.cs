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
    public partial class FormForAdminRecept : Form
    {
        public FormForAdminRecept()
        {
            InitializeComponent();
        }

        private void FormForAdminRecept_Load(object sender, EventArgs e)
        {
            DBConnect.getAllRecepts(ref dataGridViewAllRecepts);
            dataGridViewAllRecepts.Columns["col1"].Visible = false;
        }
    }
}
