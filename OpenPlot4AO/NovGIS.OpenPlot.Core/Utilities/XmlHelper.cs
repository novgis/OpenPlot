using System.IO;
using System.Xml.Serialization;

namespace NovGIS.OpenPlot.Core
{
    public static class XmlHelper
    {
        /// <summary>
        /// 泛型对象克隆
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="realObject"></param>
        /// <returns></returns>
        public static T Clone<T>(T realObject)
        {
            using (Stream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stream, realObject);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)serializer.Deserialize(stream);
            }
        }
    }
}
