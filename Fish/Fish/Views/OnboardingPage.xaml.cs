using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fish
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnboardingPage : ContentPage
    {
        public OnboardingPage()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            Radials.RadiusX = Width * 6;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await FadeBox.FadeTo(1, 1000);
            await Navigation.PopModalAsync(false); 
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //Radials.RadiusX = this.Width * e.NewValue;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}