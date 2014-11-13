using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication2
{
    //abstract нельзя наследоваться
    abstract class Figure
    {
        //public - виден везде
        //protected - виден внутри класса и в наследниках
        //private - только внутри класса

        public float X { get; set; } //установка и изменение 
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Color Color { get; set; }

        public abstract void Draw(Graphics gr);
        public abstract bool IsInside(float x, float y);
        
    }
}
