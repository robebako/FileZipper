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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(229, 121);
            this.listBox.TabIndex = 0;
            // 
            // select_btn
            // 
            this.select_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_btn.Location = new System.Drawing.Point(263, 12);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(127, 39);
            this.select_btn.TabIndex = 1;
            this.select_btn.Text = "SELECT FILE(S)";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // zip_btn
            // 
            this.zip_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip_btn.Location = new System.Drawing.Point(263, 97);
            this.zip_btn.Name = "zip_btn";
            this.zip_btn.Size = new System.Drawing.Size(75, 38);
            this.zip_btn.TabIndex = 2;
            this.zip_btn.Text = "ZIP";
            this.zip_btn.UseVisualStyleBackColor = true;
            this.zip_btn.Click += new System.EventHandler(this.zip_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 151);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zip_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "FileZipper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button zip_btn;
        //private string[] selectedFiles;
        List<string> listOfFiles;
        bool zipUnzip = true;
        private System.Windows.Forms.Button button1;
    }
}

