using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ArtAutction
{
    public partial class MainPage : ContentPage
    {
        public async void PageFader_Tapped(object sender, EventArgs e)
        {
            //Get the page height
            var pageHeight = Height;
            await ArtistPop.TranslateTo(0, pageHeight, 300);
            ArtistPop.TranslationY = pageHeight;

            await BidPop.TranslateTo(0, pageHeight, 300);
            BidPop.TranslationY = pageHeight;

            PageFader.IsVisible = false;
        }
        public  void HidePageFader()
        {
            //Get the page height
            //var pageHeight = Height;
            //await ArtistPop.TranslateTo(0, pageHeight, 600);
            //ArtistPop.TranslationY = pageHeight;

            PageFader.IsVisible = false;
        }
        public MainPage()
        {
            InitializeComponent();
        }

        private void ArtistDetailsPopup_Tapped(object sender, EventArgs e)
        {
            //display the page fader
            PageFader.IsVisible = true;
            //translate the artist details popup
            ArtistPop.Display(Height);  
        }

        private void BidPopup_Tapped(object sender, EventArgs e)
        {
            //display the page fader
            PageFader.IsVisible = true;
            //Display the bid panel
            BidPop.Display(Height);

        }

        private void MakeBidBtn_Clicked(object sender, EventArgs e)
        {
            //display the page fader
            PageFader.IsVisible = true;
            //Display the bid panel
            BidPop.Display(Height);
        }

        private async void Wikipedia_Tapped(object sender, EventArgs e)
        {
            var uri = new Uri("https://wikipedia.org");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}
