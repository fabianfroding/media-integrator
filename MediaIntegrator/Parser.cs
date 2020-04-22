using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace media_integrator
{
    class Parser
    {

        //=============== Public Functions ===============//
        public void ParseCSVInDir(string targetDirPath, string destinationDirPath)
        {
            DirectoryInfo di = new DirectoryInfo(targetDirPath);

            FileInfo[] files = di.GetFiles();
            foreach (FileInfo fi in files)
            {
                //System.Diagnostics.Debug.WriteLine(fi.Name);
                List<string> lines = ParseCSVFile(fi);
                ConvertToXML(lines, destinationDirPath);
            }
        }

        //=============== Private Functions ===============//
        private List<string> ParseCSVFile(FileInfo fi)
        {
            List<string> lines = File.ReadAllLines(fi.FullName).ToList();

            

            return lines;
        }

        private void ConvertToXML(List<string> lines, string destinationDirPath)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter xw = XmlWriter.Create("products.xml", settings);
            
            xw.WriteStartDocument();
            xw.WriteStartElement("Products");
            foreach (string line in lines)
            {
                
                if (line != "")
                {
                    System.Diagnostics.Debug.WriteLine(line);
                    string[] entries = line.Split('|');
                    for (int i = 0; i < entries.Length; i++)
                    {
                        System.Diagnostics.Debug.WriteLine(entries[i]);
                        xw.WriteStartElement(entries[1]);
                        xw.WriteEndElement();


                    }
                }
            }
            xw.WriteEndElement();
            xw.Close();
        }
    }
}
