using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace test_02.Models
{
    public class SinoLine : SinoShape
    {
        PointF endPoint;

        public override void draw_on(Graphics canvas)
        {
            canvas.DrawLine(new Pen(color), location, endPoint);
        }

        public override void click_second(PointF pointF)
        {
            endPoint = pointF;

        }

        public override void preview(Graphics canvas, PointF pointF)
        {
            endPoint = pointF;
            draw_on(canvas);
        }
    }
}
