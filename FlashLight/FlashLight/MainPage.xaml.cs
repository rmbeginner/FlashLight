using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace FlashLight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonOn_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOnAsync();
            }
            catch (Exception)
            {
            }


        }

        private async void ButtonOff_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOffAsync();
            }
            catch (Exception)
            {
            }
        }
    }    
}
