using System.Windows.Forms;

namespace media_integrator
{
    public partial class MainForm : Form
    {
        private static readonly string FROM_SHOP_PATH = @"..\Debug\frShop\";
        private static readonly string TO_SIMPLE_PATH = @"..\Debug\toSimple\";

        private Parser parser;

        public MainForm()
        {
            InitializeComponent();
            parser = new Parser();
        }

        //=============== UI Interactives ===============//
        private void BTNIntegrate_Click(object sender, System.EventArgs e)
        {
            parser.ParseCSVInDir(FROM_SHOP_PATH, TO_SIMPLE_PATH);
        }



    }
}
