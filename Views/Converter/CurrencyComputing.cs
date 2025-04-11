using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Client.Views
{
    internal class CurrencyComputing
    {
        public static decimal Convert(decimal amount, string fromCurrency, string toCurrency)
        {
            // Этап 1: Конвертация ИЗ исходной валюты В USD
            decimal amountInUsd = fromCurrency switch  // 3 проверки (USD/EUR/RUR)
            {
                "USD" => amount * 1m,
                "EUR" => amount * 1.13m,
                "RUR" => amount * 0.011m
            };

            // Этап 2: Конвертация ИЗ USD В целевую валюту
            return toCurrency switch  // Ещё 3 проверки (USD/EUR/RUR)
            {
                "USD" => amountInUsd / 1m,
                "EUR" => amountInUsd / 1.13m,
                "RUR" => amountInUsd / 0.011m
            };
        }

    }
}
