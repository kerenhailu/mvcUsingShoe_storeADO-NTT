using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcUsingShoe_store.Models
{
    public class ShoesStore
    {
        public ShoesStore(int id, string name, string model, int size, int price)
        {
            Id = id;
            Name = name;
            Model = model;
            Size = size;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
    }
}


