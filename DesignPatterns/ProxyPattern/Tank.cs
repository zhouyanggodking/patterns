﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Tank
    {
        public void TankMove()
        {
            Console.WriteLine("Tank move...");
        }

        public void TankFire()
        {
            Console.WriteLine("Tank destroyed several targets...");
        }
    }
}
