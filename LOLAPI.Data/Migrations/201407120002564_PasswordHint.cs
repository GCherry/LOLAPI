namespace LOLAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PasswordHint : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAccount", "PasswordHint", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserAccount", "PasswordHint");
        }
    }
}
