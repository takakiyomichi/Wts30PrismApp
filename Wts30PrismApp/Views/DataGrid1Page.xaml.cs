using System;

using Windows.UI.Xaml.Controls;

using Wts30PrismApp.ViewModels;

namespace Wts30PrismApp.Views
{
    public sealed partial class DataGrid1Page : Page
    {
        private DataGrid1ViewModel ViewModel => DataContext as DataGrid1ViewModel;

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on DataGrid1Page.xaml.
        // For more details see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid
        public DataGrid1Page()
        {
            InitializeComponent();
        }
    }
}
