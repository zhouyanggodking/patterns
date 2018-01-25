using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyWeightPattern
{
    public partial class MainForm : Form
    {

        private Color[] colors = { Color.Red, Color.Purple, Color.Pink, Color.Peru, Color.Blue, Color.Green, Color.Gold, Color.GreenYellow };
        Random rdm = new Random();

        public MainForm()
        {
            InitializeComponent();         
            
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            DateTime dt = DateTime.Now;
            for (int i = 0; i <= 100000; ++i)
            {
                //RAM: 16863232 bytes, Time:3321.3321ms
                //var rect = new MyRect(GetRandomColor());
                //rect.SetPosition(GetRandomX(), GetRandomY(), 100, 100);
                //rect.Draw(this);

                //RAM: 17203976 bytes, Time:3395.3395ms
                var rect = MyShapeFactory.GetMyRect(GetRandomColor());
                rect.SetPosition(GetRandomX(), GetRandomY(), 100, 100);
                rect.Draw(this);
            }

            TimeSpan ts = DateTime.Now.Subtract(dt);

            label1.Text = "Total RAM: " + Process.GetCurrentProcess().PrivateMemorySize64 +" Total timespan: " + ts.TotalMilliseconds.ToString();
        }

        private Color GetRandomColor()
        {            
            int index = rdm.Next(0, 8);
            return colors[index];
        }

        private int GetRandomX()
        {
            return rdm.Next(0, this.Width);
        }

        private int GetRandomY()
        {
            return rdm.Next(0, this.Height);
        }
    }
}
