using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        private double monthlySalary;
        private int activeRobots;
        //1. השלימות את התכונות החסרות

        public GeneralManager(string name, string id, DateTime bDate, string pass, double monthlySalary, int activeRobots)
            :base (name,id,bDate,pass)
        {
            this.monthlySalary = monthlySalary;
            this.activeRobots = activeRobots;
        }

        //3. כתבו פעולה דורסת לחישוב שכר
        public override double Salary()
        {
            if (activeRobots > 30)
                return 1.15 * monthlySalary;
            return monthlySalary;
        }
    }
}
