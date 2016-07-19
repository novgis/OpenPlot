using System;
using System.Collections.Generic;
using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Geometry
{
    public abstract class AbsArrowPlot : IPlot
    {
        //IPlot
        public abstract PlotType PlotType { get; }
        public IGeometry Shape { get; private set; }
        /// <summary>
        /// 箭标轴线控制点最少个数
        /// </summary>
        protected abstract int MinFixedPointsCount { get; }
        /// <summary>
        /// 箭标轴线控制点
        /// </summary>
        protected IPoint[] FixedPoints { get; set; }
        /// <summary>
        /// 箭标箭身控制点
        /// </summary>
        protected List<IPoint> ControlPoints { get; set; }

        public void PutCoords(IPoint[] fixedPoints)
        {
            if (fixedPoints.Length != MinFixedPointsCount)
                throw new ArgumentException(string.Format("{0} 箭标控制点个数为 {1} 个", PlotType, MinFixedPointsCount));
            FixedPoints = fixedPoints;
            ControlPoints = GetControlPoints();
            Shape = GetShape();
        }

        protected abstract IGeometry GetShape();
        protected abstract List<IPoint> GetControlPoints();
    }
}
