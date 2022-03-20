using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Sistemi
{
    class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int SectionId { get; set; }
        public int UnitId { get; set; }
        public string PicturePath { get; set; }
        public int RightAnswer { get; set; }
    }
}
