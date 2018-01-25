using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatterns.Platforms
{
    public abstract class Platform
    {
        public abstract void WalkImpl();
        public abstract void JumpImpl();
    }
}
