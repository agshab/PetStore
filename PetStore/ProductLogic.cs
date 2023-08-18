
namespace PetStore
{
    internal class ProductLogic : IProductLogic
    {

        private List<Product> _products;

        public ProductLogic() // This is the constructor
        {
            _products = new List<Product>
            {
                new Product { Name = "First Product", Description = "First Product", Price = 5.5M, Quantity = 10},
                new Product { Name = "Second Product", Description = "Second Product", Price = 10.0M, Quantity = 4},
                new Product { Name = "Third Product", Description = "Third Product", Price = 20.0M, Quantity = 2},
                new Product { Name = "Fourth Product", Description = "Fourth Product", Price = 6.0M, Quantity = 0},
            };
        }

        /// <summary>
        /// Adds Product of Type Product(CatFood or DogLeash)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="product"></param>
        public void AddProduct<T>(T product) where T : Product
        {
            _products.Add(product);
            Console.WriteLine("Product added successfully!");
        }

        /// <summary>
        /// Accesses the Product List
        /// </summary>
        /// <returns>this.List</returns>
        public IList<Product> GetAllProducts()
        {
            return this._products;
        }

        /// <summary>
        /// Gets a dog leash by name. [Deprecated: Use GetItemByName instead.]
        /// </summary>
        /// <param name="name">The name of the dog leash.</param>
        /// <returns>The dog leash with the specified name, or null if not found.</returns>
        [Obsolete("This method is deprecated. Use GetItemByName instead.")]

        public Dogleash? GetDogLeashByName(string name)
        {
            //try
            //{
            //    return this._dogLeashes.ContainsKey(name) ? _dogLeashes[name] : null;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error ocurred while trying to retreive a dog leash: {ex.Message}");
            //    return null;
            //}
            throw new NotImplementedException();

        }

        /// <summary>
        /// Gets a dog leash by name. [Deprecated: Use GetItemByName instead.]
        /// </summary>
        /// <param name="name">The name of the cat food.</param>
        /// <returns>The dog leash with the specified name, or null if not found.</returns>
        [Obsolete("This method is deprecated. Use GetItemByName instead.")]

        public CatFood? GetCatFoodByName(string name)
        {
            //try
            //{
            //    return this._catFoods.ContainsKey(name) ? _catFoods[name] : null;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error ocurred while trying to retreive a dog leash: {ex.Message}");
            //    return null;
            //}
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets all names of type Product from the Product List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns>List of class Product</returns>
        public T? GetItemByName<T>(string name) where T : Product
        {
            try
            {
                return _products.OfType<T>().FirstOrDefault(x => x.Name == name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while trying to retrieve an item: {ex.Message}");

            }
            return default(T);
        }

        /// <summary>
        /// Accesses the static function ListExtentions.InStock
        /// </summary>
        /// <returns>IList of class Products</returns>
        public IList<Product> GetOnlyInStockProducts()
        {
            return ListExtensions.InStock(_products);
        }

        /// <summary>
        /// Gets a List of class Product and does calculation.
        /// </summary>
        /// <param name="instockonly"></param>
        /// <returns>decimal</returns>
        public decimal GetTotalPriceOfInventory(IList<Product> instockonly)
        {
            decimal result = 0;
            foreach (Product i in instockonly)
            {
                result += i.Price * i.Quantity;
            }
            return result;
        }
    }
}