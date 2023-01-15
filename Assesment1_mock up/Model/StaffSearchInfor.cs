using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assesment1_mock_up.Model
{
    public class StaffSearchInfor
    {
       private string first_Name;
       private string last_Name;
        private int?  age_Range;
        private string state_Territory;
        private string gender;
        private string home_Suburb;
        private int home_Post_Code;
        private string email_Address;
        private string bank_Used;
        private string banks_Service;
        private string newspaper;
        private DateTime Date;
        private string ip_address;

        public string First_Name { get => first_Name; set => first_Name = value; }
        public string Last_Name { get => last_Name; set => last_Name = value; }
        public int? Age_Range { get => age_Range; set => age_Range = value; }
        public string State_Territory { get => state_Territory; set => state_Territory = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Home_Suburb { get => home_Suburb; set => home_Suburb = value; }
        public int Home_Post_Code { get => home_Post_Code; set => home_Post_Code = value; }
        public string Email_Address { get => email_Address; set => email_Address = value; }
        public string Bank_Used { get => bank_Used; set => bank_Used = value; }
        public string Banks_Service { get => banks_Service; set => banks_Service = value; }
        public string Newspaper { get => newspaper; set => newspaper = value; }
        public DateTime Date1 { get => Date; set => Date = value; }
        public string Ip_address { get => ip_address; set => ip_address = value; }
    }
}