using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_registration
{
    class User : Human
    {
        public User()
        {
            ID = User_id++;
        }
        public string Email { get; set; }
        public long Mobile { get; set; }

        public DateTime RegTime { get; set; }
        public int ID { get; set; }

        public  string SelectDoctorname { get; set; }
        public static int User_id { get; set; } = 1;


      
     
        public override void HumanShow()
        {
           
           



                Console.WriteLine(" \n ==== User ============================== ");
                Console.WriteLine($" \n User's ID: \t {ID}");
                Console.WriteLine($" User's name: \t\t {Name}");
                Console.WriteLine($" User's surname: \t {SurName}");
                Console.WriteLine($" User's email: \t\t {Email}");
                Console.WriteLine($" User's mobile: \t {Mobile} ");
                Console.WriteLine($" User's Registration time: \t {RegTime} \n");
                Console.WriteLine($" User's choose Doctor: \t {SelectDoctorname} \n");
                Console.WriteLine(" ========================================== \n");

            
        }
    }
}
