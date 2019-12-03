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
    public partial class FormNewIngr : Form
    {
        private BindingList<string> categoriesIngrs;
        public FormNewIngr()
        {
            InitializeComponent();
            categoriesIngrs = new BindingList<string>();
        }

        private void FormNewIngr_Load(object sender, EventArgs e)
        {
            DBConnect.getAllIngr(ref dataGridViewAllIngr);

            DBConnect.FillBindingList(ref categoriesIngrs, "KATEGORIA_INGREDIENT", "NAME_KATEG_INGR");
            comboBoxIngrCategory.DataSource = categoriesIngrs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FormNewRecept form = new FormNewRecept())
            {
                form.ShowDialog(this);
            }  
        }

        private void buttonNewIngr_Click(object sender, EventArgs e)
        {
            string nameIngr = textBoxNameIngr.Text;
            string nameCategory = comboBoxIngrCategory.SelectedValue.ToString();
            
            if (DBConnect.addIngrToListIngrs(nameIngr, nameCategory))
            {
                MessageBox.Show("Новий інгредієнт додано. Якщо небхідно додати ще нові інгредієнти, то знову заповніть форму");
            }
            else
            {
                MessageBox.Show("Вже є цей інгредієнт");
            }
        }
    
    }
}
