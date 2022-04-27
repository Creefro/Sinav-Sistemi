using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    class SoruOluşturucu : QuestionCreator
    {
        //Concreate Factory
        Questions question = new Questions();
        public override ISoru SoruOluştur(string text,int sectionId,int unitId,string picturePath,string rightAnswer,string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        {
            question.QuestionText = text;
            question.SectionId = sectionId;
            question.UnitId = unitId;
            question.PicturePath = picturePath;
            question.RightAnswer = rightAnswer;
            question.WrongAnswer1 = wrongAnswer1;
            question.WrongAnswer2 = wrongAnswer2;
            question.WrongAnswer3 = wrongAnswer3;

            return question;
        }
    }
}
