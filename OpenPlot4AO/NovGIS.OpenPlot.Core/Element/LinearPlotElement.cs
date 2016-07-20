using System;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Element
{
    public class LinearPlotElement : LineElement, IElement, IElementProperties, IElementProperties2, IElementProperties3, ILineElement, IGraphicElement, IBoundsProperties, IElementEditVertices, ITransform2D, IPropertySupport, IPersistStream, IClone, IXMLSerialize
    {


        public void QueryBounds(IDisplay Display, IEnvelope Bounds)
        {
            throw new NotImplementedException();
        }

        public void QueryOutline(IDisplay Display, IPolygon Outline)
        {
            throw new NotImplementedException();
        }

        public bool HitTest(double x, double y, double Tolerance)
        {
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        public IGeometry Geometry
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public ISelectionTracker SelectionTracker
        {
            get { throw new NotImplementedException(); }
        }

        public bool Locked
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void Activate(IDisplay Display)
        {
            throw new NotImplementedException();
        }

        public void Draw(IDisplay Display, ITrackCancel TrackCancel)
        {
            throw new NotImplementedException();
        }

        bool IElementProperties2.CanRotate()
        {
            throw new NotImplementedException();
        }

        string IElementProperties3.Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        string IElementProperties3.Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        bool IElementProperties3.AutoTransform
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        object IElementProperties3.CustomProperty
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        double IElementProperties3.ReferenceScale
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public esriAnchorPointEnum AnchorPoint
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        ISpatialReference IElementProperties3.SpatialReference
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        bool IElementProperties3.CanRotate()
        {
            throw new NotImplementedException();
        }

        string IElementProperties2.Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        string IElementProperties2.Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        bool IElementProperties2.AutoTransform
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        object IElementProperties2.CustomProperty
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        double IElementProperties2.ReferenceScale
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        string IElementProperties.Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        string IElementProperties.Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        bool IElementProperties.AutoTransform
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        object IElementProperties.CustomProperty
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public ILineSymbol Symbol
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        ISpatialReference IGraphicElement.SpatialReference
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool FixedAspectRatio
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool FixedSize
        {
            get { throw new NotImplementedException(); }
        }

        public ISelectionTracker GetMoveVerticesSelectionTracker()
        {
            throw new NotImplementedException();
        }

        public bool MovingVertices
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void Move(double dx, double dy)
        {
            throw new NotImplementedException();
        }

        public void MoveVector(ILine v)
        {
            throw new NotImplementedException();
        }

        public void Scale(IPoint Origin, double sx, double sy)
        {
            throw new NotImplementedException();
        }

        public void Rotate(IPoint Origin, double rotationAngle)
        {
            throw new NotImplementedException();
        }

        public void Transform(esriTransformDirection direction, ITransformation transformation)
        {
            throw new NotImplementedException();
        }

        public bool Applies(object pUnk)
        {
            throw new NotImplementedException();
        }

        public bool CanApply(object pUnk)
        {
            throw new NotImplementedException();
        }

        public object Apply(object newObject)
        {
            throw new NotImplementedException();
        }

        public object get_Current(object pUnk)
        {
            throw new NotImplementedException();
        }

        void IPersist.GetClassID(out Guid pClassID)
        {
            throw new NotImplementedException();
        }

        public void IsDirty()
        {
            throw new NotImplementedException();
        }

        public void Load(IStream pstm)
        {
            throw new NotImplementedException();
        }

        public void Save(IStream pstm, int fClearDirty)
        {
            throw new NotImplementedException();
        }

        public void GetSizeMax(out _ULARGE_INTEGER pcbSize)
        {
            throw new NotImplementedException();
        }

        void IPersistStream.GetClassID(out Guid pClassID)
        {
            throw new NotImplementedException();
        }

        public IClone Clone()
        {
            throw new NotImplementedException();
        }

        public void Assign(IClone src)
        {
            throw new NotImplementedException();
        }

        public bool IsEqual(IClone other)
        {
            throw new NotImplementedException();
        }

        public bool IsIdentical(IClone other)
        {
            throw new NotImplementedException();
        }

        public void Serialize(IXMLSerializeData data)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(IXMLSerializeData data)
        {
            throw new NotImplementedException();
        }
    }
}
