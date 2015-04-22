using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Cielo4Net
{
    internal static class XmlUtility
    {
        internal static string ToXml<T>(this T source)
        {
            return source.ToXml(Encoding.GetEncoding("iso-8859-1"));
        }

        internal static string ToXml<T>(this T source, Encoding encoding)
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

        internal static T ToObject<T>(this string source)
        {
            return source.ToObject<T>(Encoding.GetEncoding("iso-8859-1"));
        }

        internal static T ToObject<T>(this string source, Encoding encoding)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));

            using (var memoryStream = new MemoryStream(encoding.GetBytes(source)))
            {
                using (var xmlTextReader = new XmlTextReader(memoryStream))
                {
                    return (T)xmlSerializer.Deserialize(xmlTextReader);
                }
            }
        }
    }
}
