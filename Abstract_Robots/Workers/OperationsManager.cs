using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        //1. השלימות את התכונות החסרות
        private double hourSalary;
        private double workHours;
        private int taskDone;
        public OperationManager(string name, string id, DateTime bDate, string pass, double hourSalary, double workHours, int taskDone)
            : base(name, id, bDate, pass)
        {
            this.hourSalary = hourSalary;
            this.workHours = workHours;
            this.taskDone = taskDone;

            //2. השלימו את הקוד החסר לשמירת שכר בתכונה המתאימה
        }

        public override double Salary()
        {
            throw new NotImplementedException();
        }

        //3. כתבו פעולה דורסת לחישוב שכר

    }
}
