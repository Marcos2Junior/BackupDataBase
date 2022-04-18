using BackupDataBase.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupDataBase.APP.UserControls
{
    public partial class BackupModelControl : UserControl
    {
        public Backup Backup { get; set; }

        public BackupModelControl()
        {
            InitializeComponent();
            var defaultIntervalExecution = new IntervalExecution
            {
                FinishDay = new TimeSpan(23, 0, 0),
                IntervalInMinutes = 60,
                StartDay = new TimeSpan(6, 0, 0)
            };
            Backup = new Backup
            {
                BackupType = BackupType.MySql,
                Development = new Development { Execution = defaultIntervalExecution, ConnectionString = "ConnectionString for restore" },
                Directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Backup_DataBase"),
                FTP = new FtpModel { Execution = defaultIntervalExecution },
                Execution = defaultIntervalExecution,
                RemoveInDays = 7,
                Name = "Backup Name",
                ID = 0,
                ConnectionString = "ConnectionString for backup"
            };
        }

        private void btn_change_directory_Click(object sender, EventArgs e)
        {

        }

        private void link_directory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public void LoadControl()
        {
            txt_name.Text = Backup.Name;
            txt_connectionString.Text = Backup.ConnectionString;
            txt_connectionString_dev.Text = Backup.Development.ConnectionString;
            nud_removeindays.Value = Backup.RemoveInDays;
            cb_backup_type.DataSource = Enum.GetNames(typeof(BackupType));
            cb_backup_type.SelectedItem = Backup.BackupType;
            btn_change_directory.Text = "Change directory";
            if (string.IsNullOrEmpty(Backup.Directory))
            {
                link_directory.ForeColor = Color.Red;
                link_directory.Text = "No directory selected";
                btn_change_directory.Text = "Select directory";
            }
            else if (!Directory.Exists(Backup.Directory))
            {
                link_directory.ForeColor = Color.Red;
                link_directory.Text = "(not found) " + Backup.Directory;
            }
            else
            {
                link_directory.ForeColor = Color.Blue;
                link_directory.Text = Backup.Directory;
            }

        }
    }
}
