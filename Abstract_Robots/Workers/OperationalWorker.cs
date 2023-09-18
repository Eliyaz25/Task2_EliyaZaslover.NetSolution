using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker : Worker //1. כתבו את המחלקה המתאימה להורשה 
    {
        private int workHours;
        private double hourSalary;
        //2. השלימות את התכונות החסרות

        public OperationalWorker(string name, string id, DateTime bDate, string pass, int workHours, double hourSalary)
            : base(name, id, bDate, pass)
        {
            this.workHours = workHours;
            this.hourSalary = hourSalary;
            //3. השלימו את הקוד החסר לשמירת שכר בתכונה המתאימה
            // ?האם נדרשים פרמטרים נוספים
        }

        //4. כתבו פעולה דורסת לחישוב שכר
        public override double Salary()
        {
            return workHours * hourSalary;
        }
    }
}
