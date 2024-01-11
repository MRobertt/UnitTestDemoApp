using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsClassLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TimeOfDay { get; set; }

        public string Greet(string lastName, int time)
        {
            string output;

            TimeOfDay = time;

            if (TimeOfDay < 12)
            {
                output = $"Good morning {lastName}";
            }
            else if (TimeOfDay < 18)
            {
                output = $"Good evening {lastName}";
            }
            else
            {
                output = $"Good night {lastName}";
            }
            return output;
        }
    }
}
