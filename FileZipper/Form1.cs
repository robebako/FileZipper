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
                    if(selectedFiles.Length>0)
                    {
                        for (int i =0; i<selectedFiles.Length; ++i)
                        {
                            listOfFiles.Add(selectedFiles[i]);
                            listBox.Items.Add(Path.GetFileName(selectedFiles[i]));

                        }
                        zip_btn.Visible = true;
                    }
                }
            }
        }
    }
}
