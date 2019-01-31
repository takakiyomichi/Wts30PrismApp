﻿using System;

using Windows.UI.Xaml.Controls;

using Wts30PrismApp.ViewModels;

namespace Wts30PrismApp.Views
{
    public sealed partial class ChartPage : Page
    {
        private ChartViewModel ViewModel => DataContext as ChartViewModel;

        // TODO WTS: Change the chart as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/radchart/getting-started
        public ChartPage()
        {
            InitializeComponent();
        }
    }
}
