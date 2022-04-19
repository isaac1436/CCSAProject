using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSA
{
    public class BackEnd:AttendClass
    {
        public void attend(string day)
        {
            day= day.ToLower();
            bool today = false;
            for (int i = 0; i < 3; i++)
            {
                if (day == classDays[i])
                {
                    Console.WriteLine("The host will let you in shortly.....");
                    Thread.Sleep(5000);
                    Console.WriteLine("You're in!");
                    today = true;
                    break;
                }
            }
            if (today == false)
            {
                Console.WriteLine("No class today");
            }
        }
        string[] classDays = { "teusday", "monday", "thursday" };

        public BackEnd(string day)
        {
            attend(day);
        }
    }
}
