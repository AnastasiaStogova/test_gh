namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "IsDeleted", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "IsDeleted");
        }
    }
}
