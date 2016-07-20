namespace NovGIS.OpenPlot.Geometry
{
    public enum PlotType
    {
        /// <summary>
        /// 空
        /// </summary>
        eNone = -1,
        /// <summary>
        /// 线状元素
        /// </summary>
        eSimpleLine= 0,
        /// <summary>
        /// 标记元素
        /// </summary>
        eSimpleMarker,
        /// <summary>
        /// 外钳击面箭标
        /// </summary>
        ePliersOuterArrow,
        /// <summary>
        /// 外钳击线箭标
        /// </summary>
        ePliersLineOuterArrow,
        /// <summary>
        /// 内钳击面箭标
        /// </summary>
        ePliersInnerArrow,
        /// <summary>
        /// 内钳击线箭标
        /// </summary>
        ePliersLineInnerArrow,
        /// <summary>
        /// 直边燕尾面箭标
        /// </summary>
        eLinerPolygonTailedArrow,
        /// <summary>
        /// 直边平尾面箭标
        /// </summary>
        eLinerPolygonHorizonArrow,
        /// <summary>
        /// 直边平尾线箭标
        /// </summary>
        eLinerLineHorizonArrow,
        /// <summary>
        /// 直边燕尾线箭标
        /// </summary>
        eLinerLineTailedArrow,
        /// <summary>
        /// 直边无尾线箭标
        /// </summary>
        eLinerLineTaillessArrow,
        /// <summary>
        /// 弯边无尾线箭标
        /// </summary>
        eCubicLineTaillessArrow,
        /// <summary>
        /// 弯边燕尾线箭标
        /// </summary>
        eCubicLineTailedArrow,
        /// <summary>
        /// 弯边平尾线箭标
        /// </summary>
        eCubicLineHorizonArrow,
        /// <summary>
        /// 弯边燕尾面箭标
        /// </summary>
        eCubicPolygonTailedArrow,
        /// <summary>
        /// 弯边平尾面箭标
        /// </summary>
        eCubicPolygonHorizonArrow,
        /// <summary>
        /// 曲边燕尾面箭标
        /// </summary>
        eBezierPolygonTailedArrow,
        /// <summary>
        /// 曲边平尾面箭标
        /// </summary>
        eBezierPolygonHorizonArrow,
        /// <summary>
        /// 曲边燕尾线箭标
        /// </summary>
        eBezierLineTailedArrow,
        /// <summary>
        /// 曲边平尾线箭标
        /// </summary>
        eBezierLineHorizonArrow,
        /// <summary>
        /// 曲边无尾线箭标
        /// </summary>
        eBezierLineTaillessArrow
    }
}
