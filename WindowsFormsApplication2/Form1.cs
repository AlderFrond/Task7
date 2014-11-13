using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        //список (массив без гемороя)
        private List<Figure> list;
        private Random r = new Random(DateTime.Now.TimeOfDay.Milliseconds);

        public Form1()
        {
            InitializeComponent();
            list = new List<Figure>();
            
            //Для отрисовки вне формы. Картинка будет рисоваться в памяти а потом передаваться в форму. 
            DoubleBuffered = true; 
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Draw(e.Graphics);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Figure rectangle = new Rect();
            rectangle.Height = r.Next(10,150);
            rectangle.Width = r.Next(10, 150);
            rectangle.X = r.Next(0, (int)((Height - rectangle.Width)));
            rectangle.Y = r.Next(0, (int)(Height - rectangle.Height));
            rectangle.Color = Color.Red;
            list.Add(rectangle);

            Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Figure ellipse = new Ellipse();
            ellipse.Height = r.Next(10, 150);
            ellipse.Width = r.Next(10, 150);
            ellipse.X = r.Next(0, (int)(Height - ellipse.Width));
            ellipse.Y = r.Next(0, (int)(Height - ellipse.Height));
            ellipse.Color = Color.Red;
            list.Add(ellipse);

            Refresh();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Figure triangle = new Triangle();
            triangle.Height = r.Next(10, 150);
            triangle.Width = r.Next(10, 150);
            triangle.X = r.Next(0, (int)(Height - triangle.Width));
            triangle.Y = r.Next(0, (int)(Height - triangle.Height));
            triangle.Color = Color.Red;
            list.Add(triangle);

            Refresh();
        }
        private void ColoringFigures(int x, int y)
        {
            Figure f = GetCurrentFigure(x, y);
            foreach (var figure in list)
            {
                figure.Color = Color.Red;
            }

            if (f != null)
            {
                f.Color = Color.Purple;
            }
        }
        private Figure GetCurrentFigure(int x, int y)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsInside(x, y))
                {
                    return list[i];
                }
            }
            return null;
        }

        private Figure currentFigure;
        private Point currentPoint;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentFigure != null)
            {
                currentFigure.X += e.Location.X - currentPoint.X;
                currentFigure.Y += e.Location.Y - currentPoint.Y;
                currentPoint = e.Location;
            }
            else
            {
                ColoringFigures(e.X, e.Y);
            }
            Refresh();
        }
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            currentFigure = GetCurrentFigure(e.X, e.Y);
            currentPoint = e.Location;
        }
        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            currentFigure = null;
        }
    }
}
