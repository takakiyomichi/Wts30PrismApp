using System;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using Wts30PrismApp.Core.Models;
using Wts30PrismApp.ViewModels;

namespace Wts30PrismApp.Views
{
    public sealed partial class ContentGridDetailPage : Page
    {
        public ContentGridDetailPage()
        {
            InitializeComponent();
        }

        private ContentGridDetailViewModel ViewModel => DataContext as ContentGridDetailViewModel;
    }
}
