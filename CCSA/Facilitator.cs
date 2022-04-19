using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSA
{
    public class Facilitator : AnswerQuestion,AskQuestion
    {
        public void Answer()
        {
            Console.WriteLine("The answer to the question is answer and additional resources can be found in your Nakov Book");
        }
        
        public void Ask(string Desc)
        {
            if(Desc == "student")
            {
                Console.WriteLine("Please answer the question");
            }
        }

        public Facilitator(int choice)
        {
            string desc = Console.ReadLine();
            if(choice == 1) { Ask(desc); }
            if(choice == 2) { Answer(); }
        }
    }
}
