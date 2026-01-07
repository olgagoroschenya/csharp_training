using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string first_name;
        private string last_name;
        private string mobile_telephone;
        private string email;
        private DateTime birthday;
        private string middle_name = "";
        private string nickname = "";
        //private Image photo;
        private string title = "";
        private string company = "";
        private string address = "";
        private string home_telephone;
        private string work_tephone;
        private int fax = 0;
        private string email2 = "";
        private string email3 = "";
        private string homepage = "";
        private DateTime anniversary;
        private string group = "";
        private string allPhones;
        private string allInformation;

        public ContactData(string first_name, string last_name) 
        {
           First_name = first_name;
            Last_name = last_name;
            Mobile_telephone = mobile_telephone;
            Email = email;
           Birthday = birthday;
        }
        public ContactData(string first_name)
        {
            this.first_name = first_name;
          
        }
        public bool Equals(ContactData other)
        {
           
            if (Object.ReferenceEquals(other, null))
            { return false; }
            if (Object.ReferenceEquals(this, other))
            { return true; }
            return First_name == other.First_name && Last_name == other.Last_name;
           
        }
     
        public override int GetHashCode()
        {
            return First_name.GetHashCode();
        }

        public override string ToString()
        {
            return "name" + First_name;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            { return 1; }
            return First_name.CompareTo(other.First_name);
        }
        public string First_name { get; set; }
        
        public string Last_name { get; set; }
      
        public string Mobile_telephone { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public string Middle_name { get; set; }
       
        public string Nickname { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }

        public string Home_telephone { get; set; }
        public string Work_telephone { get; set; }

        public int Fax { get; set; }

        public string Email2 { get; set; }

        public string Email3 { get; set; }

        public string Homepage { get; set; }

        public DateTime Anniversary { get; set; }

        public string Group { get; set; }

        public string AllPhones
        {
            get
            {
                if (allPhones != null)
                {
                    return allPhones;
                }
                else
                {
                    return (CleanUp(Home_telephone) + CleanUp(Mobile_telephone) + CleanUp(Work_telephone)).Trim();
                }
            }
            set { allPhones = value; }
        }

        private string CleanUp(string phone)
        {
            if (phone == null || phone == "")
            { return ""; }
            return phone.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "")+"\r\n";
        }

        public string AllInformation
        {
            get
            {
                if (allInformation != null)
                {
                    return allInformation;
                }
                else
                {
                    return (CleanUpDetails(First_name) + CleanUpDetails(Last_name) + 
                        CleanUpDetails(Nickname) + CleanUpDetails(Company)).Trim();
                }
            }
            set { allInformation = value; }
        }
        private string CleanUpDetails(string detail)
        {
            if (detail == null || detail == "")
            { return ""; }
            return detail.Replace(" ", "") + "\r\n";
        }
    }
}
