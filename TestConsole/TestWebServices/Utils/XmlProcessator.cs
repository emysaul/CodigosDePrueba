using System;
using System.Xml;

namespace TestWebServices.Utils
{

    public static class XmlProcessator
    {


        public static XmlDocument StringToXmlDoc(string str)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(str.Trim());
            return doc;
        }

        public static XmlDocument GetXmlDocument(string fileContent)
        {
            if (string.IsNullOrEmpty(fileContent)) throw new Exception("El cuerpo de la plantilla esta vacío");

            return StringToXmlDoc(fileContent);
        }
    }

}
