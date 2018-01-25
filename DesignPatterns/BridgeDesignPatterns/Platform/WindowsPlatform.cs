using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatterns.Platforms
{
    public class WindowsPlatform : Platform
    {
        public override void WalkImpl()
        {
            Console.WriteLine("Walk in windows");
        }

        public override void JumpImpl()
        {
            Console.WriteLine("Jump in windows");
        }
    }
}
