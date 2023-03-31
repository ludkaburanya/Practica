using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z3lab10
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
            SolidBrush B = new SolidBrush(Color.DeepPink);
            g.FillRectangle(B, 120, 10, 100, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
