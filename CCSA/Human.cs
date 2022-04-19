using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSA
{
    public interface AnswerQuestion
    {
        public void Answer();
    }

    public interface AskQuestion
    {
        public void Ask(string Description);
    }

    public interface AttendClass
    {
        public void attend(string currDay);
    }

    public class Human
    {
        public string Name { get; set; }

        public string Description { get { return Description; } set { } }


        public Human(string name, String Description)
        {
            this.Name = name;
            this.Description = Description;
        }

      
    }
}

