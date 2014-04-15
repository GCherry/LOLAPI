namespace LOLAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAccountEmailColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAccount", "Email", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserAccount", "Email");
        }
    }
}
