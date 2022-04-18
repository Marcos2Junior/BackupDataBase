using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BackupDataBase.APP
{
    public partial class FrmMain : Form
    {
        private readonly ILogger<FrmMain> _logger;

        public FrmMain(ILogger<FrmMain> logger)
        {
            _logger = logger;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}