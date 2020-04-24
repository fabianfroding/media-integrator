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
        public void ConvertToXML(FileInfo fi, string outputDir)
        {
            List<string> lines = File.ReadAllLines(fi.FullName).ToList();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter xw = XmlWriter.Create(outputDir + @"\products.xml", settings);

            xw.WriteStartDocument();
            xw.WriteStartElement("Inventory");
            foreach (string line in lines)
            {
                if (line != "")
                {
                    xw.WriteStartElement("Item");
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
                        xw.WriteStartElement(ITEM_FIELDS[i]);
                        xw.WriteValue(itemValues[i]);
                        xw.WriteEndElement();
                    }

                    xw.WriteEndElement();
                }
            }
            xw.WriteEndElement();
            xw.Close();
        }

    }
}
