using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace GoogleTrendViewer.Services;

public static class XmlExtensions
{
    public static IEnumerable<XmlNode> AsQueryable(this XmlNodeList list)
    {
        if (list == null) return new List<XmlNode>();
        return list.Cast<XmlNode>();
    }
}

