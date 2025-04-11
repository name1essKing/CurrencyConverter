using CurrencyConverter.UI;
using CurrencyConverter.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Client.Views
{
    public partial class MainWindowViewModel : ReactiveViewModelBase
    {


        public CurrencyConverterViewModel CurrencyConverterViewModel { get; }


        //конструктор 
        public MainWindowViewModel()
        {
            CurrencyConverterViewModel = new CurrencyConverterViewModel();

        }


    }
}
