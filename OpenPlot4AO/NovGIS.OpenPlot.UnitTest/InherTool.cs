using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NovGIS.OpenPlot.Carto;

namespace NovGIS.OpenPlot.UnitTest
{
    public class InherTool : AbsTool
    {
        public override void OnMouseDown(int button, int shift, int x, int y)
        {
            base.OnMouseDown(button, shift, x, y);
            Console.WriteLine("Inherit tool mouse down");
        }

        public override void OnMouseUp(int button, int shift, int x, int y)
        {
            base.OnMouseUp(button, shift, x, y);
            Console.WriteLine("Inherit tool mouse up");
        }

        public override void OnMouseClick(int button, int shift, int x, int y)
        {
            //base.OnMouseClick(button, shift, x, y);

            Console.WriteLine("Inherit tool mouse click");
        }
    }
}
