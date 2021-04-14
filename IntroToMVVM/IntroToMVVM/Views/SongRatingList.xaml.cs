using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroToMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SongRatingList : ContentPage
    {
        public SongRatingList()
        {
            InitializeComponent();
        }

        private void ChangeValue(object sender, ValueChangedEventArgs e)
        {
            SliderLabel.Text = Convert.ToString(Convert.ToInt32(Rating.Value));
        }
    }
}