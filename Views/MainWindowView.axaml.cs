using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace CurrencyConverter.Client.Views
{
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            AvaloniaXamlLoader.Load(this); // Временная замена
        }
    }
}