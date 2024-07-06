using Adapter.implementations;
using Adapter.interfaces;

namespace Adapter;

static class Program
{
    static void Main(string[] args)
    {
        string xmlData = @"
            <root>
                <person>
                    <name>John Doe</name>
                    <age>30</age>
                    <city>New York</city>
                </person>
            </root>";

        XmlProcessor xmlProcessor = new XmlProcessor();
        IJsonConverter jsonConverter = new XmlToJsonAdapter(xmlProcessor);

        Console.WriteLine("XML original:");
        Console.WriteLine(xmlData);

        string jsonResult = jsonConverter.ConvertToJson(xmlData);

        Console.WriteLine("\nJSON convertido:");
        Console.WriteLine(jsonResult);
    }
}