using System;
namespace PetStore
{
	public class ProductLogic : IProductLogic
	{

        private List<Product> _products;
        private Dictionary<string, DogLeash> _dictDog;
        private Dictionary<string, CatFood> _dictCat;



        public ProductLogic() // This is the constructor
        {
            _products = new List<Product>
            {new Product { Name = "dog", Description = "animal", Price = 5.0M, Quantity = 1},
            new Product { Name = "cat", Description = "animal", Price = 10.0M, Quantity = 1},
            new Product { Name = "sheep", Description = "animal", Price = 5.0M, Quantity = 2},
            new Product { Name = "horse", Description = "animal", Price = 6.0M, Quantity = 0},
            };

            // We are defining this by setting to something
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



        // petstore 3

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
        }


        // petstore 4

        public List<string> GetOnlyInStockProducts() // once the method is created in the iproduclogic interfeace
        // this needs to be implemeted in the productlogic class
        {
            // throw new NotImplementedException(); (used as filler until we put the method we want to put in here)
            return _products.Where(x => x.Quantity > 0).Select(x => x.Name).ToList();
        }




    }
}

