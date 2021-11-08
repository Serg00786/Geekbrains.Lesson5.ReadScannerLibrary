using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadScannerLibrary
{
    public class StrategySaveToXML : IStrategy
    {
        public bool DoAlgorithm(DataModel data)
        {
            //var settings = new System.Xml.XmlWriterSettings
            //{
            //    OmitXmlDeclaration = true,
            //    Indent = true
            //};

            //using (XmlWriter writer = XmlWriter.Create(Console.Out, settings))
            //{
            //    writer.WriteStartElement("Stock");
            //    writer.WriteAttributeString("Symbol", q.symbol);
            //    writer.WriteElementString("Price", XmlConvert.ToString(""));
            //    writer.WriteElementString("Change", XmlConvert.ToString(q.change));
            //    writer.WriteElementString("Volume", XmlConvert.ToString(q.volume));
            //    writer.WriteEndElement();
            //}


            return true;
        }
    }
}
