using System;

using ArtGallery.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ArtGallery.Views
{
    public sealed partial class HomePage : Page
    {
        public HomeViewModel ViewModel { get; } = new HomeViewModel();

        public HomePage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
