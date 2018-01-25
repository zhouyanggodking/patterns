using BridgeDesignPatterns.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatterns
{
    public class Mario2D : Mario
    {
        public Mario2D(Platform platform)
        {
            this._latform = platform;
        }

        public override void Walk()
        {
            Console.WriteLine("Mario 2D walk");
            _latform.WalkImpl();
        }

        public override void Jump()
        {
            Console.WriteLine("Mario 2D jump");
            _latform.JumpImpl();
        }
    }
}
