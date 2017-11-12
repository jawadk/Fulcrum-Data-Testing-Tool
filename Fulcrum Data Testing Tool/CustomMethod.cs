using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Fulcrum_Data_Testing_Tool
{
    public static class CustomMethod
    {
        public static string GetMessageID(XmlDocument xDoc)
        {
            string MessageID = xDoc.SelectSingleNode("SetProductHierarchy/ProductHierarchyRequest/MessageID").InnerText;
            return MessageID;
        }

    }
}
