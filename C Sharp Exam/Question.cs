using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exam
{
    internal abstract class Question
    {
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Marks { get; set; }

     
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }
       
        public Question()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }
     
        public abstract void AddQuestion();
        public override string ToString()
        {
            return $"{Header} \t Mark({Marks})\n" +
                "-------------------------------------" +
                $" \n{Body}\n";
        }
    }
}
