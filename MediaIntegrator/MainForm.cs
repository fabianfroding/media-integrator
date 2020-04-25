using System.Windows.Forms;

namespace media_integrator
{
    public partial class MainForm : Form
    {
        private DirectoryWatcher directoryWatcher;

        public MainForm()
        {
            InitializeComponent();
        }

        //=============== UI Interactives ===============//
        private void BTNStartIntegration_Click(object sender, System.EventArgs e)
        {
            if (BTNStartIntegration.Text == "Start Integration")
            {
                if (TextBoxInputDir.Text != "" && TextBoxOutputDir.Text != "")
                {
                    directoryWatcher = new DirectoryWatcher(TextBoxInputDir.Text, TextBoxOutputDir.Text);
                    directoryWatcher.StartFileWatcher();
                    BTNStartIntegration.Text = "Stop Integration";
                    LabelStatus.Text = "Running...";
                }
                else
                {
                    MessageBox.Show("Please select input and output directory.");
                }
            }
            else
            {
                directoryWatcher.StopFileWatcher();
                BTNStartIntegration.Text = "Start Integration";
                LabelStatus.Text = "";
            }
        }

        private void BTNSelectInputDir_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextBoxInputDir.Text = fbd.SelectedPath;
            }
        }

        private void BTNSelectOutputDir_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextBoxOutputDir.Text = fbd.SelectedPath;
            }
        }

    }
}
