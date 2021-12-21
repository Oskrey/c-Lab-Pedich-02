using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Figure
    {
        public float pos_x, pos_y;
        protected float area; // protected - доступна наследуюемым классам, но не доступна пользователю
        public int thickness;
        public Color color = Color.Black;
        public bool colTrue;
        public bool selected;

        virtual public bool test(float x, float y)
        {
            return false;
        }

        virtual public void draw(Graphics g)
        {

        }
        virtual public void Set(float sz)
        {

        }

    }
}
