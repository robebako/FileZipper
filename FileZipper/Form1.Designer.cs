using System.Collections.Generic;

namespace FileZipper
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.select_btn = new System.Windows.Forms.Button();
            this.zip_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(478, 160);
            this.listBox.TabIndex = 0;
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(23, 199);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(107, 23);
            this.select_btn.TabIndex = 1;
            this.select_btn.Text = "SELECT FILE(S)";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // zip_btn
            // 
            this.zip_btn.Location = new System.Drawing.Point(360, 199);
            this.zip_btn.Name = "zip_btn";
            this.zip_btn.Size = new System.Drawing.Size(75, 23);
            this.zip_btn.TabIndex = 2;
            this.zip_btn.Text = "ZIP";
            this.zip_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.zip_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button zip_btn;
        //private string[] selectedFiles;
        List<string> listOfFiles;
    }
}

