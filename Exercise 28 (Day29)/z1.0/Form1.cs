using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 150, 50, 50, 150);
            formGraphics.DrawLine(myPen, 150, 50, 250, 150);
            formGraphics.DrawLine(myPen, 50, 150, 250, 150);
            myPen.Dispose();
            formGraphics.Dispose();

            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, 50, 200, 200, 100);

            SolidBrush B = new SolidBrush(Color.Black);
            g.FillRectangle(B, 300, 50, 100, 100);

            SolidBrush D = new SolidBrush(Color.Blue);
            g.FillEllipse(D, 300, 200, 100, 100);

            Pen penn = new Pen(Color.Black);
            g.DrawEllipse(pen, 450, 200, 100, 100);

            Pen pennn = new Pen(Color.Black);
            g.DrawEllipse(pen, 465, 215, 70, 70);

            Pen pennnn = new Pen(Color.Black);
            g.DrawEllipse(pen, 480, 230, 40, 40);

            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(450, 50, 50, 60));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(470, 80, 50, 60));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(490, 110, 50, 60));
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
