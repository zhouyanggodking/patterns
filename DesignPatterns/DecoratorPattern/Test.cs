using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            //IRobotBuilder olderRobotBuilder = new OlderRobotBuilder();
            IRobotBuilder olderRobotBuilder = OlderRobotBuildFactory.Instance.CreateBuilder();
            RobotCreator robotCreator = new RobotCreator(olderRobotBuilder);
            Robot olderRobot = robotCreator.Create();

            //adaptor
            //make the interface transparent to customer
            //uniform way to use interface
            DescribeWeaponFunctionality(olderRobot);

            DescribeWeaponFunctionality(new TankAdaptor()); 
          

            //decorator
            Console.WriteLine("---------------------");
            RobotCelebrationDecorator celDec = new RobotCelebrationDecorator();
            celDec.SetWeapon(olderRobot);
            DescribeWeaponFunctionality(celDec);

            //decorator chain
            RobotTrophyDecorator troDec = new RobotTrophyDecorator();
            troDec.SetWeapon(celDec);
            DescribeWeaponFunctionality(troDec);
        }

        static void DescribeWeaponFunctionality(IWeapon weapon)
        {
            weapon.Move();
            weapon.Destroy();
        }
    }
}
