using System;

using ArtGallery.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ArtGallery.Views
{
    public sealed partial class Famous_Art_by_ArtistPage : Page
    {
        public Famous_Art_by_ArtistViewModel ViewModel { get; } = new Famous_Art_by_ArtistViewModel();

        public Famous_Art_by_ArtistPage()
        {
            InitializeComponent();
            Loaded += Famous_Art_by_ArtistPage_Loaded;
        }

        private async void Famous_Art_by_ArtistPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync();
        }
    }
}
