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
        private int mobile_telephone;
        private string email;
        private DateTime birthday;
        private string middle_name = "";
        private string nickname = "";
        //private Image photo;
        private string title = "";
        private string company = "";
        private string address = "";
        private int home_telephone = 0;
        private int work_tephone = 0;
        private int fax = 0;
        private string email2 = "";
        private string email3 = "";
        private string homepage = "";
        private DateTime anniversary;
        private string group = "";


        public ContactData(string first_name, string last_name, int mobile_telephone, string email, DateTime birthday) 
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.mobile_telephone = mobile_telephone;
            this.email = email;
            this.birthday = birthday;
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
            return First_name == other.First_name;
           
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
        public string First_name 
        { 
            get { return first_name; }
            set {first_name = value; }
        }

        public string Last_name
        {
          get { return last_name; }
          set { last_name = value; }
        }

        public int Mobile_telephone
        {
            get { return mobile_telephone; }
            set { mobile_telephone = value; }
        }

        public string Email
        { get { return email; } 
          set { email = value; }
        }

        public DateTime Birthday
        { get { return birthday; }
          set { birthday = value; }
        }

        public string Middle_name
        { get { return middle_name; }
          set { middle_name = value; } 
        }

        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Home_telephone
        {
            get { return home_telephone; }
            set { home_telephone = value; }
        }
        public int Work_telephone
        {
            get { return work_tephone; }
            set { work_tephone = value; }
        }

        public int Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        public string Email2
        {
            get { return email2; }
            set { email2 = value; }
        }

        public string Email3
        {
            get { return email3; }
            set { email3 = value; }
        }

        public string Homepage
        {
            get { return homepage; }
            set { homepage = value; }
        }
        public DateTime Anniversary
        {
            get { return anniversary; }
            set { anniversary = value; }
        }
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
    }
}
