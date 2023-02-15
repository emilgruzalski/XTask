using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System;
using XTask.ViewModels;

namespace XTask.Views
{
    public partial class InstalledAppsViewerWindow : ReactiveWindow<InstalledAppsViewerViewModel>
    {
        public InstalledAppsViewerWindow()
        {
            InitializeComponent();

            this.WhenActivated(d => d(ViewModel!.OpenAppCommand.Subscribe(Close)));
        }
    }
}
