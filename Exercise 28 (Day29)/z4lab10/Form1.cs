using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z4lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

            Graphics g = e.Graphics;
           
            g.Clear(Color.MidnightBlue);

            SolidBrush sB4 = new SolidBrush(Color.CadetBlue);
            g.FillEllipse(sB4, 400, 20, 300, 300);

            SolidBrush sB5 = new SolidBrush(Color.DarkGray);
            g.FillEllipse(sB5, 410, 30, 280, 280);

            Graphics r = e.Graphics;
            for (int i = 0; i < 10; i++)
                r.DrawLine(new Pen(Brushes.DarkBlue, 2),
                1, 6 * i + 5, 900, 6 * i + 5);

            Graphics t = e.Graphics;
            for (int i = 0; i < 10; i++)
                t.DrawLine(new Pen(Brushes.BlueViolet, 2),
                1, 6 * i + 60, 900, 6 * i + 60);

            Graphics y = e.Graphics;
            for (int i = 0; i < 10; i++)
                y.DrawLine(new Pen(Brushes.CornflowerBlue, 2),
                1, 6 * i + 120, 900, 6 * i + 120);

            Graphics u = e.Graphics;
            for (int i = 0; i < 10; i++)
                u.DrawLine(new Pen(Brushes.LightSkyBlue, 2),
                1, 6 * i + 180, 900, 6 * i + 180);

            SolidBrush zB = new SolidBrush(Color.DarkGreen);
            g.FillRectangle(zB, 0, 220, 800, 820);

            Graphics o = e.Graphics;
            for (int i = 0; i < 10; i++)
                o.DrawLine(new Pen(Brushes.Green, 2),
                1, 6 * i + 300, 900, 6 * i + 300);

            Graphics p = e.Graphics;
            for (int i = 0; i < 10; i++)
                p.DrawLine(new Pen(Brushes.Green, 2),
                1, 6 * i + 360, 900, 6 * i + 360);

            Graphics a = e.Graphics;
            for (int i = 0; i < 10; i++)
                a.DrawLine(new Pen(Brushes.GreenYellow, 2),
                1, 6 * i + 240, 900, 6 * i + 240);

            Graphics z = e.Graphics;
            for (int i = 0; i < 4; i++)
                z.DrawLine(new Pen(Brushes.LightGoldenrodYellow, 2),
                1, 6 * i + 220, 900, 6 * i + 220);

            SolidBrush cB = new SolidBrush(Color.DarkSlateGray);

            g.FillPolygon(cB, new Point[]
            {
                new Point(100,100),new Point(200,2),
                new Point(100,100),new Point(600,400),
                new Point(600,400),new Point(200,400),
                new Point(200,400),new Point(100,300)
            }
            );
            SolidBrush sB = new SolidBrush(Color.SandyBrown);
            g.FillRectangle(sB, 100, 100, 200, 120);

            SolidBrush tB = new SolidBrush(Color.SaddleBrown);
            g.FillRectangle(tB, 250, 140, 40, 80);

            SolidBrush bB = new SolidBrush(Color.SaddleBrown);
            g.FillRectangle(bB, 50, 60, 300, 40);

            SolidBrush rB = new SolidBrush(Color.SaddleBrown);
            g.FillRectangle(rB, 125, 40, 150, 40);

            SolidBrush aB = new SolidBrush(Color.SaddleBrown);
            g.FillRectangle(aB, 155, 20, 90, 40);
        }
    }
}
