using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace media_integrator
{
    public partial class MainForm : Form
    {
        private static readonly string FROM_SHOP_PATH = @"..\Debug\frShop\";
        private static readonly string TO_SIMPLE_PATH = @"..\Debug\toSimple\";

        public MainForm()
        {
            InitializeComponent();
        }

        //=============== UI Interactives ===============//
        private void BTNIntegrate_Click(object sender, System.EventArgs e)
        {
            FindFilesFromShop();
        }

        //=============== Backend Functions ===============//
        private void FindFilesFromShop()
        {
            DirectoryInfo di = new DirectoryInfo(FROM_SHOP_PATH);

            FileInfo[] files = di.GetFiles();
            foreach (FileInfo fi in files)
            {
                System.Diagnostics.Debug.WriteLine(fi.Name);
            }
        }

        private void FindFilesToSimple()
        {
            DirectoryInfo di = new DirectoryInfo(TO_SIMPLE_PATH);

            FileInfo[] files = di.GetFiles();
            foreach (FileInfo fi in files)
            {
                System.Diagnostics.Debug.WriteLine(fi.Name);
            }
        }

        private void ParseCSV(FileInfo fi)
        {
            List<string> entries = File.ReadAllLines(fi.FullName).ToList();


        }


    }
}
