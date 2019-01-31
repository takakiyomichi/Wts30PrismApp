using System;

using Windows.UI.Xaml.Controls;

using Wts30PrismApp.ViewModels;

namespace Wts30PrismApp.Views
{
    public sealed partial class ImageGalleryPage : Page
    {
        private ImageGalleryViewModel ViewModel => DataContext as ImageGalleryViewModel;

        public ImageGalleryPage()
        {
            InitializeComponent();
        }
    }
}
