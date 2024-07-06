using System.Xml.Linq;

namespace Adapter.implementations;

public class XmlProcessor
{
    public XDocument ProcessXml(string xmlData)
    {
        return XDocument.Parse(xmlData);
    }
}