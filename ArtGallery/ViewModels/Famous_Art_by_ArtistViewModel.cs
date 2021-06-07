using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

using ArtGallery.Core.Models;
using ArtGallery.Core.Services;
using ArtGallery.Helpers;
using ArtGallery.Services;
using ArtGallery.Views;

using Microsoft.Toolkit.Uwp.UI.Animations;

using Windows.UI.Xaml.Controls;

namespace ArtGallery.ViewModels
{
    public class Famous_Art_by_ArtistViewModel : Observable
    {
        public const string Famous_Art_by_ArtistSelectedIdKey = "Famous_Art_by_ArtistSelectedIdKey";

        private ICommand _itemSelectedCommand;

        public ObservableCollection<SampleImage> Source { get; } = new ObservableCollection<SampleImage>();

        public ICommand ItemSelectedCommand => _itemSelectedCommand ?? (_itemSelectedCommand = new RelayCommand<ItemClickEventArgs>(OnItemSelected));

        public Famous_Art_by_ArtistViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            
            var data = await DataForApp.GetImageGalleryDataAsync("ms-appx:///Assets");

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }

        private void OnItemSelected(ItemClickEventArgs args)
        {
            var selected = args.ClickedItem as SampleImage;
            ImagesNavigationHelper.AddImageId(Famous_Art_by_ArtistSelectedIdKey, selected.ID);
            NavigationService.Frame.SetListDataItemForNextConnectedAnimation(selected);
            NavigationService.Navigate<Famous_Art_by_ArtistDetailPage>(selected.ID);
        }
    }
}
