using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcUsingShoe_store.Models
{
    public class OutShoes
    {
        public OutShoes(int id, string name, string gender, bool hasDue, bool hasInStock, int price)
        {
            Id = id;
            Name = name;
            Gender = gender;
            HasDue = hasDue;
            HasInStock = hasInStock;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public bool HasDue { get; set; }
        public bool HasInStock { get; set; }
        public int Price { get; set; }
    }
}