using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Cielo
{
    public static class ObjectExtensions
    {
        public static string ToXmlString<T>(this T source)
        {
            return source.ToXmlString(Encoding.GetEncoding("iso-8859-1"));
        }

        public static string ToXmlString<T>(this T source, Encoding encoding)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));

            using (var memoryStream = new MemoryStream())
            {
                using (var xmlTextWriter = new XmlTextWriter(memoryStream, encoding))
                {
                    xmlSerializer.Serialize(xmlTextWriter, source);

                    return encoding.GetString(memoryStream.ToArray());                    
                }
            }
        }
    }
}
