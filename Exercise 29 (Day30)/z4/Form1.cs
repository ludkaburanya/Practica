using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap baner;
        Rectangle rct;
        public Form1()
        {
            InitializeComponent();
            try
            {
                baner = new Bitmap("plane.png");
            }
            catch (Exception e)
            {

                MessageBox.Show($"Ошибка загрузки файла баннер\n {e.ToString()} Баннер");
                this.Close();
                return;
            }
            rct.X = 35;
            rct.Y = 10;
            rct.Width = baner.Width;
            rct.Height = baner.Height;

            this.Paint += Form1_Paint;

            timer1.Tick += timer1_Tick;
            timer1.Interval = 10;
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rct.X -= 1;
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.White);

            if (Math.Abs(rct.X) > rct.Width)
                rct.X += rct.Width;
            for (int i = 0; i <= Convert.ToInt16(this.ClientSize.Width / rct.Width) + 1; i++)
            {
                g.DrawImage(baner, rct.X + 1 * rct.Width, rct.Y);
            }
        }
    }
}