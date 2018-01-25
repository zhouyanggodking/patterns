using BridgeDesignPatterns.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Platform pf = new WindowsPlatform();
            Mario2D mario2D = new Mario2D(pf);
            mario2D.Walk();
            mario2D.Jump();

            pf = new LinuxPlatform();
            Mario3D mario3D = new Mario3D(pf);
            mario3D.Walk();
            mario3D.Jump();
        }
    }
}
