using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Geometry
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
        IGeometry Shape { get; }
        /// <summary>
        /// 标绘元素控制点
        /// </summary>
        IPoint[] FixedPoints { get; }
        /// <summary>
        /// 设值标绘元素的控制点
        /// </summary>
        /// <param name="fixedPoints">控制点</param>
        void PutCoords(IPoint[] fixedPoints);
    }
}
