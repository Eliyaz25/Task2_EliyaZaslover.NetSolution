﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotQuad : RobotSpy
    {
        private int[] location;
        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotQuad() : base("Roboquad")
        {
            this.location = new int[4];
        }

        public override void MoveBackward()
        {
            for (int i = 0; i < 4; i++)
            {
                this.MoveLeg(i, -1);
            }
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, 1);
        }

        public override void TurnLeft()
        {
            this.MoveLeg(0, -1);
            this.MoveLeg(1, -1);
            this.MoveLeg(2, 1);
            this.MoveLeg(3, 1);
        }

        public override void TurnRight()
        {
            this.MoveLeg(0, 1);
            this.MoveLeg(1, 1);
            this.MoveLeg(2, -1);
            this.MoveLeg(3, -1);
        }

        //2. השלימו את התנועות החסרות מתוך המצגת או על הבנתכם

        private void MoveLeg(int legId, int dir) 
        {
            location[legId] += dir;
            SetBatteryStatus(GetBatteryStatus() - 3);
            //3. הוסיפו התייחסות לסוללה
        }
    }

}
