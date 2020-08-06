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
            

            // Get highest quality muxed stream
            var streamInfoMuxedHVQ = streamManifest.GetMuxed().WithHighestVideoQuality();

            // ...or highest bitrate audio-only stream
            var streamInfoAudio = streamManifest.GetAudioOnly().WithHighestBitrate();

            ListViewItem NewItem = new ListViewItem();
            NewItem.Text = "Video/Audio";
            NewItem.SubItems.Add(streamInfoMuxedHVQ.VideoQualityLabel);
            NewItem.SubItems.Add(Math.Round(streamInfoMuxedHVQ.Size.TotalMegaBytes).ToString() + " MB");
            NewItem.SubItems.Add(streamInfoMuxedHVQ.Container.Name.ToString());

            listView1.Items.Add(NewItem);
        }


    }
}
