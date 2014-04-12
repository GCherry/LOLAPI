using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LOLAPI.Shared.Entities;


namespace LOLAPI.Data.ModelMappings
{
    public class ChampionModelMap : EntityTypeConfiguration<Champion>
    {
        public ChampionModelMap()
        {
            this.Property(i => i.ChampionName).IsRequired().HasMaxLength(500);
            this.Property(i => i.ChampionDesc).IsOptional();
            this.Property(i => i.Active).IsRequired();
        }
    }
}
