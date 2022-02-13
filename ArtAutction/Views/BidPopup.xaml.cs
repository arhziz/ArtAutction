using ArtAutction.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtAutction.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BidPopup : ContentView
    {
        bool isExpanded = false;
        double DisplayHeight;

        public BidPopup()
        {
            InitializeComponent();
        }
        
        internal async void Display(double height)
        {
            //display the bid panel
            DisplayHeight = height - (FirstBoxHeight.Height);
            await this.TranslateTo(0, DisplayHeight, 300, Easing.Linear);
            



        }

        private void MakeBidDown_Swiped(object sender, SwipedEventArgs e)
        {
            if (isExpanded)
            {
               
                Collapse(Height);
            }
                
            if (!isExpanded && this.TranslationY > 0)
            {
                this.TranslateTo(0, Height, 300, Easing.Linear);
                ((MainPage)this.GetParentPage()).HidePageFader();
            }
               

                
        }

        private async void Collapse(double height)
        {
            MakeBidExpandGrid.IsVisible = false;
            await MakeBidExpandGrid.FadeTo(0, 10);
            _ = MakeBidTitle.FadeTo(1, 300, Easing.Linear);
            await this.TranslateTo(0, DisplayHeight, 400, Easing.Linear);
            isExpanded = false;
        }

        private void MakeBid_Tapped(object sender, EventArgs e)
        {
            //if it's not expanded already then expand
            if (!isExpanded)
                Expand();
        }
        /// <summary>
        /// it epands the make pbid panel
        /// </summary>
        private async void Expand()
        {
            //setup the initial states
            //Translate the grid to the bottom of the page
            MakeBidExpandGrid.IsVisible = true;
            await MakeBidExpandGrid.FadeTo(0, 10);
            MakeBidExpandGrid.Opacity = 0;
            MakeBidBtn.TranslationY = Height;

            _= this.TranslateTo(0, Height - (FirstBoxHeight.Height), 500, Easing.Linear);
            _= MakeBidTitle.FadeTo(0, 400, Easing.Linear);
            await MakeBidExpandGrid.FadeTo(1, 400, Easing.Linear);
            _ = MakeBidBtn.TranslateTo(0, 0, 300, Easing.Linear);

            isExpanded = true;

        }
    }
}