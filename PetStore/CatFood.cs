using System;
using PetStore;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace PetStore
{
	public class CatFood : Product // It's being inherit from the product class
	{

        public double WeightinPounds { get; set; }
        public bool KittenFood { get; set; }
        


        public CatFood()
		{
		}
	}
}

