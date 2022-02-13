using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ArtAutction.Extensions;

namespace ArtAutction.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArtistDetailsPopup : ContentView
    {
        public double FirstSectionHeight { get; set; }
        public ArtistDetailsPopup()
        {
            InitializeComponent();
            
        }

        //Display the artist popup page
        internal void Display(double theHeight)
        {
            
            //display the artist popup
            this.TranslateTo(0, theHeight - (TheBoxView.Height + 40), 300, Easing.Linear);
        }

        internal void Expand()
        {
            //expand the artist details 
            this.TranslateTo(0, 0, 300, Easing.Linear);
        }

        private void ArtistDetailsUp_Swiped(object sender, SwipedEventArgs e)
        {
            //Expand on swip up
            Expand();
        }
        private async void ArtistDetailsDown_Swiped(object sender, SwipedEventArgs e)
        {
            //collapse the artist details
            if(this.TranslationY == 0)
            {
                Display(Height);
            }
            else
            {
                var pageHeight = Height;
                await this.TranslateTo(0, pageHeight, 300);
                this.TranslationY = pageHeight;
                ((MainPage)this.GetParentPage()).HidePageFader();

            }
            
        }
    }
}