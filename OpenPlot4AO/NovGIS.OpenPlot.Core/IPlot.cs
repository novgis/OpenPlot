using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Core
{
    public interface IPlot
    {
        /// <summary>
        /// 标绘元素类型
        /// </summary>
        PlotType PlotType { get; }
        /// <summary>
        /// 标绘元素几何图形
        /// </summary>
        IGeometry PlotShape { get; }
    }
}
