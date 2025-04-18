using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;

namespace FinancialClassifier.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        private object _pageContent;

        public ICommand SwitchToOverview { get; }
        public ICommand SwitchToSettings { get; }

        public object PageContent 
        { 
            get => _pageContent; 
            set => SetProperty<object>(ref _pageContent, value); 
        }

        public MainWindowViewModel(IServiceProvider serviceProvider)
        {
            var overviewViewModel = ActivatorUtilities.CreateInstance(serviceProvider, typeof(OverviewViewModel));
            var settingsViewModel = ActivatorUtilities.CreateInstance(serviceProvider, typeof(SettingsViewModel));

            SwitchToOverview = new RelayCommand(() => PageContent = overviewViewModel);
            SwitchToSettings = new RelayCommand(() => PageContent = settingsViewModel);
        }
    }
}
