using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyWeightPattern
{
    public class MyRect : IShape
    {
        //intrinsic
        private Color _color;
        //extrinsic
        private int _topLeftX;
        private int _topLeftY;
        private int _width;
        private int _height;

        public MyRect(Color color)
        {
            //instrinsic
            this._color = color;           
        }

        //extrinsic
        public void SetPosition(int topLeftX, int topLeftY, int width, int height)
        {
            this._topLeftX = topLeftX;
            this._topLeftY = topLeftY;
            this._width = width;
            this._height = height;
        }

        public void Draw(Form frm)
        {
            using (SolidBrush brush = new SolidBrush(this._color))
            {
                using (Graphics g = frm.CreateGraphics())
                {
                    g.FillRectangle(brush, new Rectangle(this._topLeftX, this._topLeftY, this._width, this._height));
                }
            }
        }
    }
}
