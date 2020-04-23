using System.Windows.Forms;

namespace media_integrator
{
    public partial class MainForm : Form
    {
        private Parser parser;

        public MainForm()
        {
            InitializeComponent();
            parser = new Parser();
        }

        //=============== UI Interactives ===============//
        private void BTNIntegrate_Click(object sender, System.EventArgs e)
        {
            parser.StartFileWatcher();
        }

    }
}
