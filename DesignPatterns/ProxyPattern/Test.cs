using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            //protection proxy
            Commander commander = new Commander("GodKing", "Igtcorp123");

            RobotProtectionlProxy virtualProxy = new RobotProtectionlProxy(commander);
            DescribeWeaponFunctionality(virtualProxy);

            DescribeWeaponFunctionality(new RobotProtectionlProxy(new Commander("sadf","dsf")));


            //virtual proxy
            DescribeWeaponFunctionality(new RobotVirtualProxy());
        }

        static void DescribeWeaponFunctionality(IWeapon weapon)
        {
            weapon.Move();
            weapon.Destroy();
        }
    }
}
