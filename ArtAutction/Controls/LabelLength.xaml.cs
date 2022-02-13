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
    public partial class LabelLength : ContentView
    {
        
        

        public LabelLength()
        {
            InitializeComponent();
        }



        #region TxtAlignment
        public static readonly BindableProperty TxtAlignmentProperty = BindableProperty.Create(nameof(TxtAlignment), typeof(TextAlignment), typeof(LabelLength), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as LabelLength;
            if (newV != null && !(newV is TextAlignment)) return;
            var oldTxtAlignment = (TextAlignment)old;
            var newTxtAlignment = (TextAlignment)newV;
            me?.TxtAlignmentChanged(oldTxtAlignment, newTxtAlignment);
        });

        private void TxtAlignmentChanged(TextAlignment oldTxtAlignment, TextAlignment newTxtAlignment)
        {
            lbl.HorizontalTextAlignment = newTxtAlignment;
        }

        /// <summary>
        /// TxtAlignment
        /// </summary>
        public TextAlignment TxtAlignment
        {
            get => (TextAlignment)GetValue(TxtAlignmentProperty);
            set => SetValue(TxtAlignmentProperty, value);
        }
        #endregion



        bool isExpanded = false;

        private void Label_Tapped(object sender, EventArgs e)
        {
            var theLabel = (Label)sender;
            
            if(Text.Length >= MaxLength && !isExpanded)
            {
                theLabel.Text = Text;
                isExpanded = true;
            }
            else
            {
                var text = $"{Text.Substring(0, MaxLength)}...";
                theLabel.FormattedText = new FormattedString();
                theLabel.FormattedText.Spans.Add(new Span
                {
                    Text = text,
                    TextColor = Color.White
                });
                theLabel.FormattedText.Spans.Add(new Span
                {
                    Text = " Read More",
                    TextColor = ReadMore
                });

                isExpanded = false;
            }
        }


        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text),
                        typeof(string),
                        typeof(LabelLength),
                        default(string),
                        BindingMode.OneWay,
                        propertyChanged: OnTextChanged);

        static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = (LabelLength)bindable;

            var myText = view.Text;

            if (myText.Length >= view.MaxLength)
            {
                var text = $"{myText.Substring(0, view.MaxLength)}...";
                view.lbl.FormattedText = new FormattedString();
                view.lbl.FormattedText.Spans.Add(new Span
                {
                    Text = text,
                    TextColor = Color.White
                });
                view.lbl.FormattedText.Spans.Add(new Span
                {
                    Text = " Read More",
                    TextColor = view.ReadMore
                });

            }
            else
            {
                view.lbl.Text = myText;
            }
        }

        public string Text { get => (string)GetValue(TextProperty); set => SetValue(TextProperty, value); }


        public static readonly BindableProperty MaxLengthProperty =
            BindableProperty.Create(nameof(MaxLength),
                        typeof(int),
                        typeof(LabelLength),
                        default(int),
                        BindingMode.OneWay);

        public int MaxLength { get => (int)GetValue(MaxLengthProperty); set => SetValue(MaxLengthProperty, value); }


        public static readonly BindableProperty ReadMoreProperty =
            BindableProperty.Create(nameof(ReadMore),
                        typeof(Color),
                        typeof(LabelLength),
                        default(Color),
                        BindingMode.OneWay);

        public Color ReadMore { get => (Color)GetValue(ReadMoreProperty); set => SetValue(ReadMoreProperty, value); }

    }
}