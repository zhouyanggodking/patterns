using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    public interface IWeapon
    {
        void Move();
        void Destroy();
    }
}
