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
using System.Collections.ObjectModel;

namespace TravelPathOptimization
{

    public class DataObject
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void InitializeCitiesPathsChart()
        {
            cities_paths_chart.RemoveUserElements();
            Random r = new Random();

            List<Point> cities = new List<Point>();
            for (double i = 0; i <= 2.01; i += 0.1 )
                cities.Add(new Point(Math.Sin(i * 3.1415) + r.NextDouble()/2, Math.Cos(i * 3.1415) + r.NextDouble()/2));
            cities.Add(cities.First());
            cities_paths_chart.AddPoints(cities, " "); 
        }

        private void IniitalizeBubbleChart()
        {
            bubble_chart.RemoveUserElements();

            Random r = new Random();
            List<Point> bubbles = new List<Point>();
            for (double i = 0; i <= 2.01; i += 0.1)
                bubbles.Add(new Point(i, i + 1 + r.NextDouble() / 2));
            bubble_chart.AddPoints(bubbles, " ");
        }

        private void InitializeDataGrid()
        {
            var list = new ObservableCollection<DataObject>();
            list.Add(new DataObject() { A = 6, B = 7, C = 5, D = 3, E = 8 });
            list.Add(new DataObject() { A = 5, B = 8, C = 4, D = 2, E = 5 });
            list.Add(new DataObject() { A = 4, B = 3, C = 0, D = 9, E = 6 });
            this.datagrid.ItemsSource = list;
        }

        private void DoWorkBtn_Click(object sender, RoutedEventArgs e)
        {
            InitializeCitiesPathsChart();
            IniitalizeBubbleChart();
            InitializeDataGrid();
        }
    }
}
