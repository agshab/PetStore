using System;
using PetStore;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


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

