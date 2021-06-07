using ArtGallery.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ArtGallery.Views
{
    public sealed partial class Customer_Art_ViewDetailControl : UserControl
    {
        public Art SelectedItem
        {
            get { return GetValue(SelectedItemProperty) as Art; }
            set { SetValue(SelectedItemProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register(nameof(SelectedItem), typeof(Art), typeof(Customer_Art_ViewDetailControl), new PropertyMetadata(null, OnSelectedItemPropertyChanged));

        public Customer_Art_ViewDetailControl()
        {
            InitializeComponent();
        }

        private static void OnSelectedItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as Customer_Art_ViewDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
