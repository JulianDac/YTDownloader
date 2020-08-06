namespace YTDownloader
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textURL = new System.Windows.Forms.TextBox();
            this.Btnget = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.Btndownload = new System.Windows.Forms.Button();
            this.ProgressBarDownload = new System.Windows.Forms.ProgressBar();
            this.TextVideoName = new System.Windows.Forms.TextBox();
            this.VideoNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video URL:";
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(150, 78);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(519, 23);
            this.textURL.TabIndex = 1;
            // 
            // Btnget
            // 
            this.Btnget.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btnget.Location = new System.Drawing.Point(150, 107);
            this.Btnget.Name = "Btnget";
            this.Btnget.Size = new System.Drawing.Size(171, 51);
            this.Btnget.TabIndex = 2;
            this.Btnget.Text = "Get Video";
            this.Btnget.UseVisualStyleBackColor = true;
            this.Btnget.Click += new System.EventHandler(this.Btnget_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(150, 164);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(519, 117);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quality";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Extension";
            this.columnHeader4.Width = 250;
            // 
            // Btndownload
            // 
            this.Btndownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btndownload.Location = new System.Drawing.Point(150, 373);
            this.Btndownload.Name = "Btndownload";
            this.Btndownload.Size = new System.Drawing.Size(118, 37);
            this.Btndownload.TabIndex = 2;
            this.Btndownload.Text = "Download";
            this.Btndownload.UseVisualStyleBackColor = true;
            // 
            // ProgressBarDownload
            // 
            this.ProgressBarDownload.Location = new System.Drawing.Point(150, 426);
            this.ProgressBarDownload.Name = "ProgressBarDownload";
            this.ProgressBarDownload.Size = new System.Drawing.Size(519, 23);
            this.ProgressBarDownload.TabIndex = 4;
            // 
            // TextVideoName
            // 
            this.TextVideoName.Location = new System.Drawing.Point(150, 295);
            this.TextVideoName.Name = "TextVideoName";
            this.TextVideoName.Size = new System.Drawing.Size(519, 23);
            this.TextVideoName.TabIndex = 5;
            // 
            // VideoNameLabel
            // 
            this.VideoNameLabel.AutoSize = true;
            this.VideoNameLabel.Location = new System.Drawing.Point(58, 298);
            this.VideoNameLabel.Name = "VideoNameLabel";
            this.VideoNameLabel.Size = new System.Drawing.Size(75, 15);
            this.VideoNameLabel.TabIndex = 0;
            this.VideoNameLabel.Text = "Video Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thumbnail:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(427, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 88);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(726, 498);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VideoNameLabel);
            this.Controls.Add(this.TextVideoName);
            this.Controls.Add(this.ProgressBarDownload);
            this.Controls.Add(this.Btndownload);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Btnget);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Youtube Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Button Btnget;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button Btndownload;
        private System.Windows.Forms.ProgressBar ProgressBarDownload;
        private System.Windows.Forms.TextBox TextVideoName;
        private System.Windows.Forms.Label VideoNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

