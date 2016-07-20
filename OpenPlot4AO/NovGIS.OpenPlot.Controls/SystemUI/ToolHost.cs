using ESRI.ArcGIS.SystemUI;

namespace NovGIS.OpenPlot.SystemUI
{
    public class ToolHost : CommandHost, ITool
    {
        private bool _mouseDown;
        private int _mouseDownX = -1;
        private int _mouseDownY = -1;

        public virtual int Cursor { get { return -1; } }

        public virtual void OnMouseDown(int button, int shift, int x, int y)
        {
            this._mouseDownX = x;
            this._mouseDownY = y;
            this._mouseDown = true;
        }
        public virtual void OnMouseUp(int button, int shift, int x, int y)
        {
            if (this._mouseDownX == x && this._mouseDownY == y)
                this.OnMouseClick(button, shift, x, y);
            this._mouseDownX = -1;
            this._mouseDownY = -1;
            this._mouseDown = false;
        }
        public virtual void OnMouseMove(int button, int shift, int x, int y) { }
        public virtual void OnDblClick() { }
        public virtual void OnKeyDown(int keyCode, int shift) { }
        public virtual void OnKeyUp(int keyCode, int shift) { }
        public virtual bool OnContextMenu(int x, int y) { return false; }
        public virtual void Refresh(int hdc) { }
        public virtual bool Deactivate() { return true; }
        //扩展OnMouseClick事件
        public virtual void OnMouseClick(int button, int shift, int x, int y) { }
        //public virtual void OnMouseHover(int button, int shift, int x, int y) { }
    }
}
