namespace LOLAPI.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LOLAPI.Shared.Entities;

    public sealed class Configuration : DbMigrationsConfiguration<LOLAPI.Data.LoLDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LOLAPI.Data.LoLDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Champions.AddOrUpdate(
            //    c => c.ChampionName,
            //    new Champion()
            //    {
            //        ChampionName = "Champ Name",
            //        ChampionDesc = "Champ Lore"
            //    });
        }
    }
}
