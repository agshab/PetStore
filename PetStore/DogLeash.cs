using System;
using PetStore;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace PetStore
{
	public class DogLeash : Product // It's being inherit from the product class
	{

        public int LenghtInches { get; set; } = 0;
        public string? Material { get; set; }

    }
}

