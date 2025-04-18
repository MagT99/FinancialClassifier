using FinancialClassifier.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialClassifier.Models
{
    class DependencyRegistration
    {
        private readonly ServiceCollection _serviceCollection = new();
        internal IServiceProvider Build()
        {
           return _serviceCollection.BuildServiceProvider();
        }
    }
}
