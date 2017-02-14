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

    public class D3CitiesPaths : ChartPlotter
    {
        public D3CitiesPaths()
        {
            this.AxisGrid.Visibility = Visibility.Hidden;
            this.HorizontalAxis.Remove();
            this.VerticalAxis.Remove();
        }

        public void AddPoints(List<Point> points, string description)
        {
            var ds = new EnumerableDataSource<Point>(points);
            ds.SetXMapping(p => p.X);
            ds.SetYMapping(p => p.Y);
            var m = new CircleElementPointMarker {  ToolTipText="city", Size = 15.0, Fill = Brushes.Green };

            Pen pen = new Pen(Brushes.Black, 1.0);
            Description d = null;
            this.AddLineGraph( ds, pen, m, d);
        }
    };
}
