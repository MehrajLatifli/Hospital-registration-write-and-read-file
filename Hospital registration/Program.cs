using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_registration
{
    class Program
    {
                public delegate void DoctorDelegate();
        static void Main(string[] args)
        {

            Database database = new Database();
            DoctorDelegate dD = database.ShowDoctortoList;

            string name = "";
            string surName = "";
            decimal workexperience = 0M;

            Hospital hospital = new Hospital
            {
                HospitalName = "Hospital of Fox's family in Baku",
                HospitalAddress = "Baku, Nefchiler street",
                HospitalPhoneNumber = 0120001100,
                Time = Hospital.OpenCloseTime()

            };

            Console.WriteLine(hospital);
            for (int i = 0; i < 100; i++)
            {


                Console.Clear();
                Console.Write($@" Hospital controler 

 1 <- Admin 
 2 <- User 

 Enter: ");
                string panel = Console.ReadLine();

                if (panel == "1")
                {
                    Console.WriteLine();
                    Console.Clear();
                    Console.Write($@" Admin panel 

 1 <- Show Doctor 
 2 <- Add Doctor
 3 <- Show User

 Enter: ");
                    string adminpanel = Console.ReadLine();
                    if (adminpanel == "1")
                    {

                      


                        dD.Invoke();
                    }

                    if (adminpanel == "2")
                    {
                        dD.Invoke();

                        Console.Write($"\n Add name: ");
                        name = Console.ReadLine();

                        Console.Write($" Add surname: ");
                        surName = Console.ReadLine();



                        Console.Write($" Add experience: ");
                        workexperience = Convert.ToDecimal(Console.ReadLine());

                        database.AddDoctortoList(name, surName, workexperience);

                        database.WriteReadDoctor();
                    }

                    if (adminpanel == "3")
                    {

                        database.ShowUsertoList();
                    }

                };

                if (panel == "2")
                {
                    Console.WriteLine();
                    Console.Clear();
                    Console.Write($@" User panel 

 1 <- Show Doctor 
 2 <- Registration 

 Enter: ");
                    string userpanel = Console.ReadLine();
                    if (userpanel == "1")
                    {

                       


                        dD.Invoke();
                    }

                    if (userpanel == "2")
                    {
                        dD.Invoke();

                        string name2 = "";
                        string surName2 = "";
                        string email = "";
                        long mobile = 0;
                        string selectName = "";

                        Console.Write($"\n Add User name: ");
                        name2 = Console.ReadLine();

                        Console.Write($" Add User surname: ");
                        surName2 = Console.ReadLine();

                        Console.Write($" Add User email: ");
                        email = Console.ReadLine();

                        Console.Write($" Add mobile: ");
                        mobile = Convert.ToInt64(Console.ReadLine());

                        Console.Write($" Select doctor name: ");
                        selectName =Console.ReadLine();

                        database.AddUsertoList(name2, surName2, email, mobile, selectName);

                        database.WriteReadUser();
                       
                    }
                };





                    Console.WriteLine("\n");



              





              
               




                Console.ReadKey();
            }
        }
    }
}
