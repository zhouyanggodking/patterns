using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RobotProtectionlProxy : IWeapon
    {
        private Robot _robot;
        private Commander _commander;

        public RobotProtectionlProxy(Commander commander)
        {
            this._commander = commander;
            _robot = new Robot();
        }

        public void Move()
        {
            if (CheckAuthority())
                _robot.Move();
            else
                Console.WriteLine("Not authorized");
        }

        public void Destroy()
        {
            if (CheckAuthority())
                _robot.Destroy();
            else
                Console.WriteLine("Not authorized");
        }

        private bool CheckAuthority()
        {
            if (null != _commander)
                return _commander.Name.ToLower() == "godking" && _commander.Password == "Igtcorp123";
            return false;
        }
    }
}
