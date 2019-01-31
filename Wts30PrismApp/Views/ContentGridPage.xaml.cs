using System;

using Windows.UI.Xaml.Controls;

using Wts30PrismApp.ViewModels;

namespace Wts30PrismApp.Views
{
    public sealed partial class ContentGridPage : Page
    {
        private ContentGridViewModel ViewModel => DataContext as ContentGridViewModel;

        public ContentGridPage()
        {
            InitializeComponent();
        }
    }
}
