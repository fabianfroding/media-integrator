using System.IO;

namespace media_integrator
{
    class DirectoryWatcher
    {
        private readonly string outputDir;
        private bool ongoing = false;

        private readonly Parser parser;

        private readonly FileSystemWatcher fsw;

        public DirectoryWatcher(string inputDir, string outputDir)
        {
            this.outputDir = outputDir;
            parser = new Parser();
            fsw = new FileSystemWatcher(inputDir);
            fsw.Created += new FileSystemEventHandler(FileDetected);
        }

        //=============== Public Functions ===============//
        public void StartFileWatcher()
        {
            fsw.EnableRaisingEvents = true;
        }

        public void StopFileWatcher()
        {
            fsw.EnableRaisingEvents = false;
        }

        //=============== Private Functions ===============//
        private void FileDetected(object sender, FileSystemEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.Name + " detected.");
            if (!ongoing)
            {
                ongoing = true;
                FileInfo fi = new FileInfo(e.FullPath);
                if (fi.Extension == ".txt" || fi.Extension == ".csv")
                {
                    System.Diagnostics.Debug.WriteLine("File is " + fi.Extension + ". Converting to XML.");
                    parser.ConvertCSVToXML(new FileInfo(e.FullPath), outputDir);
                }
                else if (fi.Extension == ".xml")
                {
                    System.Diagnostics.Debug.WriteLine("File is " + fi.Extension + ". Converting to CSV.");
                    parser.ConvertXMLToCSV(new FileInfo(e.FullPath), outputDir);
                }
                ongoing = false;
            }
        }

    }
}
