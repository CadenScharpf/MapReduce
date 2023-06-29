using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

public static class HttpHelpers
{
    static readonly HttpClient client = new HttpClient();
    public static string GetResponseString(string url)
    {
        var httpClient = new System.Net.Http.HttpClient();
        var response = httpClient.GetAsync(url).Result;
        var contents = response.Content.ReadAsStringAsync().Result;
        return contents;
    }

    public static XmlNode XmlStringToXmlNode(string xmlInputString)
    {
        if (String.IsNullOrEmpty(xmlInputString.Trim())) { throw new ArgumentNullException("xmlInputString"); }
        var xd = new XmlDocument();
        using (var sr = new StringReader(xmlInputString))
        {
            xd.Load(sr);
        }
        return xd;
    }

    public static string GetResponseBody(string url)
    {
        return XmlStringToXmlNode(GetResponseString(url)).InnerText;
    }
}