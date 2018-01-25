using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class TankAdaptor : IWeapon
    {
        private Tank _tank = new Tank();
        public void Move()
        {
            _tank.TankMove();
        }

        public void Destroy()
        {
            _tank.TankFire();
        }
    }
}
