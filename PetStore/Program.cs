using System;
using PetStore;
using System.Text.Json;



namespace PetStore
{
    internal class program // Create the main function, the entry point of the project
    {
        static void Main(string[] args)
        {
            IProductLogic IproductLogic = new ProductLogic();

            UILogic PetStore = new UILogic(IproductLogic);

            PetStore.Run();

        }
    }
}






















