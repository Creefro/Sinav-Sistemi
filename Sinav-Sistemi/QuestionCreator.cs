using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    abstract class QuestionCreator
    {
        //Factory
        public abstract ISoru SoruOluştur(string text, int sectionId, int unitId, string picturePath, string rightAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3);
        public bool SoruyuKaydet(string text, int sectionId, int unitId, string picturePath, string rightAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        {
            //soruyu oluşturur
            var product = SoruOluştur(text, sectionId, unitId, picturePath, rightAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3);
            
            var result = product.InsertQuestion(product);
            
            return result;
        }
    }
}
