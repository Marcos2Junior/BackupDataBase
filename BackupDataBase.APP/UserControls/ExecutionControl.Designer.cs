namespace BackupDataBase.APP.UserControls
{
    partial class ExecutionControl
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
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_finish = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_interval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_start
            // 
            this.dtp_start.CustomFormat = "HH:mm";
            this.dtp_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start.Location = new System.Drawing.Point(10, 30);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.ShowUpDown = true;
            this.dtp_start.Size = new System.Drawing.Size(74, 29);
            this.dtp_start.TabIndex = 0;
            // 
            // dtp_finish
            // 
            this.dtp_finish.CustomFormat = "HH:mm";
            this.dtp_finish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_finish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_finish.Location = new System.Drawing.Point(103, 30);
            this.dtp_finish.Name = "dtp_finish";
            this.dtp_finish.ShowUpDown = true;
            this.dtp_finish.Size = new System.Drawing.Size(74, 29);
            this.dtp_finish.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Finish day";
            // 
            // nud_interval
            // 
            this.nud_interval.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_interval.Location = new System.Drawing.Point(198, 30);
            this.nud_interval.Name = "nud_interval";
            this.nud_interval.Size = new System.Drawing.Size(100, 29);
            this.nud_interval.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interval (Minutes)";
            // 
            // ExecutionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_interval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_finish);
            this.Controls.Add(this.dtp_start);
            this.Name = "ExecutionControl";
            this.Size = new System.Drawing.Size(316, 77);
            ((System.ComponentModel.ISupportInitialize)(this.nud_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_start;
        private DateTimePicker dtp_finish;
        private Label label1;
        private Label label2;
        private NumericUpDown nud_interval;
        private Label label3;
    }
}
