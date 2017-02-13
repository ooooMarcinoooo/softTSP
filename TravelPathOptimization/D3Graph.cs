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
    class MyMarker : ElementPointMarker
    {

        public override UIElement CreateMarker()
        {

            return new UIElement();
        }

        public override void SetPosition(UIElement marker, Point screenPoint)
        {
           
        }
    };

    public class D3Graph : ChartPlotter
    {
        
        public D3Graph() { }

        public void AddLine(List<Point> points, string description)
        {
            var ds = new EnumerableDataSource<Point>(points);
            ds.SetXMapping(p => p.X);
            ds.SetYMapping(p => p.Y);
            Microsoft.Research.DynamicDataDisplay.PointMarkers.ElementPointMarker m = 
                new CircleElementPointMarker { Size = 15.0, Fill = Brushes.Red };

            Pen pen = new Pen(Brushes.Black, 1.0);
            Description d = null;
            this.AddLineGraph( ds, pen,m, d); 
        }
    };
}
