using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication2
{
    class Triangle : Figure
    {
        public override void Draw(Graphics gr) //override для индивидуального редактирования
        {
            Pen pen = new Pen(Color, 5);
            
            gr.DrawLine(pen, X, Y, X + Width, Y);
            gr.DrawLine(pen, X + Width, Y, X + Width, Y + Height);
            gr.DrawLine(pen, X + Width, Y + Height, X, Y);
        }
        //Сделать проверку, что точка внутри эллипса 
        public override bool IsInside(float x, float y)
        {
            if (true)
            {
                //return true;
            }
            return false;
        }
    }
}
