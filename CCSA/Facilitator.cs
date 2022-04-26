using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSA
{
    public class Facilitator : Human
    {
        public override void Answer()
        {
            Console.WriteLine("The answer to the question is answer and additional resources can be found in your Nakov Book");
        }

        public override void Ask()
        {
            Console.WriteLine("Please answer the question");
        }

    }
}
