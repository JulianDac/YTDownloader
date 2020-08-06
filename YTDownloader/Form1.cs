using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            await AsyncGetLinks();
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
    }
}
