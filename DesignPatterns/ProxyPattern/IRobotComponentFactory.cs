﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public interface IRobotComponentFactory
    {
        IRobotComponent CreateRobotComponent(string type);
    }
}
