using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class RobotCelebrationDecorator : WeaponDecorator
    {
        public override void Move()
        {
            base.Move();//remain unchanged
        }

        public override void Destroy()
        {
            base.Destroy();
            CelebrationAfterDestroyTarget();  // add additional behaviour
        }

        private void CelebrationAfterDestroyTarget()
        {
            Console.WriteLine("Hey, we destroyed our target!!!!");
        }
    }
}
