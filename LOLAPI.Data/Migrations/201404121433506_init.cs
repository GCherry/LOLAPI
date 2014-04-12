namespace LOLAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Champion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChampionName = c.String(nullable: false, maxLength: 500),
                        ChampionDesc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Champion");
        }
    }
}
