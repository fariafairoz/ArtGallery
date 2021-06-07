using ArtGallery.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ArtGallery.Views
{
    public sealed partial class Customer_Art_ViewPage : Page
    {
        public Famous_Art_by_ArtistDetailViewModel ViewModel { get; } = new Famous_Art_by_ArtistDetailViewModel();

        public Customer_Art_ViewPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(twoPaneView);
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await ViewModel.LoadDataAsync();
        }
    }
}
