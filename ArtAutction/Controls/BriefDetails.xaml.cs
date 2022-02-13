using ImageCircle.Forms.Plugin.Abstractions;
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
    public partial class BriefDetails : ContentView
    {
        public BriefDetails()
        {
            InitializeComponent();
        }



        #region Name
        public static readonly BindableProperty NameProperty = BindableProperty.Create(nameof(Name), typeof(string), typeof(BriefDetails), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as BriefDetails;
            if (newV != null && !(newV is string)) return;
            var oldName = (string)old;
            var newName = (string)newV;
            me?.NameChanged(oldName, newName);
        });

        private void NameChanged(string oldName, string newName)
        {
            NameLabel.Text = newName;
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }
        #endregion




        #region NameDetails
        public static readonly BindableProperty NameDetailsProperty = BindableProperty.Create(nameof(NameDetails), typeof(string), typeof(BriefDetails), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as BriefDetails;
            if (newV != null && !(newV is string)) return;
            var oldNameDetails = (string)old;
            var newNameDetails = (string)newV;
            me?.NameDetailsChanged(oldNameDetails, newNameDetails);
        });

        private void NameDetailsChanged(string oldNameDetails, string newNameDetails)
        {
            DetailsLabel.Text = newNameDetails;
        }

        /// <summary>
        /// Name Details
        /// </summary>
        public string NameDetails
        {
            get => (string)GetValue(NameDetailsProperty);
            set => SetValue(NameDetailsProperty, value);
        }
        #endregion




        #region NameImage
        public static readonly BindableProperty NameImageProperty = BindableProperty.Create(nameof(NameImage), typeof(ImageSource), typeof(BriefDetails), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as BriefDetails;
            if (newV != null && !(newV is ImageSource)) return;
            var oldNameImage = (ImageSource)old;
            var newNameImage = (ImageSource)newV;
            me?.NameImageChanged(oldNameImage, newNameImage);
        });

        private void NameImageChanged(ImageSource oldNameImage, ImageSource newNameImage)
        {
            BriefDeetsImage.Source = newNameImage;
        }

        /// <summary>
        /// NameImage
        /// </summary>
        public ImageSource NameImage
        {
            get => (ImageSource)GetValue(NameImageProperty);
            set => SetValue(NameImageProperty, value);
        }
        #endregion




    }
}