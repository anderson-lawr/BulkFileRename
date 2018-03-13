using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkFileRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            elapsedVal.Text = "";
            remainingVal.Text = "";
            statusVal.Text = "Not Started";
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folderTxtBx.Text = fbd.SelectedPath;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            var start = DateTime.Now;
            var folderPath = folderTxtBx.Text;
            var currentPattern = currentTxt.Text;
            var newPattern = newTxt.Text;
            DirectoryInfo d = new DirectoryInfo(folderPath);
            FileInfo[] infos = d.GetFiles();
            var total = infos.Count();
            refreshTimes(start, 0, total);
            exposeLabels();
            for (int i = 0; i < total; i++)
            {
                FileInfo f = infos[i];
                var oldName = f.Name;
                //refreshStatus("Checking file: " + oldName + " ("+(i+1).ToString()+" of " + total.ToString() + ")");
                if (oldName.Contains(currentPattern))
                {
                    if (folderPath.Contains(oldName))
                    {
                        refreshStatus("Folder path contains old file name");
                    }
                    else
                    {
                        refreshStatus("Renaming file: " + oldName + " (" + (i + 1).ToString() + " of " + total.ToString() + ")");
                        var newName = oldName.Replace(currentPattern, newPattern);
                        File.Move(f.FullName, f.FullName.Replace(oldName, newName));
                    }
                }
                else
                {
                    refreshStatus("Pattern not found in: " + oldName);
                }

                refreshTimes(start, i + 1, total);
            }
            refreshStatus("Renames complete");

        }

        private async void exposeLabels()
        {
            remainingVal.Text = "unknown";
            elapsedLabel.Visible = true;
            remainingLabel.Visible = true;
            elapsedVal.Visible = true;
            remainingVal.Visible = true;
            elapsedLabel.Refresh();
            remainingLabel.Refresh();
            elapsedVal.Refresh();
            remainingVal.Refresh();
        }

        private void refreshTimes(DateTime start, int processed, int total)
        {
            try
            {
                var elapsed = DateTime.Now - start;
                elapsedVal.Text = elapsed.ToString(@"hh\:mm\:ss");
                if (processed < 1)
                {
                    remainingVal.Text = "unknown";
                }
                else
                {
                    var remaining = total - processed;
                    var x = elapsed.Ticks * remaining;
                    var estimateTicks = x / processed;
                    var estimate = TimeSpan.FromTicks(estimateTicks);

                    remainingVal.Text = estimate.ToString(@"hh\:mm\:ss");
                }
                elapsedVal.Refresh();
                remainingVal.Refresh();
            }
            catch (Exception e)
            {

            }
        }

        private void refreshStatus(string status)
        {
            try
            {
                statusVal.Text = status;
                statusVal.Refresh();
            }
            catch(Exception e)
            {

            }
        }
    }
}
