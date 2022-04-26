using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSA
{
    public class Student : Human
    {
        public override void Answer()
        {
            Console.WriteLine("The answer to the question is answer and additional resources can be found in your Nakov Book");
        }

        public override void Ask()
        {
            Console.Write("Would you like to ask a student or Facilitator: ");
            string Desc = Console.ReadLine();
            if (Desc == "student")
            {
                Console.WriteLine("Please answer the question");
            }

            if (Desc == "facilitator")
            {
                Console.WriteLine("Please answer the question");
            }
        }
        
    }
}
