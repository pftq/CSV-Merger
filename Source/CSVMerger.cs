using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.CSharp;

namespace CSVMerger
{
    public partial class CSVMerger : Form
    {
        bool gui = true;
        public CSVMerger(bool gui=true)
        {
            this.gui=gui;
            InitializeComponent();
            hideOptions();
            folderSaved.Text = Properties.Settings.Default.folder;
            fileSaved.Text = Properties.Settings.Default.output;
            headerRow.Value = Properties.Settings.Default.headerRow;
            firstRow.Value = Properties.Settings.Default.firstRow;
            lastRow.Value = Properties.Settings.Default.lastRow;
            delimiter.Text = Properties.Settings.Default.delimiter;
            if(Properties.Settings.Default.addCol!="")
                addCol.Text = Properties.Settings.Default.addCol;
            addColPos.Value = Properties.Settings.Default.addColPos;
            newColX.Value = Properties.Settings.Default.newColX;
            newColY.Value = Properties.Settings.Default.newColY;
            if(Properties.Settings.Default.newColRegex!="")
                newColRegex.Text = Properties.Settings.Default.newColRegex;
            if (Properties.Settings.Default.newColFormat != "")
                newColFormat.Text = Properties.Settings.Default.newColFormat;
            addColEnabled.Checked = Properties.Settings.Default.addColEnabled;
        }

        private void folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
                folderSaved.Text = Properties.Settings.Default.folder = f.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Title = "Save Merged File to...";
            f.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
            f.FileName = "MergedCSV";
            f.RestoreDirectory = true;
            f.AddExtension = true;
            if (f.ShowDialog() == DialogResult.OK)
                fileSaved.Text = Properties.Settings.Default.output = f.FileName;
            Properties.Settings.Default.Save();
        }

        public void merge_Click(object sender, EventArgs e)
        {
            if (fileSaved.Text.Trim() == "")
            {
                popup("Please specify a file to save the merged CSV to.");
                return;
            }
            string[] files;
            try
            {
                 files = Directory.GetFiles(folderSaved.Text, "*.csv");
            }
            catch
            {
                popup("Invalid folder selected.");
                return;
            }
            StreamWriter output = null;
            string addCell = "";
            foreach (string file in files)
            {
                if (file == fileSaved.Text) continue;
                string[] lines;
                try
                {
                    lines = File.ReadAllLines(file);
                }
                catch
                {
                    popup("Cannot read " + file);
                    continue;
                }
                if (output == null)
                {
                    try
                    {
                        output = new StreamWriter(fileSaved.Text);
                    }
                    catch
                    {
                        popup("Cannot write to " + fileSaved.Text);
                        return;
                    }
                    if (addColEnabled.Checked)
                    {
                        string[] col = lines[(int)headerRow.Value - 1].Split(new string[]{delimiter.Text}, StringSplitOptions.None);
                        List<string> c = new List<string>();
                        for (int i = 0; i < col.Length; i++) {
                            if (i + 1 == (int)addColPos.Value) c.Add(addCol.Text.Trim());
                            c.Add(col[i]);
                        }
                        lines[(int)headerRow.Value - 1] = String.Join(delimiter.Text, c);
                    }
                    output.WriteLine(lines[(int)headerRow.Value - 1]);
                }
                if (addColEnabled.Checked)
                {
                    string[] r = lines[Math.Min(lines.Length - 1, (int)newColY.Value - 1)].Split(new string[] { delimiter.Text }, StringSplitOptions.None);
                    addCell = r[Math.Min(r.Length - 1, (int)newColX.Value - 1)];
                    if (newColRegex.Text.Trim() != "")
                        addCell = Regex.Match(addCell, "(" + newColRegex.Text + ")").Groups[1].Value;
                    if (newColFormat.Text.Trim() != "")
                        addCell = Regex.Replace(addCell, newColRegex.Text, newColFormat.Text);
                }
                int lastLine = Math.Min((int)lastRow.Value, lines.Length);
                for (int i = (int)firstRow.Value - 1; i < lastLine;i++ )
                {
                    if (addColEnabled.Checked)
                    {
                        string[] col = lines[i].Split(new string[] { delimiter.Text }, StringSplitOptions.None);
                        List<string> c = new List<string>();
                        for (int j = 0; j < col.Length; j++)
                        {
                            if (1 + j == (int)addColPos.Value) c.Add(addCell);
                            c.Add(col[j]);
                        }
                        lines[i] = String.Join(delimiter.Text, c);
                    }
                    output.WriteLine(lines[i]);
                }
            }
            popup("Done! Files merged to " + fileSaved.Text);
            output.Close();
        }

        private void optionsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (moreOptions.Visible)
            {
                hideOptions();
            }
            else showOptions();
        }
        private void hideOptions()
        {
            Size = MaximumSize = MinimumSize = new System.Drawing.Size(400, 200);
            moreOptions.Hide();
            optionsLink.Text = "More Options";
        }
        private void showOptions()
        {
            Size = MaximumSize = MinimumSize = new System.Drawing.Size(400, 320);
            moreOptions.Show();
            optionsLink.Text = "Less Options";
        }

        private void headerRow_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.headerRow = (int)headerRow.Value;
            Properties.Settings.Default.Save();
        }

        private void firstRow_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.firstRow = (int)firstRow.Value;
            Properties.Settings.Default.Save();
        }

        private void lastRow_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.lastRow = (int)lastRow.Value;
            Properties.Settings.Default.Save();
        }

        private void addCol_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.addCol = addCol.Text;
            Properties.Settings.Default.Save();
        }

        private void addColPos_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.addColPos = (int)addColPos.Value;
            Properties.Settings.Default.Save();
        }

        private void newColX_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.newColX = (int)newColX.Value;
            Properties.Settings.Default.Save();
        }

        private void newColY_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.newColY = (int)newColY.Value;
            Properties.Settings.Default.Save();
        }

        private void newColRegex_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.newColRegex = newColRegex.Text;
            Properties.Settings.Default.Save();
        }

        private void delimiter_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.delimiter = delimiter.Text;
            Properties.Settings.Default.Save();
        }

        private void addColEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.addColEnabled = addColEnabled.Checked;
            Properties.Settings.Default.Save();
        }

        private void popup(string text)
        {
            if(gui) MessageBox.Show(text);
        }

        private void newColFormat_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.newColFormat = newColFormat.Text;
            Properties.Settings.Default.Save();
        }
    }
}
