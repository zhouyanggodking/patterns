using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyWeightPattern
{
    public interface IShape
    {
        void Draw(Form frm);
    }
}
