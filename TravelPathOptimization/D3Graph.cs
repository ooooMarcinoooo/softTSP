using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace TravelPathOptimization
{
    public class D3Graph : ChartPlotter
    {
        public D3Graph() { }

        public void AddLine(List<Point> points, string description)
        {
            var ds = new EnumerableDataSource<Point>(points);
            ds.SetXMapping(p => p.X);
            ds.SetYMapping(p => p.Y);
            this.AddLineGraph(ds, Colors.Green, 2, description); 
        }
    };
}
