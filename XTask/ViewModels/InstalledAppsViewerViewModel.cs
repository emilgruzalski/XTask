using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace XTask.ViewModels
{
    public class InstalledAppsViewerViewModel : ViewModelBase
    {
        public InstalledAppsViewerViewModel() 
        {
            SearchResults.Add(new InstalledAppViewModel());
            SearchResults.Add(new InstalledAppViewModel());
            SearchResults.Add(new InstalledAppViewModel());

            OpenAppCommand = ReactiveCommand.Create(() =>
            {
                return SelectedApp;
            });
        }

        private InstalledAppViewModel? _selectedApp;
        private bool _isBusy;
        private string? _searchText;

        public ObservableCollection<InstalledAppViewModel> SearchResults { get; } = new();

        public string? SearchText 
        {
            get => _searchText;
            set => this.RaiseAndSetIfChanged(ref _searchText, value);  
        }

        public bool IsBusy 
        {
            get => _isBusy;
            set => this.RaiseAndSetIfChanged(ref _isBusy, value);
        }

        public InstalledAppViewModel? SelectedApp 
        {
            get => _selectedApp;
            set => this.RaiseAndSetIfChanged(ref _selectedApp, value);
        }

        public ReactiveCommand<Unit, InstalledAppViewModel?> OpenAppCommand { get; }

    }
}
