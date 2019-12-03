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
    public partial class FormNewRecept : Form
    {
        //private BindingList<string> categoriesIngrs; *2
        private BindingList<string> categoriesRec;
        private BindingList<string> typeCuis;
        public FormNewRecept()
        {
            InitializeComponent();
            //categoriesIngrs = new BindingList<string>(); *2
            categoriesRec = new BindingList<string>();
            typeCuis = new BindingList<string>();
        }

        private void buttonNextAddStep_Click(object sender, EventArgs e)
        {
            using (FormAddStep form = new FormAddStep())
            {
                form.ShowDialog(this);
            }
        }

        private void buttonAddRecept_Click(object sender, EventArgs e)
        {
            string nameRecept = textBoxNameR.Text;
            string discription = textBoxDiscription.Text;
            string time = textBoxTime.Text;
            string level = textBoxLevel.Text;
            string datecreat = dateTimePicker.Value.ToString("dd.MM.yyyy");
            string category = comboBoxCategory.SelectedValue.ToString();
            string photo = textBoxPhoto.Text;
            string cuisine = comboBoxCuisine.SelectedValue.ToString();

            if (DBConnect.addNewRecToListRecepts(nameRecept, discription, time, level, datecreat, category, photo, cuisine))
            {
                //MessageBox.Show("Новий інгредієнт додано. Якщо небхідно додати ще нові інгредієнти, то знову заповніть форму");
            }
            else
            {
                MessageBox.Show("Вже є цей рецепт");
            }
        }

        private void FormNewRecept_Load(object sender, EventArgs e)
        {
            DBConnect.FillBindingList(ref categoriesRec, "KATEGORIA_RECEPT", "NAME_KATEG_REC");
            comboBoxCategory.DataSource = categoriesRec;
            DBConnect.FillBindingList(ref typeCuis, "CUISINE", "NAME_CUISINE");
            comboBoxCuisine.DataSource = typeCuis;
            //*2
            //DBConnect.FillBindingList(ref categoriesIngrs, "KATEGORIA_INGREDIENT", "NAME_KATEG_INGR");
            //comboBoxIngrCategory.DataSource = categoriesIngrs;
        }
    }
}
