using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Slot slot = new Slot(new IdleState());

            for (int i = 0; i < 10; i++)
            {
                slot.RequestStatus();
            }
        }
    }
}
