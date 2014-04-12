namespace LOLAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChampionActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Champion", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Champion", "Active");
        }
    }
}
