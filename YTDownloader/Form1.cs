using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YTDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Btnget_Click(object sender, EventArgs e)
        {
            Btnget.Enabled = false;
            pictureBoxLoadGet.Visible = true;
            await AsyncGetLinks();
            pictureBoxLoadGet.Visible = false;
            Btnget.Enabled = true;
        }

        private async Task AsyncGetLinks()
        {
            listView1.Items.Clear(); //avoid incrementing listview

            string videoUrl = textURL.Text; //from the Video URL box
            var youtube = new YoutubeClient();

            var video = await youtube.Videos.GetAsync(videoUrl);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);

            TextVideoName.Text = video.Title;
            string ThumbUrl = video.Thumbnails.LowResUrl;
            pictureBox1.LoadAsync(ThumbUrl);

            // Get highest quality muxed stream
            var streamInfoMuxedHVQ = streamManifest.GetMuxed().WithHighestVideoQuality();
            ListViewItem ListVideo = new ListViewItem();
            ListVideo.Text = "Video/Audio";
            ListVideo.SubItems.Add(streamInfoMuxedHVQ.VideoQualityLabel);
            ListVideo.SubItems.Add(Math.Round(streamInfoMuxedHVQ.Size.TotalMegaBytes).ToString() + " MB");
            ListVideo.SubItems.Add(streamInfoMuxedHVQ.Container.Name.ToString());
            ListVideo.Tag = streamInfoMuxedHVQ.Url;
            listView1.Items.Add(ListVideo);

            // ...or highest bitrate audio-only stream
            var streamInfoAudio = streamManifest.GetAudioOnly().WithHighestBitrate();
            ListViewItem ListAudio = new ListViewItem();
            ListAudio.Text = "Audio";
            ListAudio.SubItems.Add(Math.Round(streamInfoAudio.Bitrate.MegaBitsPerSecond, 2).ToString() + " Mbps");
            ListAudio.SubItems.Add(Math.Round(streamInfoAudio.Size.TotalMegaBytes).ToString() + " MB");
            ListAudio.SubItems.Add(streamInfoAudio.Container.Name.ToString());
            ListAudio.Tag = streamInfoAudio.Url;
            listView1.Items.Add(ListAudio);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        string DownloadLocation = string.Empty;
        private void Btndownload_Click(object sender, EventArgs e)
        {
            Btndownload.Enabled = false;
            FolderBrowserDialog fdialo = new FolderBrowserDialog();
            if (fdialo.ShowDialog() == DialogResult.OK)
            {
                DownloadLocation = fdialo.SelectedPath;

            }
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            string FullFileName = DownloadLocation + "\\" + CleanFileName(TextVideoName.Text) + "." 
                + listView1.SelectedItems[0].SubItems[3].Text;

            DownloadFileWithProgress(listView1.SelectedItems[0].Tag.ToString(), FullFileName, progressBarDownload, labelProgress);   
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Btndownload.Enabled = true;
            MessageBox.Show("Done");

        }

        public string CleanFileName(string fileName)
        {
            return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
        }

        private void DownloadFileWithProgress(string DownloadLink, string TargetPath, ProgressBar progress, Label labelProgress)
        {
            //Start Download
            // Function will return the number of bytes processed
            // to the caller. Initialize to 0 here.
            int bytesProcessed = 0;

            // Assign values to these objects here so that they can
            // be referenced in the finally block
            Stream remoteStream = null;
            Stream localStream = null;
            WebResponse response = null;

            // Use a try/catch/finally block as both the WebRequest and Stream
            // classes throw exceptions upon error
            try
            {
                // Create a request for the specified remote file name
                WebRequest request = WebRequest.Create(DownloadLink);
                if (request != null)
                {
                    // Send the request to the server and retrieve the
                    // WebResponse object 

                    // Get the Full size of the File
                    double TotalBytesToReceive = 0;
                    var SizewebRequest = HttpWebRequest.Create(new Uri(DownloadLink));
                    SizewebRequest.Method = "HEAD";

                    using (var webResponse = SizewebRequest.GetResponse())
                    {
                        var fileSize = webResponse.Headers.Get("Content-Length");
                        TotalBytesToReceive = Convert.ToDouble(fileSize);
                    }

                    response = request.GetResponse();
                    if (response != null)
                    {
                        // Once the WebResponse object has been retrieved,
                        // get the stream object associated with the response's data
                        remoteStream = response.GetResponseStream();

                        // Create the local file

                        string filePath = TargetPath;


                        localStream = File.Create(filePath);

                        // Allocate a 1k buffer
                        byte[] buffer = new byte[1024];
                        int bytesRead = 0;

                        // Simple do/while loop to read from stream until
                        // no bytes are returned
                        do
                        {

                            // Read data (up to 1k) from the stream
                            bytesRead = remoteStream.Read(buffer, 0, buffer.Length);

                            // Write the data to the local file
                            localStream.Write(buffer, 0, bytesRead);

                            // Increment total bytes processed
                            bytesProcessed += bytesRead;


                            double bytesIn = double.Parse(bytesProcessed.ToString());
                            double percentage = bytesIn / TotalBytesToReceive * 100;
                            percentage = Math.Round(percentage, 0);


                            // Safe Update
                            //Increment the progress bar
                            if (progress.InvokeRequired)
                            {
                                progress.Invoke(new Action(() => progress.Value = int.Parse(Math.Truncate(percentage).ToString())));
                            }
                            else
                            {
                                progress.Value = int.Parse(Math.Truncate(percentage).ToString());
                            }

                            //Set the label progress Text
                            if (labelProgress.InvokeRequired)
                            {
                                labelProgress.Invoke(new Action(() => labelProgress.Text = int.Parse(Math.Truncate(percentage).ToString()).ToString() + " %"));
                            }
                            else
                            {
                                labelProgress.Text = int.Parse(Math.Truncate(percentage).ToString()).ToString() + " %";
                            }



                        } while (bytesRead > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                // Catch any errors
            }
            finally
            {
                // Close the response and streams objects here 
                // to make sure they're closed even if an exception
                // is thrown at some point
                if (response != null) response.Close();
                if (remoteStream != null) remoteStream.Close();
                if (localStream != null) localStream.Close();
            }
        }


    }
}
