using System;
using Microsoft.Extensions.DependencyInjection;

namespace PetStore
{
    internal class Program // Create the main function, the entry point of the project
    {
        static IServiceProvider CreateServiceCollection()
        {
            return new ServiceCollection().AddTransient<IProductLogic, ProductLogic>().BuildServiceProvider();
        }
            /// <summary>
            /// Entry point of the program
            /// </summary>
            /// <param name="args"></param>
            static void Main(string[] args)
            {

                IServiceProvider services = CreateServiceCollection();
                IProductLogic productLogic = services.GetService<IProductLogic>();
                UILogic PetStore = new UILogic(productLogic);
                PetStore.Run();

                if (services is IDisposable disposable)
                {
                    Console.WriteLine("Services object from IServiceProvider has been deleted");
                    disposable.Dispose();
                }

            }
        
    }
}

















