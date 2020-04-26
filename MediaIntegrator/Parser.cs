using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace media_integrator
{
    // Denna klass hanterar omformatering av xml till csv eller vice versa, och skapandet av nya filer.
    static class Parser
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
        // Konvertering från MediaShop-formatet till SimpleMedia-formatet.
        public static void ConvertCSVToXML(FileInfo fi, string outputDir)
        {
            // All data från input-filen läses in.
            List<string> lines = File.ReadAllLines(fi.FullName).ToList();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            // Nytt xml-dokument skapas.
            XmlWriter xmlWriter = XmlWriter.Create(outputDir + @"\products.xml", settings);

            xmlWriter.WriteStartDocument();
            // Sätt "huvudnoden" till Inventory eftersom SimpleMedia-formatet är så.
            xmlWriter.WriteStartElement("Inventory");
            foreach (string line in lines)
            {
                // Varje line som innehåller data bearbetas.
                if (line != "")
                {
                    // För varje line med data skapas en "Item"-node.
                    xmlWriter.WriteStartElement("Item");
                    string[] productValues = line.Split('|');
                    string[] itemValues = new string[9];

                    // Kopiera över de fält från MediaShop till SimpleMedia-formatet.
                    // Fält som inte är gemensamma nollställs.
                    itemValues[0] = productValues[1];
                    itemValues[1] = productValues[3];
                    itemValues[2] = productValues[2];
                    itemValues[3] = "";
                    itemValues[4] = "";
                    itemValues[5] = "";
                    itemValues[6] = "";
                    itemValues[7] = "0";
                    itemValues[8] = productValues[0];

                    // Här skrivs den gemensamma data över till xml-dokumentet.
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

        // Konvertering från SimpleMedia-formatet till MediaShop-formatet.
        public static void ConvertXMLToCSV(FileInfo fi, string outputDir)
        {
            // Nytt xml document laddas så vi kan läsa alla nodes.
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(fi.FullName);
            // Specifiering av output-vägen. Filen sparas som .txt istället för .xml.
            StreamWriter streamWriter = new StreamWriter(outputDir + @"\" + fi.Name.Replace(".xml", ".txt"));

            // Iteration av varje "Item"-node.
            foreach (XmlNode xmlNode in xmlDocument.DocumentElement)
            {
                // De fält som är gemensamma för de båda formaten sparas och sätt in i den korrekta
                // indexen för mål-formatet (i detta fall Media Shop .csv).
                string[] values = new string[PRODUCT_FIELDS.Length];
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    if (childNode.Name == ITEM_FIELDS[0])
                    {
                        values[1] = childNode.InnerText;
                    }
                    else if (childNode.Name == ITEM_FIELDS[1])
                    {
                        values[3] = childNode.InnerText;
                    }
                    else if (childNode.Name == ITEM_FIELDS[2])
                    {
                        values[2] = childNode.InnerText;
                    }
                    else if (childNode.Name == ITEM_FIELDS[8])
                    {
                        values[0] = childNode.InnerText;
                    }
                }
                values[4] = "OTHER";
                
                streamWriter.WriteLine(values[0] + "|" + values[1] + "|" + values[2] + "|" + values[3] + "|" + values[4]);
            }
            streamWriter.Close();
        }

    }
}
