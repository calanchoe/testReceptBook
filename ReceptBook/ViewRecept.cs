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
        private int receptId { get; set; }
        public ViewRecept()
        {
            InitializeComponent();

            int IdRecept;
        }


        public ViewRecept(int receptId)
        {
            InitializeComponent();
            receptId = receptId;
        }
        private void ViewRecept_Load(object sender, EventArgs e)
        {

        }
    }
}
