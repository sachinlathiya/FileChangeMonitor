namespace FileChangeMonitorWinForms
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnSetFile = new System.Windows.Forms.Button();
            this.txtChanges = new System.Windows.Forms.TextBox();
            this.timerFileMonitor = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(14, 68);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(122, 16);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "Target File Path:";
            // 
            // btnSetFile
            // 
            this.btnSetFile.Location = new System.Drawing.Point(17, 12);
            this.btnSetFile.Name = "btnSetFile";
            this.btnSetFile.Size = new System.Drawing.Size(250, 45);
            this.btnSetFile.TabIndex = 2;
            this.btnSetFile.Text = "Set File to Monitor!";
            this.btnSetFile.UseVisualStyleBackColor = true;
            this.btnSetFile.Click += new System.EventHandler(this.btnSetFile_Click_1);
            // 
            // txtChanges
            // 
            this.txtChanges.Location = new System.Drawing.Point(17, 113);
            this.txtChanges.Multiline = true;
            this.txtChanges.Name = "txtChanges";
            this.txtChanges.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChanges.Size = new System.Drawing.Size(1299, 628);
            this.txtChanges.TabIndex = 3;
            // 
            // timerFileMonitor
            // 
            this.timerFileMonitor.Enabled = true;
            this.timerFileMonitor.Interval = 15000;
            this.timerFileMonitor.Tick += new System.EventHandler(this.timerFileMonitor_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detection Logs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1330, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChanges);
            this.Controls.Add(this.btnSetFile);
            this.Controls.Add(this.lblFilePath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Change Monitor!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnSetFile;
        private System.Windows.Forms.TextBox txtChanges;
        private System.Windows.Forms.Timer timerFileMonitor;
        private System.Windows.Forms.Label label1;
    }
}

