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
            FillDatafiels(receptId);
        }
        private void FillDatafiels(int receptId)
        {
            Recept recept = DBConnect.GetRecept(receptId);
            labelNameRecept.Text = recept.NameText;
            //pictureBoxReceptMain.
            
            richTextBoxDiscription.Text = recept.DescriptionText;
            labelCateg.Text = recept.CategText;
            labelDate.Text = recept.CreateDateText;
            labelLevel.Text = recept.LevelText;
            labelTime.Text = recept.TimeText;
            foreach (KeyValuePair<string, string> pair in recept.IngrsCols)
            {
                dataGridViewIngredientsForRecept.Columns.Add(pair.Key, pair.Value);
            }

            foreach (string[] row in recept.IngrsData)
            {
                dataGridViewIngredientsForRecept.Rows.Add(row[0], row[1], row[2]);
            }
            //dataGridViewStepsOfRecept.Columns.Add();
            //dataGridViewStepsOfRecept.Rows
            foreach (KeyValuePair<string, string> pair in recept.StepsCols)
            {
                dataGridViewStepsOfRecept.Columns.Add(pair.Key, pair.Value);
            }

            foreach (string[] row in recept.StepsData)
            {
                dataGridViewStepsOfRecept.Rows.Add(row[0], row[1]);
            }
            pictureBoxReceptMain.Load(recept.PicturePath);

        }
        private void ViewRecept_Load(object sender, EventArgs e)
        {
            if (DBConnect.GetLikes(ReceptId) >= (-1))
            {
                string likes = Convert.ToString(DBConnect.GetLikes(ReceptId));
                labelCountLikes.Text = likes;
                
            }
            
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            //ReceptId = receptId;
            //var userId =
            if (DBConnect.addReceptToFavorites(ReceptId))
            {
                buttonLike.Text = "Сподобалось =)";
                //MessageBox.Show("Ви зареєстровані! Тепер перейдіть на вкладку авторізації.");
                int likescount = Convert.ToInt32(labelCountLikes.Text);
                int newlikescount = likescount + 1;
                labelCountLikes.Text = Convert.ToString(newlikescount);

            }
            else
            {
                MessageBox.Show("Ви вже додалі цей рецепт до обраного");
            }
        }

    }
}
