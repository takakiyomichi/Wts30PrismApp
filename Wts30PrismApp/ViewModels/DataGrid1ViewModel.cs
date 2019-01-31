using System.Collections.ObjectModel;

using Prism.Windows.Mvvm;

using Wts30PrismApp.Core.Models;
using Wts30PrismApp.Core.Services;

namespace Wts30PrismApp.ViewModels
{
    public class DataGrid1ViewModel : ViewModelBase
    {
        private readonly ISampleDataService _sampleDataService;

        public DataGrid1ViewModel(ISampleDataService sampleDataServiceInstance)
        {
            _sampleDataService = sampleDataServiceInstance;
        }

        public ObservableCollection<SampleOrder> Source => _sampleDataService.GetGridSampleData();
    }
}
