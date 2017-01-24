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

using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;

namespace TravelPathOptimization
{

    // My drawing canvas with predefined graphics for demonstration purpose
    public class MyCanvas : Canvas
    {
 
        // Set custom OnRender function      
        public MyCanvas()
        {
            DefaultStyleKey = typeof(MyCanvas);
        }

        // Here the drawing happens
        protected override void OnRender(DrawingContext dc)
        {
            // background
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Colors.LightSalmon;
            Pen myPen = new Pen(Brushes.Blue, 1);
            Rect myRect = new Rect(0, 0, this.Width, this.Height);
            myPen.Freeze();
            dc.DrawRectangle(mySolidColorBrush, myPen, myRect);

            // chart
            var geometry = new StreamGeometry();
            using (StreamGeometryContext ctx = geometry.Open())
            {
                ctx.BeginFigure(new Point(0, this.Height), true /* is filled */, true /* is closed */);
                for (int i = 10; i <= 180; i += 10)
                {
                    double radians = 3.1415 * i / 180.0;
                    double x = this.Width * i / 180;
                    double y = this.Height - this.Height * Math.Sin(radians);
                    ctx.LineTo(new Point((int)x, (int)y), true /* is stroked */, false /* is smooth join */);
                }
            }
            geometry.Freeze();

            dc.DrawGeometry(null, myPen, geometry);
        }
    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            InitializeFunctionMinValueChart();
        }

        // Add y = sqrt(x) line to the graph for demonstration purpose
        private void InitializeFunctionMinValueChart()
        {
            List<Point> points = new List<Point>();
            for (int i = 100; i >= 0; i--)
                points.Add(new Point(i, Math.Sqrt(i)));

            var ds = new EnumerableDataSource<Point>(points);
            ds.SetXMapping(p => p.X);
            ds.SetYMapping(p => p.Y);
            chart.AddLineGraph(ds, Colors.Green, 2, "wart. funkcji"); 
        }

    }
}
