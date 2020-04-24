using System.IO;

namespace media_integrator
{
    class DirectoryWatcher
    {
        private readonly string outputDir;
        private readonly string fileExtension;
        private bool ongoing = false;

        private readonly Parser parser;

        private readonly FileSystemWatcher fsw;

        public DirectoryWatcher(string inputDir, string outputDir, string fileExtension)
        {
            this.outputDir = outputDir;
            this.fileExtension = fileExtension;
            parser = new Parser();
            fsw = new FileSystemWatcher(inputDir, fileExtension);
            fsw.Created += new FileSystemEventHandler(FileChanged);
            fsw.Changed += new FileSystemEventHandler(FileChanged);
            fsw.Deleted += new FileSystemEventHandler(FileDeleted);
            fsw.Renamed += new RenamedEventHandler(FileRenamed);
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
        private void FileChanged(object sender, FileSystemEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.Name + " created or changed.");
            if (!ongoing)
            {
                ongoing = true;
                parser.ConvertToXML(new FileInfo(e.FullPath), outputDir);
                ongoing = false;
            }
        }

        // Needed?
        private void FileDeleted(object sender, FileSystemEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.Name + " deleted.");
            if (!ongoing)
            {
                ongoing = true;

                ongoing = false;
            }
        }

        // Needed?
        private void FileRenamed(object sender, RenamedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.OldName + " renamed to " + e.Name);
            if (!ongoing)
            {
                ongoing = true;

                ongoing = false;
            }
        }
    }
}
