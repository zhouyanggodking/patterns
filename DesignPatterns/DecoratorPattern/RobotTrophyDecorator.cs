using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class RobotTrophyDecorator : WeaponDecorator
    {
        public override void Move()
        {
            base.Move();
        }

        public override void Destroy()
        {
            base.Destroy();
            Trophy(); //add your addtional behaviour here
        }

        private void Trophy()
        {
            Console.WriteLine("Some trophy was collected");
        }
    }
}
