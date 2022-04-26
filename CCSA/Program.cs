using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSA
{
    public class Program
    {
        bool @class=false;

        public Program(programmes program, string Days)
        {
            if (programmes.frontend == program)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (Days.Contains(((frontend)i).ToString()))
                    {
                        Console.WriteLine("\nThe facilitator will let you in shortly");
                        Thread.Sleep(5000);
                        Console.WriteLine("\nYou're In!");
                        @class = true;
                    }
                }

                    if(@class==false) { Console.WriteLine("\nNo class Today"); }
            }

            if (programmes.backend == program)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (Days.Contains(((backend)i).ToString()))
                    {
                        Console.WriteLine("\nThe facilitator will let you in shortly");
                        Thread.Sleep(5000);
                        Console.WriteLine("\nYou're in");
                        @class = true;
                    }
                }

                if (@class == false) { Console.WriteLine("\nNo class Today"); }
            }
        }
    }
}
