using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace FileZipper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            zip_btn.Visible = false;
            listOfFiles = new List<string>();
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string [] selectedFiles = openFileDialog.FileNames;
                    //if(selectedFiles.Length == 1 && Path.GetExtension(selectedFiles[0])==".zip")
                    //{
                    //    listOfFiles.Clear();
                    //    listOfFiles.Add(selectedFiles[0]);
                    //    listBox.Items.Clear();
                    //    listBox.Items.Add(Path.GetFileName(selectedFiles[0]));
                    //    zipUnzip = false;
                    //}
                    if(selectedFiles.Length>0)
                    {
                        for (int i =0; i<selectedFiles.Length; ++i)
                        {
                            if(listOfFiles.Contains(selectedFiles[i]))
                            {
                                MessageBox.Show("File already in the list!");
                                continue;
                            }
                            if (Path.GetExtension(selectedFiles[i]) == ".zip")
                            {

                            }
                            listOfFiles.Add(selectedFiles[i]);
                            listBox.Items.Add(Path.GetFileName(selectedFiles[i]));

                        }
                    }
                    if (listOfFiles.Count==1 && Path.GetExtension(listOfFiles.First())==".zip")
                    {
                        zipUnzip = false;
                        zip_btn.Text = "UNZIP";
                        zip_btn.ForeColor = Color.Blue;
                    }
                    else
                    {
                        zipUnzip = true;
                        zip_btn.Text = "ZIP";
                        zip_btn.ForeColor = Color.Red;
                    }
                    zip_btn.Visible = true;
                }
            }
        }

        private void zip_btn_Click(object sender, EventArgs e)
        {
            if(zipUnzip)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Zip files | *.zip";
                    saveFileDialog.DefaultExt = "zip";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ZipArchive zip = ZipFile.Open(saveFileDialog.FileName, ZipArchiveMode.Create);
                        foreach (string file in listOfFiles)
                        {
                            zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);
                        }
                        MessageBox.Show("ZIP file created successfully!");
                        zip.Dispose();
                    }
                }
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listOfFiles.Clear();
            listBox.Items.Clear();
            zip_btn.Visible = false;
        }
    }
}
