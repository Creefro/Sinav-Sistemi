using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    public abstract class ISoru
    {
        //Question product
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int SectionId { get; set; }
        public int UnitId { get; set; }
        public string PicturePath { get; set; }
        public string RightAnswer { get; set; }
        public string WrongAnswer1 { get; set; }
        public string WrongAnswer2 { get; set; }
        public string WrongAnswer3 { get; set; }
        public int AdminOnay { get; set; }

         public abstract bool InsertQuestion(ISoru question);
    }
}
