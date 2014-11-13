using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication2
{
    class Ellipse : Figure
    {
        public override void Draw(Graphics gr) //override для индивидуального редактирования
        {
            Pen pen = new Pen(Color, 5);
            Brush b = new HatchBrush(HatchStyle.Percent50, Color.FromArgb(50, Color.DodgerBlue), Color.FromArgb(50, Color.Blue));
            gr.FillEllipse(b, X, Y, Width, Height);
            gr.DrawEllipse(pen, X, Y, Width, Height);
        }
        //Сделать проверку, что точка внутри эллипса 
        public override bool IsInside(float x, float y)
        {

            if ((((x - (X + Width / 2)) * (x - (X + Width / 2))) / ((Width / 2) * (Width / 2)) + ((y - (Y + Height / 2)) * (y - (Y + Height / 2))) / ((Height / 2) * (Height / 2))) <= 1)
                
            {
                return true;
            }
            return false;
        }
    }
}
