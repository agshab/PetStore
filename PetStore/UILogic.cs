
using System.Text.Json;

namespace PetStore
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

            Console.WriteLine(" Press 1 to add a product \n Press 2 to view a CatFoodd \n Press 3 to view a DogLeash \n Press 4 to view current products in stock \n Press 5 to get total price of inventory \n Type 'exit' to quit \n");
            string userInput = Console.ReadLine() ?? "exit"; // " ?? and exit- is there so when the user leaves this feild empty


            while (userInput.ToLower() != "exit") // this means the user put any of the first top three options
            {
                if (userInput == "1")
                {
                    Console.WriteLine("Enter the product type (1 for Cat Food, 2 for Dog Leash):");
                    string? productTypeInput = Console.ReadLine();

                    if (productTypeInput == "1")
                    {   
                        bool IsValidInput = false;
                        Console.WriteLine("Enter the cat food name:");
                        mycatfood.Name = Console.ReadLine();

                        Console.WriteLine("Enter the cat food price:");
                        while (!IsValidInput)
                        {
                            if (decimal.TryParse(Console.ReadLine(), out decimal quantity))
                            {
                                mycatfood.Price = quantity;
                                IsValidInput = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid price input. Please enter a valid decimal number.");
                            }
                        }                     

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
                       

                        Console.WriteLine("Enter the name of the DogLeash name:?");
                        mydogleashisblue.Name = Console.ReadLine() ?? "Empty";

                        Console.WriteLine("Enter the Price:");
                        mydogleashisblue.Price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the quantity:");
                        mydogleashisblue.Quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the material:");
                        mydogleashisblue.Material = Console.ReadLine() ?? "Empty";

                        Console.WriteLine("Enter the size in LengthInches:");
                        mydogleashisblue.LenghtInches = int.Parse(Console.ReadLine());
                     

                        Console.WriteLine(String.Format("Name: {0}\nPrice: {1}\nQuantity:  {2}\nDescription: {3}\nMaterial: {4}\nLengthInches: {5}", mydogleashisblue.Name, mydogleashisblue.Price, mydogleashisblue.Quantity, mydogleashisblue.Description, mydogleashisblue.Material, mydogleashisblue.LenghtInches));
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
                    CatFood catfood = logic.GetCatFoodByName(catFood);

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
                    Dogleash dogLeash = logic.GetDogLeashByName(dogleash);

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
                    var TotalPrice = logic.GetTotalPriceOfInventory(logic.GetOnlyInStockProducts());

                    Console.WriteLine($"Total price of the inventory is {TotalPrice}");
                }

                Console.WriteLine(" Press 1 to add a product \n Press 2 to view a CatFoodd \n Press 3 to view a DogLeash \n Press 4 to view current products in stock \n Press 5 to get total price of inventory \n Type 'exit' to quit \n");
                userInput = Console.ReadLine() ?? "exit";

            }
        }

    }
    
}

