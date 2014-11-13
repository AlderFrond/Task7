using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication2
{
    class Rect : Figure
    {
        public override void Draw(Graphics gr) //override для индивидуального редактирования
        {
            Pen pen = new Pen(Color, 5);
            Brush b = new TextureBrush(Image.FromFile(@"C:\Users\Nomat_An\Desktop\2tpCLYhOyvM.jpg"));
            gr.FillRectangle(b, X, Y, Width, Height);
            gr.DrawRectangle(pen, X, Y, Width, Height);
        }

        public override bool IsInside(float x, float y)
        {
            if ((X <= x) && (x <= X + Width) &&
                (Y <= y) && (y <= Y + Height))
            {
                return true;
            }
            return false;
        }
    }
}
