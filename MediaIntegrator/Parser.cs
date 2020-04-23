using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace media_integrator
{
    class Parser
    {
        // Paths till de övervakade mapparna och destinations-mapparna.
        private static readonly string FROM_SIMPLE_PATH = @"..\Debug\frSimple\";
        private static readonly string FROM_SHOP_PATH = @"..\Debug\frShop\";
        private static readonly string TO_SIMPLE_PATH = @"..\Debug\toSimple\";
        private static readonly string TO_SHOP_PATH = @"..\Debug\toShop\";
        
        // Product-klassens fält för xml-tags.
        private static readonly string[] PRODUCT_FIELDS = new string[5]
        {
            "Id", "Name", "Price", "Stock", "ProductType"
        };

        //=============== Public Functions ===============//
        public void StartFileWatcher()
        {
            FileSystemWatcher fsw = new FileSystemWatcher(@"..\Debug\frShop\", "*.txt");
            fsw.Created += new FileSystemEventHandler(FileChanged);
            fsw.Changed += new FileSystemEventHandler(FileChanged);
            fsw.Deleted += new FileSystemEventHandler(FileDeleted);
            fsw.Renamed += new RenamedEventHandler(FileRenamed);
            fsw.EnableRaisingEvents = true;
        }

        public void ParseCSVInDir(string targetDirPath, string destinationDirPath)
        {
            DirectoryInfo di = new DirectoryInfo(targetDirPath);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo fi in files)
            {
                ConvertToXML(fi, destinationDirPath);
            }
        }

        //=============== Private Functions ===============//
        private void ConvertToXML(FileInfo fi, string destinationDirPath)
        {
            List<string> lines = File.ReadAllLines(fi.FullName).ToList();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter xw = XmlWriter.Create(destinationDirPath, settings);
            
            xw.WriteStartDocument();
            xw.WriteStartElement("Products");
            foreach (string line in lines)
            {
                if (line != "")
                {
                    xw.WriteStartElement("Product");
                    string[] entries = line.Split('|');

                    for (int i = 0; i < entries.Length; i++)
                    {
                        xw.WriteStartElement(PRODUCT_FIELDS[i]);
                        xw.WriteValue(entries[i]);
                        xw.WriteEndElement();
                    }
                    xw.WriteEndElement();
                }
            }
            xw.WriteEndElement();
            xw.Close();
        }

        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.Name + " created or changed.");
        }

        private static void FileDeleted(object sender, FileSystemEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.Name + " deleted.");
        }

        private void FileRenamed(object sender, RenamedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.OldName + " renamed to " + e.Name);
        }
    }
}
