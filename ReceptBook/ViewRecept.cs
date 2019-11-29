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
            labelDiscription.Text = recept.DescriptionText;
            labelCateg.Text = recept.CategText;
            labelDate.Text = recept.CreateDateText;
            labelLevel.Text = recept.LevelText;
            labelTime.Text = recept.TimeText;
            //dataGridViewStepsOfRecept.Columns.Add();
            //dataGridViewStepsOfRecept.Rows
            foreach(KeyValuePair<string, string> pair in recept.StepsCols)
            {
                dataGridViewStepsOfRecept.Columns.Add(pair.Key, pair.Value);
            }
            //foreach(KeyValuePair<string, string[]> pair in recept.StepsData)
            //{
            //    dataGridViewStepsOfRecept.Rows.Add(pair.Key, pair.Value);
            //}
        }
        private void ViewRecept_Load(object sender, EventArgs e)
        {

        }

        private void buttonLike_Click(object sender, EventArgs e)
        {

        }

    }
}
