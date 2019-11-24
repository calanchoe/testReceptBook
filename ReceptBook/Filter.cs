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
    public partial class Filter : Form
    {
        private static BindingList<string> categoriesIngr;
        private static BindingList<string> allIngrsOfCategory;
        private static SortedSet<string> uniqIngridients;

        public Filter()
        {
            InitializeComponent();
            categoriesIngr = new BindingList<string>();
            allIngrsOfCategory = new BindingList<string>();
            uniqIngridients = new SortedSet<string>();
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            DBConnect.FillBindingList(ref categoriesIngr, "KATEGORIA_INGREDIENT", "NAME_KATEG_INGR");
            comboBoxSelectCategory.DataSource = categoriesIngr;
        }

        private void comboBoxSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnect.FillIngrOfCategoryBindingList(ref allIngrsOfCategory,
                comboBoxSelectCategory.SelectedItem.ToString());
            listBoxIngredientsOfCategory.DataSource = allIngrsOfCategory;
        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            uniqIngridients.Add(listBoxIngredientsOfCategory.SelectedItem.ToString());
            listBoxReceptByIngredients.DataSource = uniqIngridients.ToList();
        }

        private void buttonDelIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                uniqIngridients.Remove(listBoxReceptByIngredients.SelectedItem.ToString());
                listBoxReceptByIngredients.DataSource = uniqIngridients.ToList();
            }
            catch(Exception ex)
            {
                DBConnect.ShowError(ex.ToString());
            }
        }

        private void buttonFindRecepts_Click(object sender, EventArgs e)
        {
            DBConnect.FillDataGridViewWithReceipts(ref dataGridView, uniqIngridients.ToList());
        }
    }
}
