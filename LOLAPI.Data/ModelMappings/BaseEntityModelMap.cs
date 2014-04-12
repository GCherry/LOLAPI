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
    public class BaseEntityModelMap<T> : EntityTypeConfiguration<T> where T : Entity
    {
         public  BaseEntityModelMap()
         {
             this.HasKey(i => i.Id);
             this.Property(i => i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         }
    }
}
