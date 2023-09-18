using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotWheels : RobotSpy
    {
        private int rightDir;
        private int leftDir;

        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotWheels() : base("Spyke") 
        {
            this.rightDir = 0;
            this.leftDir = 0;
        } 

        public override void MoveForward()
        {
            this.TurnWheels(1, 1);
        }
        public override void TurnRight()
        {
            this.TurnWheels(-1, 0);
        }
        //השלימו את הפעולות החסרות מתוך המצגת או על הבנתכם

        private void TurnWheels(int rightDir, int leftDir)
        {
            this.rightDir += rightDir;
            this.leftDir += leftDir;
            SetBatteryStatus(GetBatteryStatus() - 4.5);
        }

        public void WaveHands()
        {
            SetBatteryStatus(GetBatteryStatus() - 2);
            //3. הוסיפו התייחסות לסוללה 
        }

        public override void MoveBackward()
        {
            this.TurnWheels(-1, -1);

        }

        public override void TurnLeft()
        {
            this.TurnWheels(1, 0);

        }
    }
}
