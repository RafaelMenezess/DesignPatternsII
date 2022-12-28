using System.IO;
using System.Xml.Serialization;

namespace DesignPatternsII.Cap8
{
    class GeradorXml
    {
        public string GeraXml(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
