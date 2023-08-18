using System.Text.Json;

namespace PetStore
{
	public class Product // Parent class
	{

        public string? Name { get; set; }
        public decimal Price { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public string? Description { get; set; }



        public string Serialize()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

