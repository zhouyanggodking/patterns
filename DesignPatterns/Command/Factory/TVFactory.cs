using CommandPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Factory
{
    public abstract class TVFactory
    {
        public abstract TV Create();
    }
}
