using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Core.Geometry
{
    public abstract class AbsArrowPlot:IPlot
    {
        public abstract PlotType PlotType { get; }

        public IGeometry PlotShape
        {
            get { throw new NotImplementedException(); }
        }

        public void PutCoords(IPoint[] fixedPoints)
        {
            throw new NotImplementedException();
        }
    }
}
