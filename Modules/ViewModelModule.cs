using Autofac;
using CurrencyConverter.Client;
using CurrencyConverter.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Client.Modules
{
    internal class ViewModelsModule : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<MainWindowView>()
                .AsSelf()
                .SingleInstance();
            builder
                .RegisterType<MainWindowViewModel>()
                .AsSelf()
                .SingleInstance();
        }
    }
}
