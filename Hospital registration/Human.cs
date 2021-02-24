using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_registration
{
    abstract class Human
    {
        public Human(string name, string surName)
        {
            Name = name;
            SurName = surName;
        }

        public Human() {

        }
        public string Name { get; set; }
        public string SurName { get; set; }

      
       


        public abstract void HumanShow();
       

    }
}
