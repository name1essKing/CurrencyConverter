using ReactiveUI;
using System;
using System.Reactive;

namespace CurrencyConverter.Client.Views
{
    public sealed partial class CurrencyConverterViewModel
    {
        public sealed class CurrencyConverterViewModelCommands
        {
            private readonly CurrencyConverterViewModel _vm;

            public CurrencyConverterViewModelCommands(CurrencyConverterViewModel vm)
            {
                _vm = vm;

                SetLeftCurrency = ReactiveCommand.Create<string>(currency =>
                {
                    _vm.LeftCurrency = currency;
                });

                SetRightCurrency = ReactiveCommand.Create<string>(currency =>
                {
                    _vm.RightCurrency = currency;
                });

                Swap = ReactiveCommand.Create(() =>
                {
                    _vm.SwapCurrencies();
                });
            }

            public ReactiveCommand<string, Unit> SetLeftCurrency { get; }
            public ReactiveCommand<string, Unit> SetRightCurrency { get; }
            public ReactiveCommand<Unit, Unit> Swap { get; }
        }

        private CurrencyConverterViewModelCommands _commands;
        public CurrencyConverterViewModelCommands Commands => _commands ??= new(this);
    }
}