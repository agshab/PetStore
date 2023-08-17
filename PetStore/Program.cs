using System;
using PetStore;
using System.Text.Json;



namespace PetStore
{


    internal class program // Create the main function, the entry point of the project
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit") // this means the user put any of the first top three options
            {
               
                Console.WriteLine("Press 2 to view a catfood, Press 2 to view a dogleash and type 'exit' to quit");             
                string CatorDog = Console.ReadLine() ?? "exit";

                if (CatorDog.ToString() == "1")
                {
                  
                    CatFood mycatfoodloveisland = new CatFood();
                    //CatFood mycatfoodloveisland;(Could be said either way)


                    Console.WriteLine("What is the name of the product?");
                    mycatfoodloveisland.Name = Console.ReadLine() ?? "Empty";


                    Console.WriteLine("What is the quantity?");
                    mycatfoodloveisland.Quantity = int.Parse(Console.ReadLine());


                    Console.WriteLine("What is the description?");
                    mycatfoodloveisland.Description = Console.ReadLine() ?? "Empty";


                    Console.WriteLine("What is the weight in pounds?");
                    mycatfoodloveisland.WeightinPounds = double.Parse(Console.ReadLine());


                    Console.WriteLine("Is this Kitten food? yes or no");
                    string userinput = Console.ReadLine() ?? "Empty";

                    if (userinput.ToLower() == "yes")

                    {
                        mycatfoodloveisland.KittenFood = true;
                    }

                    else

                    {
                        mycatfoodloveisland.KittenFood = false;
                    }

                    Console.WriteLine(JsonSerializer.Serialize(mycatfoodloveisland));
                    Console.WriteLine("Type 'exit' to quit");


                userInput = Console.ReadLine();
                }

                else if (CatorDog.ToString() == "2") // this is to view the product to find the product input that the user has enter
                {
                    DogLeash mydogleashisblue = new DogLeash();
                    //mydogleashisblue = new DogLeash(); (Could be said either way)


                    Console.WriteLine("Please enter the name of the produc:?");
                    mydogleashisblue.Name = Console.ReadLine() ?? "Empty";

                    Console.WriteLine("Please enter the Price:");
                    mydogleashisblue.Price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the quantity:");
                    mydogleashisblue.Quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the material:");
                    mydogleashisblue.Material = Console.ReadLine() ?? "Empty";

                    Console.WriteLine("Please enter the size in LengthInches:");
                    mydogleashisblue.LengthInches = int.Parse(Console.ReadLine());


                    Console.WriteLine(JsonSerializer.Serialize(mydogleashisblue));
                    Console.WriteLine("Press 2 to view a catfood, Press 2 to view a dogleash and type 'exit' to quit");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();

                }

            }
        }
    }
}
    

        
    
    

















