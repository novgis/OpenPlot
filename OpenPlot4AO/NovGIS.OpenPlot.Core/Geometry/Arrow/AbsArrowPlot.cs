using System;
using System.Collections.Generic;
using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Geometry
{
    public abstract class AbsArrowPlot : IPlot
    {
        public abstract PlotType PlotType { get; }
        public IGeometry Shape { get; private set; }
        public IPoint[] FixedPoints { get; private set; }

        /// <summary>
        /// 箭标最小控制点数
        /// <remarks>用于校验传入的控制点集合</remarks>
        /// </summary>
        protected abstract int FixedPointsCount { get; }
        /// <summary>
        /// 由计算得来的箭标箭身控制点
        /// </summary>
        protected List<IPoint> ControlPoints { get; private set; }
        protected abstract IGeometry GetShape();
        protected abstract List<IPoint> GetControlPoints();

        public void PutCoords(IPoint[] fixedPoints)
        {
            if (fixedPoints.Length != FixedPointsCount)
                throw new ArgumentException(string.Format("箭标的控制点个数必须有 {0} 个", FixedPointsCount));
            FixedPoints = fixedPoints;
            ControlPoints = GetControlPoints();
            Shape = GetShape();
        }
    }
}
