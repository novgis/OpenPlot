using System;
using ESRI.ArcGIS.Geometry;

namespace NovGIS.OpenPlot.Core
{
    public static class MathUtil
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
        /// <param name="pointA"></param>
        /// <param name="pointB"></param>
        /// <param name="pointP"></param>
        /// <returns>LEFT,RIGHT,ONLINE</returns>
        public static string CalculateAzimuth(IPoint pointA, IPoint pointB, IPoint pointP)
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
            double ax = pointB.X - pointA.X;
            double ay = pointB.Y - pointA.Y;
            //b向量坐标(AP)
            double bx = pointP.X - pointA.X;
            double by = pointP.Y - pointA.Y;
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
        /// <param name="pointA"></param>
        /// <param name="pointB"></param>
        /// <param name="pointC"></param>
        /// <returns></returns>
        public static IPoint GetSymmetryPoint(IPoint pointA, IPoint pointB, IPoint pointC)
        {
            string value = CalculateAzimuth(pointA, pointB, pointC);
            IPoint pointD = new PointClass();
            ILine AB = new LineClass { FromPoint = pointB, ToPoint = pointA };
            if (value == "LEFT")
            {
                AB = new LineClass { FromPoint = pointB, ToPoint = pointA };
            }
            else
            {
                AB = new LineClass { FromPoint = pointA, ToPoint = pointB };
            }
            IPoint pointS = new PointClass();
            pointS.PutCoords((pointA.X + pointB.X) / 2, (pointA.Y + pointB.Y) / 2);
            ILine normalS = new LineClass();
            AB.QueryNormal(esriSegmentExtension.esriNoExtension, 0.5, true, 100 * AB.Length, normalS);
            IPoint pointZ = new PointClass();
            if (normalS.Angle.Equals(0))//平行x轴
            {
                pointZ.PutCoords(pointC.X, pointS.Y);
            }
            else if (normalS.Angle.Equals(1.0 / 4.0 * Math.PI))//垂直x轴
            {
                pointZ.PutCoords(pointS.X, pointC.Y);
            }
            else
            {
                double d = GetMinDistance(pointA, pointB, pointC);
                normalS.QueryPoint(esriSegmentExtension.esriNoExtension, d, false, pointZ);
            }
            pointD.PutCoords((2.0 * pointZ.X - pointC.X), (2.0 * pointZ.Y - pointC.Y));
            return pointD;
        }
        /// <summary>
        /// 计算C点到AB连续的距离
        /// </summary>
        /// <param name="pointA"></param>
        /// <param name="pointB"></param>
        /// <param name="pointC"></param>
        /// <returns></returns>
        public static double GetMinDistance(IPoint pointA, IPoint pointB, IPoint pointC)
        {
            double distance;
            if (pointA.X.Equals(pointB.X))
            {
                distance = Math.Abs(pointC.X - pointA.X);
                return distance;
            }
            double lineK = (pointB.Y - pointA.Y) / (pointB.X - pointA.X);
            double lineC = (pointB.X * pointA.Y - pointA.X * pointB.Y) / (pointB.X - pointA.X);
            distance = Math.Abs(lineK * pointC.X - pointC.Y + lineC) / (Math.Sqrt(lineK * lineK + 1));
            return distance;
        }
    }
}
