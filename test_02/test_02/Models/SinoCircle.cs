using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_02.Models
{
    public class SinoCircle:SinoShape
    {
        public float radius;

        public override void draw_on(Graphics canvas) 
        {
            canvas.DrawEllipse(new Pen(color), location.X - radius, location.Y - radius, radius*2, radius*2);
        }

        public override void click_second(Point pointF) 
        {
            radius = distance(pointF, location);

        }

        float distance(PointF p1, PointF p2)
        {
            return (float)Math.Pow(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2), 0.5);
        }


    }
}
