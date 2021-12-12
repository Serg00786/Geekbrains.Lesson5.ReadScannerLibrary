using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ReadScannerLibrary
{
    public class StrategySaveToXML : IStrategy
    {
        public bool DoAlgorithm(DataModel data)
        {
            if (!File.Exists("XMLLog.xml"))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create("XMLLog.xml", xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Scanner");

                    xmlWriter.WriteStartElement("Scanner");
                    xmlWriter.WriteElementString("ID", Encoding.ASCII.GetString(data.ID));
                    xmlWriter.WriteElementString("CPULoad", Encoding.ASCII.GetString(data.CPULoad));
                    xmlWriter.WriteElementString("MemoryLoad", Encoding.ASCII.GetString(data.MemoryLoad));
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load("XMLLog.xml");
                XElement root = xDocument.Element("Scanner");
                IEnumerable<XElement> rows = root.Descendants("Scanner");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Scanner",
                   new XElement("ID", Encoding.ASCII.GetString(data.ID)),
                   new XElement("CPULoad", Encoding.ASCII.GetString(data.CPULoad)),
                   new XElement("MemoryLoad", Encoding.ASCII.GetString(data.MemoryLoad))));
                xDocument.Save("XMLLog.xml");
            }

            return true;
        }
    }
}
