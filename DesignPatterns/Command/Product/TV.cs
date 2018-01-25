using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Product
{
    public abstract class TV
    {
        /// <summary>
        /// Display current channel
        /// </summary>
        public abstract void Display();

        /// <summary>
        /// Move to next channel
        /// </summary>
        public abstract void MoveNext();

        /// <summary>
        /// Move to previous channel
        /// </summary>
        public abstract void MovePrevious();
    }
}
