using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.MediaManager;
using Xamarin.Forms;

namespace VideoExemplo
{
    public partial class MainPage : ContentPage
    {
        private string Url { get; set; }
        private bool Reproduzindo { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Url = "http://www.html5videoplayer.net/videos/toystory.mp4";
            Reproduzindo = false;
        }

        void btnVideo_Clicked(object sender, System.EventArgs e)
        {
            if (!Reproduzindo)
            {
                btnVideo.Text = "Parar";
                CrossMediaManager.Current.Play(Url, Plugin.MediaManager.Abstractions.Enums.MediaFileType.Video);
                Reproduzindo = true;
            }
            else if (Reproduzindo)
            {
                btnVideo.Text = "Reproduzir";
                CrossMediaManager.Current.Stop();
                Reproduzindo = false;
            }
        }
    }
}
