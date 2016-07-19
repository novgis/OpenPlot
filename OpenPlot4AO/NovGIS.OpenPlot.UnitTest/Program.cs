using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS;
using NovGIS.OpenPlot.SystemUI;

namespace NovGIS.OpenPlot.UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ProductCode.EngineOrDesktop);

//            AbsTool tool = new AbsTool();
//            tool.OnMouseDown(0, 0, 10, 10);
//            tool.OnMouseUp(0, 0, 10, 10);
//
//            InherTool inher = new InherTool();
//            inher.OnMouseDown(0, 0, 10, 10);
//            inher.OnMouseUp(0, 0, 10, 10);

            Console.Read();
        }
    }
}
