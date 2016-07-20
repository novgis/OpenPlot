using System;
using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Geometry
{
    public class LinearPlot : IPlot
    {
        public PlotType PlotType { get { return PlotType.eLinear; } }

        public IGeometry Shape { get; private set; }

        public IPoint[] FixedPoints { get; private set; }

        public void PutCoords(IPoint[] fixedPoints)
        {
            if (fixedPoints.Length < 2)
                throw new ArgumentException("传入的标绘元素控制点个数与元素最小控制点数不匹配");
            FixedPoints = fixedPoints;

            object objBefore = Type.Missing;
            object objAfter = Type.Missing;
            ISegmentCollection segment = new PathClass();
            for (int i = 0; i < fixedPoints.Length - 1; i++)
            {
                ILine line = new LineClass { FromPoint = fixedPoints[i], ToPoint = fixedPoints[i + 1] };
                segment.AddSegment((ISegment)line, objBefore, objAfter);
            }
            IPath path = (IPath)segment;
            IGeometryCollection polyline = new PolylineClass();
            polyline.AddGeometry(path, ref objBefore, ref objAfter);
            IGeometry geometry = (IGeometry)polyline;
            //            ITopologicalOperator topo = polyline as ITopologicalOperator;
            //            topo.Simplify();
            Shape = geometry;
        }
    }
}
