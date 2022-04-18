namespace BackupDataBase.APP
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_install_ws = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_install_ws
            // 
            this.btn_install_ws.Location = new System.Drawing.Point(380, 12);
            this.btn_install_ws.Name = "btn_install_ws";
            this.btn_install_ws.Size = new System.Drawing.Size(175, 23);
            this.btn_install_ws.TabIndex = 0;
            this.btn_install_ws.Text = "Install Worker Service";
            this.btn_install_ws.UseVisualStyleBackColor = true;
            this.btn_install_ws.Click += new System.EventHandler(this.btn_install_ws_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 448);
            this.Controls.Add(this.btn_install_ws);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_install_ws;
    }
}