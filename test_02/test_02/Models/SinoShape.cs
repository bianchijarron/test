using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace test_02.Models
{
    public abstract class SinoShape
    {
        public Point location;
        public Color color = Color.Black;
        private double lenght = 0;
        private double area = 0;

        public virtual void draw_on(Graphics canvas) { }

        public virtual void click_second(PointF pointF) { }

        public virtual void preview(Graphics canvas, PointF pointF) { }

        public string get_info()
        {
            string info = "";
            if (lenght != 0)
                info += $"長度為 {lenght} ";
            if (area != 0)
                info += $"面積為 {area}";
            return info;
        }
    }
}
