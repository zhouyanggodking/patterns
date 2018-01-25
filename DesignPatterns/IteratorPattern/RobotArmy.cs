using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// robot collection class
    /// </summary>
    public class RobotArmy : IContainer
    {
        private List<Robot> _robotList;
        
        public RobotArmy()
        {
            _robotList = new List<Robot>();
        }

        public void Add(Robot newRobot)
        {
            _robotList.Add(newRobot);
        }

        public bool Remove(Robot robot)
        {
            return _robotList.Remove(robot);
        }

        public IIterator CreateIterator()
        {
            return new RobotArmyIterator(this);
        }

        private class RobotArmyIterator : IIterator
        {
            private int _currIndex = 0;
            private RobotArmy _robotArmy;

            public RobotArmyIterator( RobotArmy robotArmy)
            {
                this._robotArmy = robotArmy;
            }

            public bool HasNext()
            {
                return _currIndex < _robotArmy._robotList.Count();
            }

            public object Next()
            {
                return _robotArmy._robotList[_currIndex++];
            }

            public object Current()
            {
                return _robotArmy._robotList[_currIndex];
            }

            public object First()
            {
                _currIndex = 0;
                return _robotArmy._robotList[_currIndex];
            }
        }       
    }
}
