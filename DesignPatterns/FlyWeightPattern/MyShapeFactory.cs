using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public class MyShapeFactory
    {
        private static Dictionary<Color, MyRect> dic = new Dictionary<Color, MyRect>();
        public static MyRect GetMyRect(Color color)
        {
            MyRect myRect;
            if (!dic.TryGetValue(color, out myRect))
            {
                myRect = new MyRect(color);
                dic.Add(color, myRect);
            }

            return myRect;
        }
    }
}
