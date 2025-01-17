﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exam
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
    
        public Answer(int answerID, string answerText)
        {
            AnswerId = answerID;
            AnswerText = answerText;
        }

        public Answer()
        {

        }
   
        public override string ToString()
        {
            return $"{AnswerId} _ {AnswerText}";
        }

    }
}
