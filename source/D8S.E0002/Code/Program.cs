using System;

using Microsoft.Extensions.DependencyInjection;


namespace D8S.E0002
{
    class Program
    {
        static void Main()
        {
            Program.CreateEmptyProvider();
        }

        static void CreateEmptyProvider()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            // Now you have a service provider.
        }
    }
}