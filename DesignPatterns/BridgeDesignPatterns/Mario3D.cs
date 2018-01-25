using BridgeDesignPatterns.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatterns
{
    public class Mario3D : Mario
    {
        public Mario3D(Platform platform)
        {
            this._latform = platform;
        }
        public override void Walk()
        {
            Console.WriteLine("Mario 3D walk");
            _latform.WalkImpl();
        }

        public override void Jump()
        {
            Console.WriteLine("Mario 3D jump");
            _latform.JumpImpl();
        }
    }
}
