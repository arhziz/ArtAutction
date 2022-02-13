using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtAutction.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArtsDetails : ContentView
    {
        public ArtsDetails()
        {
            InitializeComponent();
        }



        #region TheTitle
        public static readonly BindableProperty TheTitleProperty = BindableProperty.Create(nameof(TheTitle), typeof(string), typeof(ArtsDetails), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as ArtsDetails;
            if (newV != null && !(newV is string)) return;
            var oldTheTitle = (string)old;
            var newTheTitle = (string)newV;
            me?.TheTitleChanged(oldTheTitle, newTheTitle);
        });

        private void TheTitleChanged(string oldTheTitle, string newTheTitle)
        {
            TitleLabel.Text = newTheTitle;
        }

        /// <summary>
        /// The Title
        /// </summary>
        public string TheTitle
        {
            get => (string)GetValue(TheTitleProperty);
            set => SetValue(TheTitleProperty, value);
        }
        #endregion



        #region TheImage
        public static readonly BindableProperty TheImageProperty = BindableProperty.Create(nameof(TheImage), typeof(ImageSource), typeof(ArtsDetails), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as ArtsDetails;
            if (newV != null && !(newV is ImageSource)) return;
            var oldTheImage = (ImageSource)old;
            var newTheImage = (ImageSource)newV;
            me?.TheImageChanged(oldTheImage, newTheImage);
        });

        private void TheImageChanged(ImageSource oldTheImage, ImageSource newTheImage)
        {
            ImageArt.Source = newTheImage;
        }

        /// <summary>
        /// TheImage
        /// </summary>
        public ImageSource TheImage
        {
            get => (ImageSource)GetValue(TheImageProperty);
            set => SetValue(TheImageProperty, value);
        }
        #endregion



        #region ThePrice
        public static readonly BindableProperty ThePriceProperty = BindableProperty.Create(nameof(ThePrice), typeof(string), typeof(ArtsDetails), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as ArtsDetails;
            if (newV != null && !(newV is string)) return;
            var oldThePrice = (string)old;
            var newThePrice = (string)newV;
            me?.ThePriceChanged(oldThePrice, newThePrice);
        });

        private void ThePriceChanged(string oldThePrice, string newThePrice)
        {
            PriceLabel.Text = newThePrice;
        }

        /// <summary>
        /// The Price
        /// </summary>
        public string ThePrice
        {
            get => (string)GetValue(ThePriceProperty);
            set => SetValue(ThePriceProperty, value);
        }
        #endregion




    }
}