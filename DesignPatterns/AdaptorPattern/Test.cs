using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            //IRobotBuilder olderRobotBuilder = new OlderRobotBuilder();
            IRobotBuilder olderRobotBuilder = OlderRobotBuildFactory.Instance.CreateBuilder();
            RobotCreator robotCreator = new RobotCreator(olderRobotBuilder);
            Robot olderRobot = robotCreator.Create();

            //make the interface transparent to customer
            //uniform way to use interface
            DescribeWeaponFunctionality(olderRobot);

            DescribeWeaponFunctionality(new TankAdaptor());           
        }

        static void DescribeWeaponFunctionality(IWeapon weapon)
        {
            weapon.Move();
            weapon.Destroy();
        }
    }
}
