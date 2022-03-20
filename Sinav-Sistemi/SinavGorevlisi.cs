using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    class SinavGorevlisi:User
    {
        public Question question;
        public SinavGorevlisi()
        {
            question = new Question();
        }

        public void SoruOlustur()
        {
            question.QuestionId =1;
        }
    }
}
