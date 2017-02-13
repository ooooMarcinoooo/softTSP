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

        // Add y = sqrt(x) line to the "chart" graph for demonstration purpose
        private void InitializeFunctionMinValueChart()
        { 
            List<Point> points = new List<Point>();
            for (double i = 0; i <= 2.01; i += 0.1 )
                points.Add(new Point(Math.Sin(i * 3.1415), Math.Cos(i * 3.1415)));

            chart.AddLine(points, "wart. funkcji");
        }

    }
}
