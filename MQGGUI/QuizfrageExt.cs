using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MoodleQuizGenerator;

namespace MQGGUI
{

    class QuizfrageExt:Quizfrage
    {
        private string name;
        private string generalfeedback;
        private double defaultgrade;
        private double penalty;
        private bool hidden;
        private int idnumber;
        private bool single;

        private bool shuffleanswers;
        private string answernumbering;
        private bool showstandardinstruction;
        private Correctfeedback correctfeedback;




        public string Name { get => name; set => name = value; }
        public string Generalfeedback { get => generalfeedback; set => generalfeedback = value; }
        public double Defaultgrade { get => defaultgrade; set => defaultgrade = value; }
        public double Penalty { get => penalty; set => penalty = value; }
        public bool Hidden { get => hidden; set => hidden = value; }
        public int Idnumber { get => idnumber; set => idnumber = value; }
        public bool Single { get => single; set => single = value; }
        public bool Shuffleanswers { get => shuffleanswers; set => shuffleanswers = value; }
        public string Answernumbering { get => answernumbering; set => answernumbering = value; }
        public bool Showstandardinstruction { get => showstandardinstruction; set => showstandardinstruction = value; }
        //public string Correctfeedback { get => correctfeedback; set => correctfeedback = value; }
        
        
    }
}
