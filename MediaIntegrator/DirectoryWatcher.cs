using System.IO;

namespace media_integrator
{
    static class DirectoryWatcher
    {
        public static string OUTPUT_DIR_MEDIASHOP;
        public static string OUTPUT_DIR_SIMPLEMEDIA;
        // Flag för att indikera om en konvertering (inte övervakning) redan körs. Ifall användaren drar
        // flera filer direkt till en input-map förhindrar detta att alla konverteras, och konverterar
        // bara den första den hittar.
        private static bool ongoing = false;

        private static readonly FileSystemWatcher fswMediaShop;
        private static readonly FileSystemWatcher fswSimpleMedia;

        static DirectoryWatcher()
        {
            fswMediaShop = new FileSystemWatcher();
            fswSimpleMedia = new FileSystemWatcher();
            fswMediaShop.Created += new FileSystemEventHandler(FileDetectedMediaShop);
            fswMediaShop.Changed += new FileSystemEventHandler(FileDetectedMediaShop);
            fswSimpleMedia.Created += new FileSystemEventHandler(FileDetectedSimpleMedia);
            fswSimpleMedia.Changed += new FileSystemEventHandler(FileDetectedSimpleMedia);
        }

        //=============== Public Functions ===============//
        // Denna funktion uppdaterar input-mappen för MediaShop
        // ifall den ändras medans integratorn redan körs.
        public static void SetInputDirectoryMediaShop(string path)
        {
            fswMediaShop.Path = path;
        }

        // Denna funktion uppdaterar input-mappen för SimpleMedia
        // ifall den ändras medans integratorn redan körs.
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
        // Övervakning av input-filer från MediaShop.
        private static void FileDetectedMediaShop(object sender, FileSystemEventArgs e)
        {
            if (!ongoing)
            {
                ongoing = true;
                FileInfo fi = new FileInfo(e.FullPath);
                if (fi.Extension == ".txt" || fi.Extension == ".csv")
                {
                    Parser.ConvertCSVToXML(new FileInfo(e.FullPath), OUTPUT_DIR_MEDIASHOP);
                }
                ongoing = false;
            }
        }

        // Övervakning av filer från SimpleMedia.
        private static void FileDetectedSimpleMedia(object sender, FileSystemEventArgs e)
        {
            if (!ongoing)
            {
                ongoing = true;
                FileInfo fi = new FileInfo(e.FullPath);
                if (fi.Extension == ".xml")
                {
                    Parser.ConvertXMLToCSV(new FileInfo(e.FullPath), OUTPUT_DIR_SIMPLEMEDIA);
                }
                ongoing = false;
            }
        }

    }
}
