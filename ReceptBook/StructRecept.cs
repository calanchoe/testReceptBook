using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptBook
{
    public class Recept
    {
        public string NameText { get; set; }
        public string DescriptionText { get; set; }
        public string LevelText { get; set; }
        public string TimeText { get; set; }
        public string CategText { get; set; }
        public string CreateDateText { get; set; }
        public string PicturePath { get; set; }
        public Dictionary<string, string> IngrsCols { get; set; }
        public List<string[]> IngrsData { get; set; }
        public Dictionary<string, string> StepsCols { get; set; }
        public List<string[]> StepsData { get; set; }

        public Recept()
        {
            //Recept dataRecept = new Recept

            NameText = "";
            DescriptionText = "";
            LevelText = "";
            TimeText = "";
            CategText = "";
            CreateDateText = "";
            PicturePath = "";
            IngrsCols = new Dictionary<string, string>();
            IngrsData = new List<string[]>();
            StepsCols = new Dictionary<string, string>();
            StepsData = new List<string[]>();
        }
    }

    

}
