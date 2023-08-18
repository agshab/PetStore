using System;
namespace PetStore
{

    public interface IProductLogic
    {
        public void AddProduct<T>(T GoldProduct) where T : Product;

        /// <summary>
        /// Gets a dog leash by name. [Deprecated: Use GetItemByName instead.]
        /// </summary>
        /// <param name="name">The name of the dog leash.</param>
        /// <returns>The dog leash with the specified name, or null if not found.</returns>
        [Obsolete("This method is deprecated. Use GetItemByName instead.")]
        public DogLeash? GetDogLeashByName(string name);

        /// <summary>
        /// Gets cat food by name. [Deprecated: Use GetItemByName instead.]
        /// </summary>
        /// <param name="name">The name of the cat food.</param>
        /// <returns>The cat food with the specified name, or null if not found.</returns>
        [Obsolete("This method is deprecated. Use GetItemByName instead.")]
        public CatFood? GetCatFoodByName(string name);

        public IList<Product> GetOnlyInStockProducts();
        public decimal GetTotalPriceOfInventory(IList<Product> instockonly);
        public T? GetItemByName<T>(string name) where T : Product;

    }
        
}

