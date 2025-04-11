using Autofac;
using Splat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Services
{
    /// <summary>
	/// The registration service.
	/// </summary>
	static class RegistrationService
    {
        /// <summary>
        /// Creates the container.
        /// </summary>
        /// <param name="appServices">The app services.</param>
        /// <returns>An IContainer.</returns>
        public static Autofac.IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(typeof(CurrencyConverter.Client.App).Assembly);

            var container = builder.Build();

            return container;
        }
    }
}
