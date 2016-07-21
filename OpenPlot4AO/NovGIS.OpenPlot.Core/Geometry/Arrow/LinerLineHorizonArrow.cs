using System;
using System.Collections.Generic;
using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Geometry
{
    public class LinerLineHorizonArrow : AbsArrowPlot
    {
        public override PlotType PlotType { get { return PlotType.eLinerLineHorizonArrow; } }

        protected override int ControlPointsCount { get { return 2; } }

        protected override List<IPoint> GetAnchorPoints()
        {
            throw new NotImplementedException();
        }

        protected override IGeometry GetShape()
        {
            throw new NotImplementedException();
        }
    }
}
