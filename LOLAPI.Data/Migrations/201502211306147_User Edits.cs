namespace LOLAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserEdits : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAccount", "Champ_Id", c => c.Int());
            CreateIndex("dbo.UserAccount", "Champ_Id");
            AddForeignKey("dbo.UserAccount", "Champ_Id", "dbo.Champion", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAccount", "Champ_Id", "dbo.Champion");
            DropIndex("dbo.UserAccount", new[] { "Champ_Id" });
            DropColumn("dbo.UserAccount", "Champ_Id");
        }
    }
}
