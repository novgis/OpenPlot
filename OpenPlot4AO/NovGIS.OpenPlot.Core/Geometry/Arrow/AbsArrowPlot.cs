using System;
using System.Collections.Generic;
using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Geometry
{
    public abstract class AbsArrowPlot : IPlot
    {
        public abstract PlotType PlotType { get; }
        public IGeometry Shape { get; private set; }
        public IPoint[] ControlPoints { get; private set; }

        /// <summary>
        /// 箭标最小控制点数
        /// <remarks>用于校验传入的控制点集合</remarks>
        /// </summary>
        protected abstract int ControlPointsCount { get; }
        /// <summary>
        /// 由计算得来的箭标箭身锚点
        /// </summary>
        protected List<IPoint> AnchorPoints { get; private set; }
        protected abstract List<IPoint> GetAnchorPoints();
        protected abstract IGeometry GetShape();

        public void PutCoords(IPoint[] controlPoints)
        {
            if (controlPoints.Length != this.ControlPointsCount)
                throw new ArgumentException(string.Format("箭标的控制点数必须为 {0} 个", ControlPointsCount));
            this.ControlPoints = controlPoints;
            this.AnchorPoints = GetAnchorPoints();
            this.Shape = GetShape();
        }
    }
}
