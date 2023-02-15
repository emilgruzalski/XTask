using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System.Threading.Tasks;
using XTask.ViewModels;

namespace XTask.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WhenActivated(d => d(ViewModel!.ShowDialog.RegisterHandler(DoShowDialogAsync)));
        }

        private async Task DoShowDialogAsync(InteractionContext<InstalledAppsViewerViewModel, InstalledAppViewModel?> interaction) 
        {
            var dialog = new InstalledAppsViewerWindow();
            dialog.DataContext= interaction.Input;

            var result = await dialog.ShowDialog<InstalledAppViewModel?>(this);
            interaction.SetOutput(result);
        }
    }
}
