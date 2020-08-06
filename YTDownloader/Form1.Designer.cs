namespace YTDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VideoURLLabel = new System.Windows.Forms.Label();
            this.textURL = new System.Windows.Forms.TextBox();
            this.Btnget = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.Btndownload = new System.Windows.Forms.Button();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.TextVideoName = new System.Windows.Forms.TextBox();
            this.VideoNameLabel = new System.Windows.Forms.Label();
            this.ThumbnailLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxLoadGet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadGet)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoURLLabel
            // 
            this.VideoURLLabel.AutoSize = true;
            this.VideoURLLabel.Location = new System.Drawing.Point(58, 81);
            this.VideoURLLabel.Name = "VideoURLLabel";
            this.VideoURLLabel.Size = new System.Drawing.Size(64, 15);
            this.VideoURLLabel.TabIndex = 0;
            this.VideoURLLabel.Text = "Video URL:";
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
            this.listView1.FullRowSelect = true;
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
            this.Btndownload.Location = new System.Drawing.Point(504, 324);
            this.Btndownload.Name = "Btndownload";
            this.Btndownload.Size = new System.Drawing.Size(165, 88);
            this.Btndownload.TabIndex = 2;
            this.Btndownload.Text = "Download";
            this.Btndownload.UseVisualStyleBackColor = true;
            this.Btndownload.Click += new System.EventHandler(this.Btndownload_Click);
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(150, 426);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(519, 23);
            this.progressBarDownload.TabIndex = 4;
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
            // ThumbnailLabel
            // 
            this.ThumbnailLabel.AutoSize = true;
            this.ThumbnailLabel.Location = new System.Drawing.Point(58, 324);
            this.ThumbnailLabel.Name = "ThumbnailLabel";
            this.ThumbnailLabel.Size = new System.Drawing.Size(67, 15);
            this.ThumbnailLabel.TabIndex = 0;
            this.ThumbnailLabel.Text = "Thumbnail:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(150, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 88);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(150, 456);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(23, 15);
            this.labelProgress.TabIndex = 7;
            this.labelProgress.Text = "0 %";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = false;
            this.backgroundWorker1.WorkerSupportsCancellation = false;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBoxLoadGet
            // 
            this.pictureBoxLoadGet.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadGet.Image")));
            this.pictureBoxLoadGet.Location = new System.Drawing.Point(327, 108);
            this.pictureBoxLoadGet.Name = "pictureBoxLoadGet";
            this.pictureBoxLoadGet.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLoadGet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoadGet.TabIndex = 8;
            this.pictureBoxLoadGet.TabStop = false;
            this.pictureBoxLoadGet.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(726, 498);
            this.Controls.Add(this.pictureBoxLoadGet);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ThumbnailLabel);
            this.Controls.Add(this.VideoNameLabel);
            this.Controls.Add(this.TextVideoName);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.Btndownload);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Btnget);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.VideoURLLabel);
            this.Name = "Form1";
            this.Text = "Youtube Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadGet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Label VideoURLLabel;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Button Btnget;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button Btndownload;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.TextBox TextVideoName;
        private System.Windows.Forms.Label VideoNameLabel;
        private System.Windows.Forms.Label ThumbnailLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.PictureBox pictureBoxLoadGet;
    }
}

