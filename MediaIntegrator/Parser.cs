using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace media_integrator
{
    class Parser
    {
        // Product-klassens fält från MediaShop.
        private static readonly string[] PRODUCT_FIELDS = new string[5]
        {
            "Id", "Name", "Price", "Stock", "ProductType"
        };

        // Item-fält från SimpleMedia.
        private static readonly string[] ITEM_FIELDS = new string[9]
        {
            "Name", "Count", "Price", "Comment", "Artist", "Publisher", "Genre", "Year", "ProductID"
        };

        //=============== Public Functions ===============//
        public void ConvertCSVToXML(FileInfo fi, string outputDir)
        {
            List<string> lines = File.ReadAllLines(fi.FullName).ToList();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter xmlWriter = XmlWriter.Create(outputDir + @"\products.xml", settings);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Inventory");
            foreach (string line in lines)
            {
                if (line != "")
                {
                    xmlWriter.WriteStartElement("Item");
                    string[] productValues = line.Split('|');
                    string[] itemValues = new string[9];

                    itemValues[0] = productValues[1];
                    itemValues[1] = productValues[3];
                    itemValues[2] = productValues[2];
                    itemValues[3] = "";
                    itemValues[4] = "";
                    itemValues[5] = "";
                    itemValues[6] = "";
                    itemValues[7] = "0";
                    itemValues[8] = productValues[0];

                    for (int i = 0; i < itemValues.Length; i++)
                    {
                        xmlWriter.WriteStartElement(ITEM_FIELDS[i]);
                        xmlWriter.WriteValue(itemValues[i]);
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();
                }
            }
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }

        public void ConvertXMLToCSV(FileInfo fi, string outputDir)
        {
            StreamReader streamReader = new StreamReader(fi.FullName);
            XmlReaderSettings settings = new XmlReaderSettings();
            XmlReader xmlReader = XmlReader.Create(streamReader, settings);

            System.Diagnostics.Debug.WriteLine("Starting XML2CSV");
            while (xmlReader.Read())
            {
                System.Diagnostics.Debug.WriteLine("Reading...");
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Item"))
                {
                    System.Diagnostics.Debug.WriteLine("Found Item...");
                    if (xmlReader.HasAttributes)
                    {
                        System.Diagnostics.Debug.WriteLine(xmlReader.GetAttribute("Name"));
                    }
                }
            }

            xmlReader.Close();
            streamReader.Close();
        }

    }
}
