using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using LOLAPI.Shared.Entities;
using LOLAPI.Data.ModelMappings;



namespace LOLAPI.Data
{
    public class LoLDBContext : DbContext
    {
        public static string ConnectionStringName { get; set; }

        static LoLDBContext()
        {
            ConnectionStringName = "LoLConnection";
        }

        public LoLDBContext() : base(ConnectionStringName) { }

        public IDbSet<Champion> Champions { get; set; }
        public IDbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ChampionModelMap());
            modelBuilder.Configurations.Add(new UserAccountModelMap());
        }
    }
}
