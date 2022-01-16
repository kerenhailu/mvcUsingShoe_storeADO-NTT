namespace mvcUsingShoe_store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewTableOutShoes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OutShoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        HasDue = c.Boolean(nullable: false),
                        HasInStock = c.Boolean(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OutShoes");
        }
    }
}
