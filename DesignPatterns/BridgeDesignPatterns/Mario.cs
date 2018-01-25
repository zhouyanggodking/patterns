using BridgeDesignPatterns.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatterns
{
    public abstract class Mario
    {
        protected Platform _latform;
        public abstract void Walk();
        public abstract void Jump();
    }
}
