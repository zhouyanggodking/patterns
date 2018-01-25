using CommandPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Factory
{
    public class SonyTVFactory : TVFactory
    {
        public override TV Create()
        {
            return new SonyTV();
        }
    }
}
