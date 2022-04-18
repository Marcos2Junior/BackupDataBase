using BackupDataBase.APP.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;

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

        private void btn_install_ws_Click(object sender, EventArgs e)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                WindowsService windowsService = new WindowsService();
                var service = windowsService.GetService();
                if (service == null)
                {
                    try
                    {
                        windowsService.Install();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("operating system not supported");
            }
        }
    }
}