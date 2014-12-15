namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        name = c.String(),
                        count = c.Int(nullable: false),
                        price = c.Double(nullable: false),
                        ItemStorageId = c.Int(),
                        place = c.String(),
                        ItemFullId = c.Int(),
                        type = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
