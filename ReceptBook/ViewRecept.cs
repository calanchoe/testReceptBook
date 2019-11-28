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
    public partial class ViewRecept : Form
    {
        private int ReceptId { get; set; }
        public ViewRecept()
        {
            InitializeComponent();

        }


        public ViewRecept(int receptId)
        {
            InitializeComponent();
            ReceptId = receptId;
        }
        private void ViewRecept_Load(object sender, EventArgs e)
        {

        }

        private void buttonLike_Click(object sender, EventArgs e)
        {

        }
    }
}
