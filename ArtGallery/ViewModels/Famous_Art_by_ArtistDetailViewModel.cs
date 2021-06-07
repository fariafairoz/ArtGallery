﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using ArtGallery.Core.Models;
using ArtGallery.Core.Services;
using ArtGallery.Helpers;

using WinUI = Microsoft.UI.Xaml.Controls;

namespace ArtGallery.ViewModels
{
    public class Famous_Art_by_ArtistDetailViewModel : Observable, IBackNavigationHandler
    {
        private WinUI.TwoPaneView _twoPaneView;
        private Art _selected;
        private ICommand _itemClickCommand;
        private ICommand _modeChangedCommand;

        private WinUI.TwoPaneViewPriority _twoPanePriority;

        public event EventHandler<bool> OnPageCanGoBackChanged;

        public Art Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public WinUI.TwoPaneViewPriority TwoPanePriority
        {
            get { return _twoPanePriority; }
            set { Set(ref _twoPanePriority, value); }
        }

        public ObservableCollection<Art> SampleItems { get; private set; } = new ObservableCollection<Art>();

        public ICommand ItemClickCommand => _itemClickCommand ?? (_itemClickCommand = new RelayCommand(OnItemClick));

        public ICommand ModeChangedCommand => _modeChangedCommand ?? (_modeChangedCommand = new RelayCommand<WinUI.TwoPaneView>(OnModeChanged));

        public Famous_Art_by_ArtistDetailViewModel()
        {
        }

        public void Initialize(WinUI.TwoPaneView twoPaneView)
        {
            _twoPaneView = twoPaneView;
        }

        public async Task LoadDataAsync()
        {
            SampleItems.Clear();

            var data = await DataForApp.GetTwoPaneViewDataAsync();

            foreach (var item in data)
            {
                SampleItems.Add(item);
            }

            Selected = SampleItems.First();
        }

        public bool TryCloseDetail()
        {
            if (TwoPanePriority == WinUI.TwoPaneViewPriority.Pane2)
            {
                TwoPanePriority = WinUI.TwoPaneViewPriority.Pane1;
                return true;
            }

            return false;
        }

        private void OnItemClick()
        {
            if (_twoPaneView.Mode == WinUI.TwoPaneViewMode.SinglePane)
            {
                OnPageCanGoBackChanged?.Invoke(this, true);
                TwoPanePriority = WinUI.TwoPaneViewPriority.Pane2;
            }
        }

        private void OnModeChanged(WinUI.TwoPaneView twoPaneView)
        {
            if (twoPaneView.Mode == WinUI.TwoPaneViewMode.SinglePane)
            {
                OnPageCanGoBackChanged?.Invoke(this, true);
                TwoPanePriority = WinUI.TwoPaneViewPriority.Pane2;
            }
            else
            {
                OnPageCanGoBackChanged?.Invoke(this, false);
                TwoPanePriority = WinUI.TwoPaneViewPriority.Pane1;
            }
        }

        public void GoBack()
        {
            if (TwoPanePriority == WinUI.TwoPaneViewPriority.Pane2)
            {
                TwoPanePriority = WinUI.TwoPaneViewPriority.Pane1;
                OnPageCanGoBackChanged?.Invoke(this, false);
            }
        }
    }
}
