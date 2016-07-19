using System;
using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Core
{
    public static class MathHelper
    {
        /// <summary>
        /// 计算两点的平面弧度
        /// </summary>
        /// <param name="x1">起始点x坐标</param>
        /// <param name="y1">起始点y坐标</param>
        /// <param name="x2">终点x坐标</param>
        /// <param name="y2">终点y坐标</param>
        /// <returns>两点平面夹角(弧度)</returns>
        public static double CalculateRadian(double x1, double y1, double x2, double y2)
        {
            //求得弧度（反正切函数）
            double radian = Math.Atan(Math.Abs((y2 - y1) / (x2 - x1)));
            //公式：
            //2π 弧度 = 360 度
            //1 弧度 = 180/π 度
            //角度=弧度*180/π
            //
            //            double angle = radian * 180 / Math.PI;
            //
            if (x2 > x1 && y2 > y1) //1象限
            {

            }
            else if (x2 < x1 && y2 > y1) //2象限
            {
                radian = Math.PI - radian;
            }
            else if (x2 < x1 && y2 < y1) //3象限
            {
                radian = radian + Math.PI;
            }
            else if (x2 > x1 && y2 < y1) //4象限
            {
                radian = 2 * Math.PI - radian;
            }
            return Math.Round(radian, 2);
        }
        /// <summary>
        /// 计算两点的平面角度
        /// </summary>
        /// <param name="x1">起始点x坐标</param>
        /// <param name="y1">起始点y坐标</param>
        /// <param name="x2">终点x坐标</param>
        /// <param name="y2">终点y坐标</param>
        /// <returns>两点平面夹角(角度)</returns>
        public static double CalculateAngle(double x1, double y1, double x2, double y2)
        {
            //求得弧度
            double radian = Math.Atan(Math.Abs((y2 - y1) / (x2 - x1)));
            double angle = radian * 180 / Math.PI;
            //
            if (x2 > x1 && y2 > y1) //1象限
            {

            }
            else if (x2 < x1 && y2 > y1) //2象限
            {
                angle = 180 - angle;
            }
            else if (x2 < x1 && y2 < y1) //3象限
            {
                angle = angle + 180;
            }
            else if (x2 > x1 && y2 < y1) //4象限
            {
                angle = 360 - angle;
            }
            return Math.Round(angle, 2);
        }
        /// <summary>
        /// 判断P点在AB有向线段的方位
        /// </summary>
        /// <param name="esriA"></param>
        /// <param name="esriB"></param>
        /// <param name="esriP"></param>
        /// <returns>LEFT,RIGHT,ONLINE</returns>
        public static string CalculateAzimuth(IPoint esriA, IPoint esriB, IPoint esriP)
        {
            /*
             * 向量叉积算法
             * a×b = x1*y2 - x2*y1
             * 若 a × b < 0 , 则a在b的逆时针方向
             * 若 a × b > 0 , 则a在b的顺时针方向
             * 若 a × b = 0 , 则a与b共线，但可能同向也可能反
             */
            string strResult = "";
            //a向量坐标(AB)
            double ax = esriB.X - esriA.X;
            double ay = esriB.Y - esriA.Y;
            //b向量坐标(AP)
            double bx = esriP.X - esriA.X;
            double by = esriP.Y - esriA.Y;
            //a向量和b向量的叉积
            double value = ax * by - ay * bx;
            //判断规律
            if (value > 0) strResult = "LEFT";
            else if (value < 0) strResult = "RIGHT";
            else strResult = "ONLINE";
            return strResult;
        }
        /// <summary>
        /// 计算点C关于AB连线的中垂线的对称点D
        /// </summary>
        /// <param name="esriA"></param>
        /// <param name="esriB"></param>
        /// <param name="esriC"></param>
        /// <returns></returns>
        public static IPoint GetSymmetryPoint(IPoint esriA, IPoint esriB, IPoint esriC)
        {
            string value = CalculateAzimuth(esriA, esriB, esriC);
            IPoint esriD = new PointClass();
            ILine AB = new LineClass { FromPoint = esriB, ToPoint = esriA };
            if (value == "LEFT")
            {
                AB = new LineClass { FromPoint = esriB, ToPoint = esriA };
            }
            else
            {
                AB = new LineClass { FromPoint = esriA, ToPoint = esriB };
            }
            IPoint esriS = new PointClass();
            esriS.PutCoords((esriA.X + esriB.X) / 2, (esriA.Y + esriB.Y) / 2);
            ILine normalS = new LineClass();
            AB.QueryNormal(esriSegmentExtension.esriNoExtension, 0.5, true, 100 * AB.Length, normalS);
            IPoint esriZ = new PointClass();
            if (normalS.Angle.Equals(0))//平行x轴
            {
                esriZ.PutCoords(esriC.X, esriS.Y);
            }
            else if (normalS.Angle.Equals(1.0 / 4.0 * Math.PI))//垂直x轴
            {
                esriZ.PutCoords(esriS.X, esriC.Y);
            }
            else
            {
                double d = GetMinDistance(esriA, esriB, esriC);
                normalS.QueryPoint(esriSegmentExtension.esriNoExtension, d, false, esriZ);
            }
            esriD.PutCoords((2.0 * esriZ.X - esriC.X), (2.0 * esriZ.Y - esriC.Y));
            return esriD;
        }
        /// <summary>
        /// 计算C点到AB连续的距离
        /// </summary>
        /// <param name="esriA"></param>
        /// <param name="esriB"></param>
        /// <param name="esriC"></param>
        /// <returns></returns>
        public static double GetMinDistance(IPoint esriA, IPoint esriB, IPoint esriC)
        {
            double distance;
            if (esriA.X.Equals(esriB.X))
            {
                distance = Math.Abs(esriC.X - esriA.X);
                return distance;
            }
            double lineK = (esriB.Y - esriA.Y) / (esriB.X - esriA.X);
            double lineC = (esriB.X * esriA.Y - esriA.X * esriB.Y) / (esriB.X - esriA.X);
            distance = Math.Abs(lineK * esriC.X - esriC.Y + lineC) / (Math.Sqrt(lineK * lineK + 1));
            return distance;
        }
    }
}
