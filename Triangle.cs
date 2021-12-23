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
        float size;
        public Triangle()
        {
        }
        public PointF ptest = new PointF();
        public override bool test(float x, float y)
        {
            float a = (p[0].X - x) * (p[1].Y - p[0].Y) - (p[1].X - p[0].X) * (p[0].Y - y);
            float b = (p[1].X - x) * (p[2].Y - p[1].Y) - (p[2].X - p[1].X) * (p[1].Y - y);
            float c = (p[2].X - x) * (p[0].Y - p[2].Y) - (p[0].X - p[2].X) * (p[2].Y - y);

            if (a > 0 && b > 0 && c > 0) return true;
            if (a < 0 && b < 0 && c < 0) return true;
            else return false;
        }
        public PointF[] p = new PointF[3];
        public override void draw(Graphics g)
        {
            p[0].X = pos_x;
            p[0].Y = pos_y;

            p[1].X = (float)(pos_x + size * -Math.Cos(0));
            p[1].Y = (float)(pos_y + size * -Math.Sin(0));

            p[2].X = (float)(pos_x + size * -Math.Cos(Math.PI / 3));
            p[2].Y = (float)(pos_y + size * -Math.Sin(Math.PI / 3));
            Pen pen = new Pen(color, thickness);
            g.DrawPolygon(pen, p);
        }
        public override void Set(float sz)
        {
            size = sz;
        }
        public override float sdf(Vec2 p)
        {
            Vec2 d = (p - pos).abs() - size;

            float inner_d = Math.Min(Math.Max(d.x, d.y), 0.0f);
            float outer_d = d.max(0.0f).len();
            return inner_d + outer_d;
        }


    }
}






/*
            
            весёлый бред
            p[0].X = pos_y + (float)(((Math.Sqrt(3) / 2) * size) / 3) * 2; 
            p[0].Y = pos_x - (float)(((Math.Sqrt(3) / 2) * size) / 3) * 2; 

            p[1].X = pos_x;
            p[1].Y = pos_y + (float)(((Math.Sqrt(3) / 2) * size) / 3);

            p[2].X = pos_x + (float)(((Math.Sqrt(3) / 2) * size) / 3) * 2;
            p[2].Y = pos_y + (float)(((Math.Sqrt(3) / 2) * size) / 3) * 2;
 
 
 
 
 
 
 
            if  (y < p[0].Y|| y > yBmin || x < xAmax || y < yBmin || y < yCmin || y < yAmin) return false;
            if  (x > xBmax || x > xCmax || x > xAmax || y > yBmax || y > yCmax || y > yAmax) return false;


            ptest.X = x;
            ptest.Y = y;
            if (ptest.Equals(p)) return true;
            if ((ptest.X > p[0].X && ptest.Y > p[0].Y) || (ptest.X < p[1].X && ptest.Y > p[1].Y) || (ptest.X > p[2].X && ptest.Y < p[2].Y)) return false;
            
 
 */