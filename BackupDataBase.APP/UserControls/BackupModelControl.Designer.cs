namespace BackupDataBase.APP.UserControls
{
    partial class BackupModelControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.execution_control = new BackupDataBase.APP.UserControls.ExecutionControl();
            this.cb_backup_type = new System.Windows.Forms.ComboBox();
            this.txt_connectionString = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.nud_removeindays = new System.Windows.Forms.NumericUpDown();
            this.link_directory = new System.Windows.Forms.LinkLabel();
            this.btn_change_directory = new System.Windows.Forms.Button();
            this.execution_dev_control = new BackupDataBase.APP.UserControls.ExecutionControl();
            this.txt_connectionString_dev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_removeindays)).BeginInit();
            this.SuspendLayout();
            // 
            // execution_control
            // 
            this.execution_control.Location = new System.Drawing.Point(19, 162);
            this.execution_control.Name = "execution_control";
            this.execution_control.Size = new System.Drawing.Size(316, 77);
            this.execution_control.TabIndex = 0;
            // 
            // cb_backup_type
            // 
            this.cb_backup_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_backup_type.FormattingEnabled = true;
            this.cb_backup_type.Location = new System.Drawing.Point(225, 47);
            this.cb_backup_type.Name = "cb_backup_type";
            this.cb_backup_type.Size = new System.Drawing.Size(178, 23);
            this.cb_backup_type.TabIndex = 1;
            // 
            // txt_connectionString
            // 
            this.txt_connectionString.Location = new System.Drawing.Point(19, 133);
            this.txt_connectionString.Name = "txt_connectionString";
            this.txt_connectionString.Size = new System.Drawing.Size(316, 23);
            this.txt_connectionString.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(19, 66);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 23);
            this.txt_name.TabIndex = 3;
            // 
            // nud_removeindays
            // 
            this.nud_removeindays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_removeindays.Location = new System.Drawing.Point(19, 262);
            this.nud_removeindays.Name = "nud_removeindays";
            this.nud_removeindays.Size = new System.Drawing.Size(100, 29);
            this.nud_removeindays.TabIndex = 4;
            // 
            // link_directory
            // 
            this.link_directory.AutoSize = true;
            this.link_directory.Location = new System.Drawing.Point(159, 346);
            this.link_directory.Name = "link_directory";
            this.link_directory.Size = new System.Drawing.Size(76, 15);
            this.link_directory.TabIndex = 5;
            this.link_directory.TabStop = true;
            this.link_directory.Text = "link directory";
            this.link_directory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_directory_LinkClicked);
            // 
            // btn_change_directory
            // 
            this.btn_change_directory.Location = new System.Drawing.Point(159, 364);
            this.btn_change_directory.Name = "btn_change_directory";
            this.btn_change_directory.Size = new System.Drawing.Size(159, 23);
            this.btn_change_directory.TabIndex = 6;
            this.btn_change_directory.Text = "change directory";
            this.btn_change_directory.UseVisualStyleBackColor = true;
            this.btn_change_directory.Click += new System.EventHandler(this.btn_change_directory_Click);
            // 
            // execution_dev_control
            // 
            this.execution_dev_control.Location = new System.Drawing.Point(19, 484);
            this.execution_dev_control.Name = "execution_dev_control";
            this.execution_dev_control.Size = new System.Drawing.Size(316, 77);
            this.execution_dev_control.TabIndex = 7;
            // 
            // txt_connectionString_dev
            // 
            this.txt_connectionString_dev.Location = new System.Drawing.Point(30, 455);
            this.txt_connectionString_dev.Name = "txt_connectionString_dev";
            this.txt_connectionString_dev.Size = new System.Drawing.Size(316, 23);
            this.txt_connectionString_dev.TabIndex = 8;
            // 
            // BackupModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_connectionString_dev);
            this.Controls.Add(this.execution_dev_control);
            this.Controls.Add(this.btn_change_directory);
            this.Controls.Add(this.link_directory);
            this.Controls.Add(this.nud_removeindays);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_connectionString);
            this.Controls.Add(this.cb_backup_type);
            this.Controls.Add(this.execution_control);
            this.Name = "BackupModelControl";
            this.Size = new System.Drawing.Size(433, 608);
            ((System.ComponentModel.ISupportInitialize)(this.nud_removeindays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExecutionControl execution_control;
        private ComboBox cb_backup_type;
        private TextBox txt_connectionString;
        private TextBox txt_name;
        private NumericUpDown nud_removeindays;
        private LinkLabel link_directory;
        private Button btn_change_directory;
        private ExecutionControl execution_dev_control;
        private TextBox txt_connectionString_dev;
    }
}
