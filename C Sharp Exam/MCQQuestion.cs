﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exam
{
    internal class MCQQuestion : Question
    {
        public override string Header => "MCQ Question";

        public MCQQuestion()
        {
            AnswerList = new Answer[3];
        }



        public override void AddQuestion()
        {
            Console.WriteLine(Header);



            Console.WriteLine("Please Enter Body Of Question :");
            Body = Console.ReadLine();


            int mark;
            do
            {
                Console.WriteLine("Please Enter Mark Of Question : ");
            } while (!int.TryParse(Console.ReadLine(), out mark));
            Marks = mark;

            Console.WriteLine("The Choices of Question:");

            for (int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answer
                {
                    AnswerId = i + 1
                };

                Console.Write($"Please Enter choise number {i + 1} : ");
                AnswerList[i].AnswerText = Console.ReadLine();
            }

            int RightAnswerId;
            do
            {
                Console.WriteLine("Please Specify The Right Choice of Question: ");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) && RightAnswerId < 1 || RightAnswerId > 3);

            RightAnswer.AnswerId = RightAnswerId;
            RightAnswer.AnswerText = AnswerList[RightAnswerId - 1].AnswerText;
            Console.Clear();
        }
    }
}
