using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace z2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    class TestDrawing: Control
    {
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            drawingContext.DrawLine(new Pen(Brushes.Red, 2),
                new Point(0, 0),
                new Point(this.Height, this.Width));

            drawingContext.DrawLine(new Pen(Brushes.Red, 2),
               new Point(0, this.Width),
               new Point(this.Height, 0));

            base.OnRender(drawingContext);
        }
    }
    
}
