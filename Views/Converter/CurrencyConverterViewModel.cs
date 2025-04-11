using ReactiveUI;
using System;
using System.Reactive.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace CurrencyConverter.Client.Views
{
    public sealed partial class CurrencyConverterViewModel : ReactiveObject
    {
        private decimal? _leftValue;
        private decimal? _rightValue;
        private string _leftCurrency;
        private string _rightCurrency;

        public decimal? LeftValue
        {
            get => _leftValue;
            set
            {
                this.RaiseAndSetIfChanged(ref _leftValue, value);
                UpdateConversion();
            }
        }

        public decimal? RightValue
        {
            get => _rightValue;
            set => this.RaiseAndSetIfChanged(ref _rightValue, value);
        }

        public string LeftCurrency
        {
            get => _leftCurrency;
            set
            {
                this.RaiseAndSetIfChanged(ref _leftCurrency, value);
                UpdateConversion();
            }
        }

        public string RightCurrency
        {
            get => _rightCurrency;
            set
            {
                this.RaiseAndSetIfChanged(ref _rightCurrency, value);
                UpdateConversion();
            }
        }

        public CurrencyConverterViewModel()
        {
            LeftCurrency = "RUR";
            RightCurrency = "USD";
        }

        public void SetLeftCurrency(string currency)
        {
            LeftCurrency = currency; // Вызовет автоматическую конвертацию через UpdateConversion()
        }

        public void SetRightCurrency(string currency)
        {
            RightCurrency = currency;
        }

        private void UpdateConversion()
        {
            if (LeftValue.HasValue)
            {
                RightValue = CurrencyComputing.Convert(LeftValue.Value, LeftCurrency, RightCurrency);
            }
        }

        public void SwapCurrencies()
        {
            (LeftCurrency, RightCurrency) = (RightCurrency, LeftCurrency);
        }
    }
}