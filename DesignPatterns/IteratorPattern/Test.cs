using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            //first build an army - two older robots and three grand new ones
            IRobotBuilder olderRobotBuilder = OlderRobotBuildFactory.Instance.CreateBuilder();
            RobotCreator robotCreator = new RobotCreator(olderRobotBuilder);
            Robot olderRobot1 = robotCreator.Create();
            olderRobot1.Name ="Older Robot 1";
            Robot olderRobot2 = (Robot)olderRobot1.Clone();
            olderRobot2.Name = "Older Robot 2";

            IRobotBuilder grandNewRobotBuilder = GrandNewGenerationRobotBuilderFactory.Instance.CreateBuilder();
            robotCreator = new RobotCreator(grandNewRobotBuilder);
            Robot grandNewRobot1 = robotCreator.Create();
            grandNewRobot1.Name = "Grand new robot number 1";
            Robot grandNewRobot2 = (Robot)grandNewRobot1.Clone();
            grandNewRobot2.Name = "Grand new robot number 2";
            Robot grandNewRobot3 = (Robot)grandNewRobot1.Clone();
            grandNewRobot3.Name = "Grand new robot number 3";

            RobotArmy army = new RobotArmy();
            //const int robotNum = 5;
            army.Add(olderRobot1);
            army.Add(olderRobot2);
            army.Add(grandNewRobot1);
            army.Add(grandNewRobot2);
            army.Add(grandNewRobot3);

            //review troops

            IIterator iter = army.CreateIterator();
            iter.First(); //move to first elem
            while (iter.HasNext())
            {
                Console.WriteLine((Robot)iter.Current());
                iter.Next();
            }
        }

       
    }
}
