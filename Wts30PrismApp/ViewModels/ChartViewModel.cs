using System;
using System.Collections.ObjectModel;

using Prism.Windows.Mvvm;

using Wts30PrismApp.Core.Models;
using Wts30PrismApp.Core.Services;

namespace Wts30PrismApp.ViewModels
{
    public class ChartViewModel : ViewModelBase
    {
        private readonly ISampleDataService _sampleDataService;

        public ChartViewModel(ISampleDataService sampleDataServiceInstance)
        {
            _sampleDataService = sampleDataServiceInstance;
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return _sampleDataService.GetChartSampleData();
            }
        }
    }
}
