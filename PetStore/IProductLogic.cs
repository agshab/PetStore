using System;
namespace PetStore
{

    public interface IProductLogic
    {

        public void AddProduct(Product GoldProduct);

        public List<Product> GetAllProducts();

        public DogLeash? GetDogLeashByName(string name);

        public CatFood? GetCatFoodhByName(string name);

        public List<Product> GetOnlyInStockProducts();

        public decimal GetTotalPriceOfInventory(List<Product> instockonly);



    }
        
}

