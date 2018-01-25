using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RobotVirtualProxy : IWeapon
    {
        //robot is a very expensive object, need creating on demand
        private Robot _robot;

        public void Move()
        {
            if (null == _robot)
                _robot = new Robot();
            _robot.Move();
        }

        public void Destroy()
        {
            if (null == _robot)
                _robot = new Robot();
            _robot.Destroy();
        }
    }
}
