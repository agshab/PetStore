
using System.Text.Json;
using PetStore.Interfaces;

namespace PetStore.Classes
{
    internal class UILogic
    {
        /// <summary>
        /// Manages the user interface for the PetStore application.
        /// </summary>
        public UILogic(IProductLogic prLogic)
        {
        }

        /// <summary>
        /// Runs the main loop of the user interface.
        /// </summary>
        public void Run()
        {

            Dogleash mydogleashisblue = new Dogleash(); // mydogleashisblue = new DogLeash(); Could be said either way)
            CatFood mycatfood = new CatFood(); ; // CatFood mycatfoodloveisland; Could be said either way)
            ProductLogic logic = new ProductLogic();

            Console.WriteLine(" Press 1 to read Json file \n Press 2 to view a CatFoodd \n Press 3 to view a DogLeash \n Press 4 to view current products in stock \n Press 5 to get total price of inventory \n Type 'exit' to quit \n");
            string userInput = Console.ReadLine() ?? "exit"; // " ?? and exit- is there so when the user leaves this feild empty


            while (userInput.ToLower() != "exit") // this means the user put any of the first top three options
            {
                if (userInput == "1")
                {
                    string filepath = "\\Users\\arshiashabbir\\Documents\\C#\\PetStore\\PetStore\\JsonFiles\\Myfile.json";

                    Console.WriteLine("Press 1 for Cat Food, 2 for Dog Leash):");
                    string? productTypeInput = Console.ReadLine();

                    try
                    {
                        string jsonInput = File.ReadAllText(filepath);
                        Console.WriteLine(" Entering the path to the JSON file automatically.......\n");
                        if (productTypeInput == "1")
                        {
                            CatFood? catFood = JsonSerializer.Deserialize<CatFood>(jsonInput);
                            logic.AddProduct(catFood);
                        }
                        else if (productTypeInput == "2")
                        {
                            Dogleash? dogLeash = JsonSerializer.Deserialize<Dogleash>(jsonInput);
                            logic.AddProduct(dogLeash);
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error reading or deserializing the JSON file. Product not added.");
                    }
                }                
                else if (userInput == "2") // this is to view the product to find the product input the user has enter

                {
                    Console.WriteLine("Enter the catfood name:");
                    string catFood = Console.ReadLine();

                    CatFood catfood = logic.GetItemByName<CatFood>(catFood);

                    if (catFood != null)
                    {
                        Console.WriteLine("Cat Food found:");
                        Console.WriteLine(JsonSerializer.Serialize(mycatfood));
                    }
                    else
                    {
                        Console.WriteLine("CatFood notfound!");
                    }
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("Enter the DogLeash name:");
                    string dogleash = Console.ReadLine();

                    Dogleash dogLeash = logic.GetItemByName<Dogleash>(dogleash);

                    if (dogLeash != null)
                    {
                        Console.WriteLine("Dog Leash found:");
                        Console.WriteLine(JsonSerializer.Serialize(dogleash));
                    }
                    else
                    {
                        Console.WriteLine("DogLeash notfound!");
                    }
                }
                else if (userInput == "4")

                {
                    IList<Product> myitemlist = logic.GetOnlyInStockProducts();
                    foreach (var item in myitemlist) { Console.WriteLine(item.Name); }
                }

                else if (userInput == "5")
                {
                    var TotalPrice = logic.GetTotalPriceOfInventory();

                    Console.WriteLine($"Total price of the inventory is {TotalPrice}");
                }

                Console.WriteLine(" Press 1 to read Json file \n Press 2 to view a CatFoodd \n Press 3 to view a DogLeash \n Press 4 to view current products in stock \n Press 5 to get total price of inventory \n Type 'exit' to quit \n");
                userInput = Console.ReadLine() ?? "exit";

            }
        }

    }

}
