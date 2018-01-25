using CommandPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class MovePreviousCommand : TVCommand
    {
        public MovePreviousCommand(TV tv)
            : base(tv)
        {

        }

        public override void Execute()
        {
            _tv.MovePrevious();
        }
    }
}
