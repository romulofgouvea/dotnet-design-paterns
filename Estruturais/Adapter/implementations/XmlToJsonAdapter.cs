using System;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using Adapter.interfaces;


namespace Adapter.implementations;

public class XmlToJsonAdapter : IJsonConverter
{
    private readonly XmlProcessor _xmlProcessor;

    public XmlToJsonAdapter(XmlProcessor xmlProcessor)
    {
        _xmlProcessor = xmlProcessor;
    }

    public string ConvertToJson(string xmlData)
    {
        XDocument xdoc = _xmlProcessor.ProcessXml(xmlData);

        JObject jsonResult = new JObject();
        ConvertXElementToJObject(xdoc.Root, jsonResult);

        return jsonResult.ToString();
    }

    private void ConvertXElementToJObject(XElement element, JObject jObj)
    {
        foreach (var child in element.Elements())
        {
            if (child.HasElements)
            {
                var childJObj = new JObject();
                ConvertXElementToJObject(child, childJObj);
                jObj[child.Name.LocalName] = childJObj;
            }
            else
            {
                jObj[child.Name.LocalName] = child.Value;
            }
        }
    }
}
