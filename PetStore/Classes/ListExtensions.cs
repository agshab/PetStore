
    
namespace PetStore.Classes
{
    internal static class ListExtensions
    {

        public static IList<T> InStock<T>(this IList<T> list) where T : Product
        {
            return list.Where(x => x.Quantity > 0).ToList();
        }


        public static decimal Sum(this IList<Product> instockproducts)
        {
            return instockproducts.Sum(x => x.Price * x.Quantity);
        }
    }
}

