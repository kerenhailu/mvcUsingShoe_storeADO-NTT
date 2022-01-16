using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace mvcUsingShoe_store.Models
{
    public partial class ShoesStoreDbContext : DbContext
    {
        public ShoesStoreDbContext()
            : base("name=ShoesStoreDbContext")
        {
        }
        public virtual DbSet<OutShoes> OutShoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
