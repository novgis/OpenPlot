using ESRI.ArcGIS.SystemUI;

namespace NovGIS.OpenPlot.SystemUI
{
    public abstract class AbsCommand : ICommand
    {
        //ICommand
        protected int _bitmap = -1;
        protected string _caption = "";
        protected string _category = "";
        protected bool _checked = false;
        protected bool _enabled = true;
        protected int _helpContextID = -1;
        protected string _helpFile;
        protected string _message;
        protected string _name;
        protected string _tooltip;

        public virtual int Bitmap { get { return _bitmap; } }
        public virtual string Caption { get { return _caption; } }
        public virtual string Category { get { return _category; } }
        public virtual bool Checked { get { return _checked; } }
        public virtual bool Enabled { get { return _enabled; } }
        public virtual int HelpContextID { get { return _helpContextID; } }
        public virtual string HelpFile { get { return _helpFile; } }
        public virtual string Message { get { return _message; } }
        public virtual string Name { get { return _name; } }
        public virtual string Tooltip { get { return _tooltip; } }

        public virtual void OnClick() { }
        public virtual void OnCreate(object hook) { }
    }
}
