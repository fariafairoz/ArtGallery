using System;

using ArtGallery.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ArtGallery.Views
{
    public sealed partial class Customer_Art_ViewListItemControl : UserControl
    {
        public Art Item
        {
            get { return (Art)GetValue(ItemProperty); }
            set { SetValue(ItemProperty, value); }
        }

        public static readonly DependencyProperty ItemProperty = DependencyProperty.Register(nameof(Item), typeof(Art), typeof(Customer_Art_ViewListItemControl), new PropertyMetadata(null, OnItemPropertyChanged));

        public Customer_Art_ViewListItemControl()
        {
            InitializeComponent();
        }

        private static void OnItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
