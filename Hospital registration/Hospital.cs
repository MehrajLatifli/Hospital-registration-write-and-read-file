using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_registration
{
    class Hospital
    {
 

        public Hospital() 
        { 
        
        }

        public string HospitalName { get; set; }

        public string HospitalAddress { get; set; }

        public int HospitalPhoneNumber { get; set; }

        public string Time { get; set; }

        public static string OpenCloseTime()
        {
            DateTime openTime = new DateTime(01, 02, 01, 09, 00, 00);
            DateTime closeTime = new DateTime(01, 02, 01, 18, 00, 00);


            string year_ = openTime.Year.ToString();
            string month_ = openTime.Month.ToString();
            string day_ = openTime.Day.ToString();
            string hour_ = openTime.Hour.ToString();
            string minute_ = openTime.Minute.ToString();
            string second_ = openTime.Minute.ToString();
            string millisecond_ = openTime.Millisecond.ToString();

            string year2_ = closeTime.Year.ToString();
            string month2_ = closeTime.Month.ToString();
            string day2_ = closeTime.Day.ToString();
            string hour2_ = closeTime.Hour.ToString();
            string minute2_ = closeTime.Minute.ToString();
            string second2_ = closeTime.Minute.ToString();
            string millisecond2_ = closeTime.Millisecond.ToString();


            string time = $" {hour_} : {minute_} - {hour2_} : {minute2_}";

            return time;

        }
        public override string ToString()
        {
            return $" Name of Hospital: \t\t {HospitalName} \n Address of Hospital: \t\t {HospitalAddress} \n Phone number of Hospital: \t {HospitalPhoneNumber} \n Work time at Hospital: \t{Time}";
        }

    }
}
