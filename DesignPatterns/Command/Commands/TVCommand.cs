using CommandPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public abstract class TVCommand
    {
        protected TV _tv;

        public TVCommand(TV tv)
        {
            this._tv = tv;
        }

        public abstract void Execute();
    }
}
