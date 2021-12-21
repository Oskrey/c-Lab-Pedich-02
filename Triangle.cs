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
            float xmin = pos_x - size;
            float ymin = pos_y - size;
            float xmax = pos_x ;
            float ymax = pos_y ;
            if (x < xmin || y < ymin) return false;
            if (x > xmax || y > ymax) return false;

            return true;
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
        
        
    }
}






/*
            float yBmin = pos_y- (float)(((Math.Sqrt(3) / 2) * size) / 3) * 2; //Для B
            float xBmin = pos_x;
            float yBmax = pos_y+(float)(((Math.Sqrt(3) / 2) * size) / 3);
            float xBmax = pos_x;/////////////////////////////////////////////////////////

            float yCmax = pos_y + (float)(((Math.Sqrt(3) / 2) * size) / 3) * 2;// Для С
            float xCmax = pos_x + (float)(((Math.Sqrt(3) / 2) * size) / 3) * 2;
            float yCmin = pos_y - (float)(((Math.Sqrt(3) / 2) * size) / 3);
            float xCmin = pos_x - (float)(((Math.Sqrt(3) / 2) * size) / 3);/////////////

            float yAmax = pos_y + (float)(((Math.Sqrt(3) / 2) * size) / 3) * 2;// Для С
            float xAmax = pos_x - (float)(((Math.Sqrt(3) / 2) * size) / 3) * 2;
            float yAmin = pos_y - (float)(((Math.Sqrt(3) / 2) * size) / 3);
            float xAmin = pos_x + (float)(((Math.Sqrt(3) / 2) * size) / 3);/////////////

            if  (x < xBmax || x < xCmin || x < xAmin || y < yBmin || y < yCmin || y < yAmin) return false;
            if  (x > xBmax || x > xCmax || x > xAmax || y > yBmax || y > yCmax || y > yAmax) return false;
            










            

 
 
 
 
 
 
 
 
 
 
 
            if  (y < p[0].Y|| y > yBmin || x < xAmax || y < yBmin || y < yCmin || y < yAmin) return false;
            if  (x > xBmax || x > xCmax || x > xAmax || y > yBmax || y > yCmax || y > yAmax) return false;


            ptest.X = x;
            ptest.Y = y;
            if (ptest.Equals(p)) return true;
            if ((ptest.X > p[0].X && ptest.Y > p[0].Y) || (ptest.X < p[1].X && ptest.Y > p[1].Y) || (ptest.X > p[2].X && ptest.Y < p[2].Y)) return false;
            
 
 */