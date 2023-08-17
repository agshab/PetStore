using System;
using PetStore;
using System.Text.Json;



namespace PetStore
{
    internal class program // Create the main function, the entry point of the project
    {
        static void Main(string[] args)
        {
         
            DogLeash mydogleashisblue = new DogLeash(); // mydogleashisblue = new DogLeash(); Could be said either way)
            CatFood mycatfood = new CatFood(); ; // CatFood mycatfoodloveisland; Could be said either way)
            ProductLogic logic = new ProductLogic();

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Press 2 to view catfood, Press 3 to view dogleash, Press 4 to view products in stock and type 'exit' to quit");
            string userInput = Console.ReadLine() ?? "exit"; // " ?? and exit- is there so when the user leaves this feild empty


            while (userInput.ToLower() != "exit") // this means the user put any of the first top three options
            {
                if (userInput == "1")
                {
                    Console.WriteLine("Enter the product type (1 for Cat Food, 2 for Dog Leash):");
                    string? productTypeInput = Console.ReadLine();
                    if (productTypeInput == "1")
                    {
                   

                        Console.WriteLine("Enter the name of the product");
                        mycatfood.Name = Console.ReadLine() ?? "Empty";


                        Console.WriteLine("Enter the quantity");
                        mycatfood.Quantity = int.Parse(Console.ReadLine());


                        Console.WriteLine("Enter the description");
                        mycatfood.Description = Console.ReadLine() ?? "Empty";


                        Console.WriteLine("Enter the weight in pounds");
                        mycatfood.WeightinPounds = double.Parse(Console.ReadLine());


                        Console.WriteLine("Is this Kitten food? yes or no");
                        string userinput = Console.ReadLine() ?? "Empty";

                        if (userinput.ToLower() == "yes")

                        {
                            mycatfood.KittenFood = true;
                        }

                        else

                        {
                            mycatfood.KittenFood = false;
                        }
                        logic.AddProduct(mycatfood);
                    }
                    else if (productTypeInput == "2")
                    {
                        DogLeash mygodleashisblue = new DogLeash();

                        Console.WriteLine("Enter the name of the produc:?");
                        mygodleashisblue.Name = Console.ReadLine() ?? "Empty";

                        Console.WriteLine("Enter the Price:");
                        mygodleashisblue.Price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the quantity:");
                        mygodleashisblue.Quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the material:");
                        mygodleashisblue.Material = Console.ReadLine() ?? "Empty";

                        Console.WriteLine("Enter the size in LengthInches:");
                        mygodleashisblue.LengthInches = int.Parse(Console.ReadLine());

                       
                        Console.WriteLine(String.Format("Name: {0}\nPrice: {1}\nQuantity:  {2}\nDescription: {3}\nMaterial: {4}\nLengthInches: {5}", mydogleashisblue.Name, mydogleashisblue.Price, mydogleashisblue.Quantity, mydogleashisblue.Description, mydogleashisblue.Material, mydogleashisblue.LengthInches));
                        logic.AddProduct(mydogleashisblue);

                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
                else if (userInput == "2") // this is to view the product to find the product input the user has enter

                {
                    Console.WriteLine("Enter the catfood name:");
                    string catFood = Console.ReadLine();

                    CatFood catfood = logic.GetCatFoodhByName(catFood);
                 

                    if (catFood != null)
                    {
                       
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

                    DogLeash dogLeash = logic.GetDogLeashByName(dogleash);

                    if (dogLeash != null)
                    {

                        Console.WriteLine(JsonSerializer.Serialize(dogleash));
                    }
                    else
                    {
                        Console.WriteLine("DogLeash notfound!");
                    }
                }
                else if (userInput == "4")
                {

                    var instockproduct = logic.GetOnlyInStockProducts();

                    foreach (var items in instockproduct)
                    {
                        Console.WriteLine(items);
                    }
                }

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Press 2 to view catfood, Press 3 to view dogleash, Press 4 to view products in stock and type 'exit' to quit");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();

            }
        }
    }
}



    

        
    
    

















