using System.IO;

namespace media_integrator
{
    static class DirectoryWatcher
    {
        public static string OUTPUT_DIR_MEDIASHOP;
        public static string OUTPUT_DIR_SIMPLEMEDIA;
        private static bool ongoing = false;

        private static readonly FileSystemWatcher fswMediaShop;
        private static readonly FileSystemWatcher fswSimpleMedia;

        static DirectoryWatcher()
        {
            fswMediaShop = new FileSystemWatcher();
            fswSimpleMedia = new FileSystemWatcher();
            fswMediaShop.Created += new FileSystemEventHandler(FileDetectedMediaShop);
            fswSimpleMedia.Created += new FileSystemEventHandler(FileDetectedSimpleMedia);
        }

        //=============== Public Functions ===============//
        public static void SetInputDirectoryMediaShop(string path)
        {
            fswMediaShop.Path = path;
        }

        public static void SetInputDirectorySimpleMedia(string path)
        {
            fswSimpleMedia.Path = path;
        }

        public static void StartFileWatcher()
        {
            fswMediaShop.EnableRaisingEvents = true;
            fswSimpleMedia.EnableRaisingEvents = true;
        }

        public static void StopFileWatcher()
        {
            fswMediaShop.EnableRaisingEvents = false;
            fswSimpleMedia.EnableRaisingEvents = false;
        }

        //=============== Private Functions ===============//
        private static void FileDetectedMediaShop(object sender, FileSystemEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.Name + " detected.");
            if (!ongoing)
            {
                ongoing = true;
                FileInfo fi = new FileInfo(e.FullPath);
                if (fi.Extension == ".txt" || fi.Extension == ".csv")
                {
                    System.Diagnostics.Debug.WriteLine("File is " + fi.Extension + ". Converting to XML.");
                    Parser.ConvertCSVToXML(new FileInfo(e.FullPath), OUTPUT_DIR_MEDIASHOP);
                }
                ongoing = false;
            }
        }

        private static void FileDetectedSimpleMedia(object sender, FileSystemEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.Name + " detected.");
            if (!ongoing)
            {
                ongoing = true;
                FileInfo fi = new FileInfo(e.FullPath);
                if (fi.Extension == ".xml")
                {
                    System.Diagnostics.Debug.WriteLine("File is " + fi.Extension + ". Converting to CSV.");
                    Parser.ConvertXMLToCSV(new FileInfo(e.FullPath), OUTPUT_DIR_SIMPLEMEDIA);
                }
                ongoing = false;
            }
        }

    }
}
