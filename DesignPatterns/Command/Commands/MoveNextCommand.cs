using CommandPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class MoveNextCommand : TVCommand
    {
        public MoveNextCommand(TV tv)
            : base(tv)
        {

        }

        public override void Execute()
        {
            _tv.MoveNext();
        }
    }
}
