using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {

        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotFly() : base("Roboquad")
        { }
        
        public override void MoveBackward()
        {
            throw new NotImplementedException();
        }

        public override void MoveForward()
        {
            throw new NotImplementedException();
        }

        public override void TurnLeft()
        {
            throw new NotImplementedException();
        }

        public override void TurnRight()
        {
            throw new NotImplementedException();
        }
    }
}
