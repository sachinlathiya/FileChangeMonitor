using System;
using System.IO;
using System.Windows.Forms;

namespace FileChangeMonitorWinForms
{
    public partial class Form1 : Form
    {
        private string targetFilePath;
        private string previousContent;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Title = "Select a Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                targetFilePath = openFileDialog.FileName;
                lblFilePath.Text = $"Target File Path: {targetFilePath}";
                previousContent = File.ReadAllText(targetFilePath);
                txtChanges.AppendText($"Monitoring changes to: {targetFilePath}{Environment.NewLine}");
                timerFileMonitor.Start();
            }
        }

        private void timerFileMonitor_Tick_1(object sender, EventArgs e)
        {
            try
            {
                string currentContent = File.ReadAllText(targetFilePath);

                if (currentContent != previousContent)
                {
                    txtChanges.AppendText($"Changes detected in {targetFilePath}:{Environment.NewLine}");
                    txtChanges.AppendText("Previous content:");
                    txtChanges.AppendText($"{Environment.NewLine}{previousContent}{Environment.NewLine}");
                    txtChanges.AppendText("Current content:");
                    txtChanges.AppendText($"{Environment.NewLine}{currentContent}{Environment.NewLine}");

                    // Update the previous content
                    previousContent = currentContent;
                }
                else
                {
                    txtChanges.AppendText($"No changes detected in {targetFilePath}.{Environment.NewLine}");
                }
            }
            catch (Exception ex)
            {
                txtChanges.AppendText($"Error: {ex.Message}{Environment.NewLine}");
            }
        }

      
        
    }
}
