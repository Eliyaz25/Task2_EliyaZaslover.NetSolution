using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            this.fullName = name;
            this.idNumber = id;
            this.birthDate = bDate;
            this.password = pass;
            //משימה 1
            //השלימו את הבנאי המקבל הפרמטרים הנחוצים ליצירת עובד חדש
        }
        //משימה 2
        //get כתבו פעולות מאחזרות 
        public string GetFullName() { return this.fullName; }
        public string GetIdNumber() { return this.idNumber; }
        public DateTime GetBirthDate() { return this.birthDate; }
        public string GetPassword() { return this.password; }


        //משימה 3
        //רק לתכונות שניתן לשנות - set כתבו פעולות מעדכנות
        public void SetFullName(string name) { this.fullName = name; }
        public void SetPassword(string pass) { this.password = pass; }


        //משימה 4
        // כתבו חתימה פעולה אבסטרקטית לחישוב שכר
        public abstract double Salary();
        

        public override string ToString()
        {
            string str = "";
            if(birthDate.Equals(DateTime.Today))
                str=" - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
