using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Hospital_registration
{
    class Database
    {
        List<User> users = new List<User>();
        List<Doctor> doctors2 = new List<Doctor>();
        List<Doctor> doctors3 = new List<Doctor>();

        public void ListDoctor() { }


        List<Doctor> doctors = new List<Doctor>();





        static string Departmentchoose(string workerdepartment)
        {
            return $"{workerdepartment}";
        }



        static DateTime RegTimeBlock(DateTime regtime)
        {
            return regtime;
        }






        public void AddDoctortoList(string name, string surName, decimal workexperience)
        {
            Console.Write($@" 
 1 <- Pediatriya 
 2 <- Travmatologiya 



");
            Console.Write($"\n Add Department: ");
            string choose = Console.ReadLine();

            if (choose == "1")
            {



                doctors.Add(new Doctor()
                {
                    Name = name,
                    SurName = surName,
                    Workexperience = workexperience,
                    Workerdepartment = Departmentchoose(Department.Pediatriya),



                });





            }

            if (choose == "2")
            {
                doctors.Add(new Doctor()
                {
                    Name = name,
                    SurName = surName,
                    Workexperience = workexperience,
                    Workerdepartment = Departmentchoose(Department.Travmatologiya)
                });
            }



        }

        public void ShowDoctortoList()
        {





            foreach (var item in doctors)
            {
                item.HumanShow();
                item.WorkerShow();


                item.DoctorTimeShow();

            }





        }




        static DateTime RegTimechoose(DateTime regtime)
        {
            return regtime;
        }


        int counteruser = 2;
        int counteruser2 = 2;
        public void AddUsertoList(string name, string surName, string email, long mobile, string selectName)
        {

            Console.Write($@" 
 1 <- 09:00 
 2 <- 09:30 
 




");


            Console.Write($"\n Add Time: ");
            string chooseTime = Console.ReadLine();



            if (chooseTime == "1")
            {
                for (int i = 0; i < counteruser; i++)
                {
                    counteruser--;


                    if (counteruser != 0)
                    {





                        users.Add(new User()
                        {
                            Name = name,
                            SurName = surName,
                            Email = email,
                            Mobile = mobile,
                            SelectDoctorname = selectName,
                            RegTime = RegTimechoose(RegistrationTime.time1)

                        }); ;



                        doctors2 = doctors.Where(c => c.DoctorRegTime == default || c.DoctorRegTime == RegTimechoose(RegistrationTime.time2)).ToList();
                        doctors2.ForEach(c => c.DoctorRegTime = RegTimechoose(RegistrationTime.time1));

                        



                    }
                }

                if (counteruser <= 0)
                {
                    Console.WriteLine(" This time is rezerving.");
                }

            }




            if (chooseTime == "2")
            {
                for (int i = 0; i < counteruser2; i++)
                {
                    counteruser2--;


                    if (counteruser2 != 0)
                    {

                        users.Add(new User()
                        {
                            Name = name,
                            SurName = surName,
                            Email = email,
                            Mobile = mobile,
                            SelectDoctorname = selectName,
                            RegTime = RegTimechoose(RegistrationTime.time2),
                        });



                        doctors3 = doctors.Where(c => c.DoctorRegTime == RegTimechoose(RegistrationTime.time1) || c.DoctorRegTime == default).ToList();
                        doctors3.ForEach(c => c.DoctorRegTime = RegTimechoose(RegistrationTime.time2));

                    }

                }

                if (counteruser2 <= 0)
                {
                    Console.WriteLine(" This time is rezerving.");
                }
            }






        }

        public void ShowUsertoList()
        {

            foreach (var item in users)
            {
                item.HumanShow();

            }
        }

        public void WriteReadDoctor()
        {
            using (var writer = new XmlTextWriter("doctor.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();

                writer.WriteStartElement("Doctor");

                foreach (var d in doctors)
                {
                    writer.WriteStartElement("Doctor");

                    writer.WriteAttributeString(nameof(d.ID), d.ID.ToString());
                    writer.WriteAttributeString(nameof(d.Name), d.Name);
                    writer.WriteAttributeString(nameof(d.SurName), d.SurName.ToString());
                    writer.WriteAttributeString(nameof(d.Workexperience), d.Workexperience.ToString());
                    writer.WriteAttributeString(nameof(d.Workerdepartment), d.Workerdepartment);
                    writer.WriteAttributeString(nameof(d.DoctorRegTime), d.DoctorRegTime.ToString());

                    writer.WriteEndElement();
                }


                writer.WriteEndElement();

                writer.WriteEndDocument();
            }

            XmlDocument doc = new XmlDocument();
            doc.Load("doctor.xml");
            var root = doc.DocumentElement;

            if (root.HasChildNodes)
            {
                foreach (XmlNode doctor_node in root.ChildNodes)
                {
                    var d = new Doctor
                    {
                        ID = int.Parse(doctor_node.Attributes[0].Value),
                        Name = doctor_node.Attributes[1].Value,
                        SurName = doctor_node.Attributes[2].Value,
                        Workexperience = decimal.Parse(doctor_node.Attributes[3].Value),
                        Workerdepartment = doctor_node.Attributes[4].Value,
                        DoctorRegTime = DateTime.Parse(doctor_node.Attributes[5].Value),

                    };

                    d.HumanShow();
                    d.WorkerShow();
                    d.DoctorTimeShow();
                }
            }



        }

        public void WriteReadUser()
        {
            using (var writer = new XmlTextWriter("user.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();

                writer.WriteStartElement("User");

                foreach (var u in users)
                {
                    writer.WriteStartElement("User");

                    writer.WriteAttributeString(nameof(u.ID), u.ID.ToString());
                    writer.WriteAttributeString(nameof(u.Name), u.Name);
                    writer.WriteAttributeString(nameof(u.SurName), u.SurName);
                    writer.WriteAttributeString(nameof(u.Email), u.Email);
                    writer.WriteAttributeString(nameof(u.Mobile), u.Mobile.ToString());
                    writer.WriteAttributeString(nameof(u.RegTime), u.RegTime.ToString());
                    writer.WriteAttributeString(nameof(u.SelectDoctorname), u.SelectDoctorname);

                    writer.WriteEndElement();
                }


                writer.WriteEndElement();

                writer.WriteEndDocument();
            }

            XmlDocument doc = new XmlDocument();
            doc.Load("user.xml");
            var root = doc.DocumentElement;

            if (root.HasChildNodes)
            {
                foreach (XmlNode user_node in root.ChildNodes)
                {
                    var u = new User
                    {
                        ID = int.Parse(user_node.Attributes[0].Value),
                        Name = user_node.Attributes[1].Value,
                        SurName = user_node.Attributes[2].Value,
                        Email = user_node.Attributes[3].Value,
                        Mobile= long.Parse(user_node.Attributes[4].Value),
                        RegTime = DateTime.Parse(user_node.Attributes[5].Value),
                        SelectDoctorname = user_node.Attributes[6].Value

                    };

                    u.HumanShow();
                 
                }
            }



        }

    }
}

