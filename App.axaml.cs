using Autofac;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using CurrencyConverter.Client.Views;
using CurrencyConverter.Services;

namespace CurrencyConverter.Client
{
    public partial class App : Application
    {
        private Autofac.IContainer? _container;

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            _container = RegistrationService.CreateContainer();

            if (_container == null)
                throw new InvalidOperationException("Container not initialized");

            var mainWindow = GetMainWindow(_container);

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = mainWindow;
            }

            mainWindow.Closed += OnMainWindowClosed;
            mainWindow.Show();
            mainWindow.Activate();

            base.OnFrameworkInitializationCompleted();
        }

        private MainWindowView GetMainWindow(Autofac.IContainer container)
        {
            var mainWindow = container.Resolve<MainWindowView>();
            mainWindow.DataContext = container.Resolve<MainWindowViewModel>();
            return mainWindow;
        }

        private void OnMainWindowClosed(object? sender, System.EventArgs e)
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.Shutdown(0);
            }
        }
    }
}