using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSA
{

    public class Student : AnswerQuestion, AskQuestion
    {
        public void Answer()
        {
            Console.WriteLine("The answer to the question is answer and additional resources can be found in your Nakov Book");
        }

        public void Ask(string Desc)
        {
            Desc = Desc.ToLower();
            if (Desc == "student")
            {
                Console.WriteLine("Please answer the question");
            }

            if (Desc == "facilitator")
            {
                Console.WriteLine("Please answer the question");
            }
        }

        public Student(int choice)
        {
            string desc = Console.ReadLine();
            if (choice == 1) { Ask(desc); }
            if (choice == 2) { Answer(); }
        }
    }
}
