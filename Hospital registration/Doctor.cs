using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_registration
{
    [Serializable]
    class Doctor : Human, I_Worker
    {
        public decimal Workexperience { get; set ; }
        public string Workerdepartment { get; set; }

         static DateTime Blocktime ;


        public   int ID { get; set; }
        public  static int Doctor_id { get; set; } = 1;

        public DateTime DoctorRegTime { get; set; } = default;

        public Doctor()
        {
            ID = Doctor_id++;
        }

       
            public Doctor(string name, string surname, decimal workexperience, string workerdepartment):base(name,surname)
        {
            Workexperience = workexperience;
            Workerdepartment = workerdepartment;
        }

        public static int ID2 { get; set; }

        public override void HumanShow()
        {
         

                    Console.WriteLine(" \n ==== Doctor ============================== ");
                    Console.WriteLine($" \n Doctor's ID: \t {ID}");
                    Console.WriteLine($" Doctor's name: \t {Name}");
                    Console.WriteLine($" Doctor's surname: \t {SurName}");
        }
    

        public  void WorkerShow()
        {
           


            Console.WriteLine($" Doctor's experience: \t {Workexperience}");
            Console.WriteLine($" Doctor's department: \t {Workerdepartment} \n");
           
        }

  
        public void DoctorTimeShow()
        {
            Console.WriteLine($" Doctor's Registration time: \t {DoctorRegTime} \n");
            Console.WriteLine(" ========================================== \n");
        }
    }
}
