using System.Windows.Forms;

namespace media_integrator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //=============== UI Interactives ===============//
        // Funktion som start övervakning på de båda programmen.
        // Kräver att användaren angett de mappar som ska övervakas.
        private void BTNStartIntegration_Click(object sender, System.EventArgs e)
        {
            if (BTNStartIntegration.Text == "Start Integration")
            {
                if (
                    TextBoxInputDirMediaShop.Text != "" && TextBoxOutputDirMediaShop.Text != "" &&
                    TextBoxInputDirSimpleMedia.Text != "" && TextBoxOutputDirSimpleMedia.Text != ""
                    )
                {
                    DirectoryWatcher.SetInputDirectoryMediaShop(TextBoxInputDirMediaShop.Text);
                    DirectoryWatcher.OUTPUT_DIR_MEDIASHOP = TextBoxOutputDirMediaShop.Text;
                    DirectoryWatcher.SetInputDirectorySimpleMedia(TextBoxInputDirSimpleMedia.Text);
                    DirectoryWatcher.OUTPUT_DIR_SIMPLEMEDIA = TextBoxOutputDirSimpleMedia.Text;
                    DirectoryWatcher.StartFileWatcher();
                    BTNStartIntegration.Text = "Stop Integration";
                    LabelStatus.Text = "Running...";
                }
                else
                {
                    MessageBox.Show("Please select input and output directories.");
                }
            }
            else
            {
                DirectoryWatcher.StopFileWatcher();
                BTNStartIntegration.Text = "Start Integration";
                LabelStatus.Text = "";
            }
        }

        // De följande fyra funktionerna hanterar ändringar av input och output-mappar medan integreringen
        // redan körs. Då anropas DirectoryWatcher-klassen så att dess FileSystemWatcher-klassar uppdaterar
        // övervaknings-mappar.
        private void BTNSelectInputDirMediaShop_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextBoxInputDirMediaShop.Text = fbd.SelectedPath;
                DirectoryWatcher.SetInputDirectoryMediaShop(TextBoxInputDirMediaShop.Text);
            }
        }

        private void BTNSelectOutputDirMediaShop_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextBoxOutputDirMediaShop.Text = fbd.SelectedPath;
                DirectoryWatcher.OUTPUT_DIR_MEDIASHOP = TextBoxOutputDirMediaShop.Text;
            }
        }

        private void BTNSelectInputDirSimpleMedia_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextBoxInputDirSimpleMedia.Text = fbd.SelectedPath;
                DirectoryWatcher.SetInputDirectorySimpleMedia(TextBoxInputDirSimpleMedia.Text);
            }
        }

        private void BTNSelectOutputDirSimpleMedia_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextBoxOutputDirSimpleMedia.Text = fbd.SelectedPath;
                DirectoryWatcher.OUTPUT_DIR_SIMPLEMEDIA = TextBoxOutputDirSimpleMedia.Text;
            }
        }
    }
}
