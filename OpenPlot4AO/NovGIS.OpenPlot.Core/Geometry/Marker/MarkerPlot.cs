using System;
using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Geometry
{
    public class MarkerPlot : IPlot
    {
        public PlotType PlotType { get { return PlotType.eMarker; } }

        public IGeometry Shape { get; private set; }

        public IPoint[] ControlPoints { get; private set; }

        public void PutCoords(IPoint[] controlPoints)
        {
            if (controlPoints.Length != 1)
                throw new ArgumentException("传入的标绘元素控制点个数与元素最小控制点数不匹配");
            //GetControlPoints()
            this.ControlPoints = controlPoints;
            //GetShape()
            this.Shape = controlPoints[0];
        }
    }
}
