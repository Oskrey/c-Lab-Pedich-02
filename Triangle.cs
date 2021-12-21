using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Triangle : Figure
    {
        float size, half_side;
        public Triangle()
        {

        }

        public override bool test(float x, float y)
        {
            //float xmin = pos_x - half_side;
            //float ymin = pos_y - half_side;
            //float xmax = pos_x + half_side;
            //float ymax = pos_y + half_side;
            //if (x < xmin || y < ymin) return false;
            //if (x > xmax || y > ymax) return false;
            return true;
        }

        public override void draw(Graphics g)
        {
            PointF[] p = new PointF[3];

            p[0].X = pos_x;

            p[0].Y = pos_y;

            p[1].X = (float)(pos_x + size * Math.Cos(angle));

            p[1].Y = (float)(pos_y + size * Math.Sin(angle));

            p[2].X = (float)(pos_x + size * Math.Cos(angle + Math.PI / 3));

            p[2].Y = (float)(pos_y + size * Math.Sin(angle + Math.PI / 3));
            Pen pen = new Pen(color, thickness);
            g.DrawPolygon(pen, p);
        }
        public override void Set(float sz)
        {
            size = sz;
            half_side = sz * 0.5f;
        }
    }
}
