using System;
using consultant.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace consultant.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequestsListPage : ContentPage
    {
        public RequestsListPage()
        {
            InitializeComponent();

        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new ProductCardPage());
        }

        private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }
    }
}