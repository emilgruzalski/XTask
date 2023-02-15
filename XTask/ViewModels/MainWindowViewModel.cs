using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using System.Windows.Input;

namespace XTask.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel() 
        {
            ShowDialog = new Interaction<InstalledAppsViewerViewModel, InstalledAppViewModel?>();

            OpenAppCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var viewer = new InstalledAppsViewerViewModel();

                var result = await ShowDialog.Handle(viewer);
            });
        }

        public ICommand OpenAppCommand { get; }

        public Interaction<InstalledAppsViewerViewModel, InstalledAppViewModel?> ShowDialog { get; }
    }
}
