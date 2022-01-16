namespace mvcUsingShoe_store.Migrations
{
    using mvcUsingShoe_store.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<mvcUsingShoe_store.Models.ShoesStoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
       
        protected override void Seed(mvcUsingShoe_store.Models.ShoesStoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
