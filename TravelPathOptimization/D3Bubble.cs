using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace TravelPathOptimization
{

    public class D3Bubble : ChartPlotter
    {
        public D3Bubble()
        {
            this.AxisGrid.Visibility = Visibility.Hidden;
        }


        public void AddPoints(List<Point> points, string description)
        {
            var ds = new EnumerableDataSource<Point>(points);
            ds.SetXMapping(p => p.X);
            ds.SetYMapping(p => p.Y);
            var m = new CircleElementPointMarker { Size = 15.0, Fill = Brushes.Red };

            Pen pen = new Pen(null, 1.0);
            Description d = null;
            this.AddLineGraph( ds, pen, m, d);
        }
    };
}

