using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using ArtGallery.Core.Models;
using ArtGallery.Core.Services;
using ArtGallery.Helpers;

using Windows.UI.Xaml.Navigation;

namespace ArtGallery.ViewModels
{
    public class Customer_Art_ViewViewModel : Observable
    {
        private object _selectedImage;

        public object SelectedImage
        {
            get => _selectedImage;
            set
            {
                Set(ref _selectedImage, value);
                ImagesNavigationHelper.UpdateImageId(Famous_Art_by_ArtistViewModel.Famous_Art_by_ArtistSelectedIdKey, ((SampleImage)SelectedImage)?.ID);
            }
        }

        public ObservableCollection<SampleImage> Source { get; } = new ObservableCollection<SampleImage>();

        public Customer_Art_ViewViewModel()
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

        public void Initialize(string selectedImageID, NavigationMode navigationMode)
        {
            if (!string.IsNullOrEmpty(selectedImageID) && navigationMode == NavigationMode.New)
            {
                SelectedImage = Source.FirstOrDefault(i => i.ID == selectedImageID);
            }
            else
            {
                selectedImageID = ImagesNavigationHelper.GetImageId(Famous_Art_by_ArtistViewModel.Famous_Art_by_ArtistSelectedIdKey);
                if (!string.IsNullOrEmpty(selectedImageID))
                {
                    SelectedImage = Source.FirstOrDefault(i => i.ID == selectedImageID);
                }
            }
        }
    }
}
