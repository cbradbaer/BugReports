using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxMaui
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisableTestPage : ContentPage
    {
        public DisableTestPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            layoutOne.IsEnabled = !layoutOne.IsEnabled;
            btnEnable.Text = layoutOne.IsEnabled ? "Disable" : "Enable";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            btnEnable.BackgroundColor = btnEnable.BackgroundColor == Red ? Black : Red;
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selected = e.CurrentSelection[0].ToString();
            await DisplayAlert("test", selected, "OK");
        }
    }
}
