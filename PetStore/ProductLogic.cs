using System;
namespace PetStore
{
	public class ProductLogic
	{

        private List<Product> _products;
        private Dictionary<string, DogLeash> _dictDog;
        private Dictionary<string, CatFood> _dictCat;



        public ProductLogic() // This is the constructor
        {
            _products = new List<Product>(); // We are defining this by setting to something
            _dictDog = new Dictionary<string, DogLeash>();
            _dictCat = new Dictionary<string, CatFood>();
        }


        public void AddProduct(Product GoldProduct)
        {
            if (GoldProduct is DogLeash)
            {
                _dictDog.Add(((DogLeash)GoldProduct).Name, GoldProduct as DogLeash);
            }
            
            else if (GoldProduct is CatFood)
            {
               
                _dictCat.Add(GoldProduct.Name, GoldProduct as CatFood);
            }

            _products.Add(GoldProduct);
        }

        public List<Product> GetAllProducts() // this is a definition of the declatraion of a fucntion
                                              // and everything between {} is the declation of the that function
        {
            return _products;
        }




        public DogLeash? GetDogLeashByName(string name) // this is a definition of the declatraion of a fucntion
                                                        // and everything between {} is the declation of the that function
        {         
            try
            {
                return _dictDog[name];
            }

            catch (Exception ex)
            {
                Console.WriteLine($"There was an error {ex}");
                return null;
            }

        }



        public CatFood? GetCatFoodhByName(string name)
        {
            try
            {
                return _dictCat[name];
            }

            catch (Exception ex)
            {
                Console.WriteLine($"There was an error {ex}");
                return null;
            }
            Console.WriteLine("hello!");

        }


    }
}

