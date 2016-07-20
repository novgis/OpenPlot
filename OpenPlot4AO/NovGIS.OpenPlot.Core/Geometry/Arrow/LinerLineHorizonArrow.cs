using System;
using System.Collections.Generic;
using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Geometry
{
    public class LinerLineHorizonArrow : AbsArrowPlot
    {
        public override PlotType PlotType { get { return PlotType.eLinerLineHorizonArrow; } }

        protected override int FixedPointsCount { get { return 2; } }

        protected override IGeometry GetShape()
        {
            throw new NotImplementedException();
        }

        protected override List<IPoint> GetControlPoints()
        {
            throw new NotImplementedException();
        }
    }
}
