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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsInside(e.X, e.Y))
                {
                    list[i].Color = Color.Aqua;

                }

                else
                {
                    list[i].Color = Color.Red;
                }
            }
            Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsInside(e.X, e.Y))
                {
                    list[i].X = r.Next(0, this.Width - list[i].Width - 15);
                    list[i].Y = r.Next(0, this.Height - list[i].Height - 40);//this. обращение к этому коду (Form1)
                }
            }
                Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Figure rectangle = new Rect();
            rectangle.Height = 100;
            rectangle.Width = 150;
            rectangle.X = r.Next(0, Height - rectangle.Width);
            rectangle.Y = r.Next(0, Height - rectangle.Height);
            rectangle.Color = Color.Red;
            list.Add(rectangle);

            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figure ellipse = new Ellipse();
            ellipse.Height = 100;
            ellipse.Width = 150;
            ellipse.X = r.Next(0, Height - ellipse.Width);
            ellipse.Y = r.Next(0, Height - ellipse.Height);
            ellipse.Color = Color.Red;
            list.Add(ellipse);

            Refresh();
        }
    }
}
