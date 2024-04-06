using Proyecto_.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Proyecto_.Database
{
    public class proyecto : DbContext
    {
        public proyecto():base("name=Proyecto")
        {
            
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public DbSet<Categoría> Categoria { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<CondicionPag> CondicionPag { get; set; }
    }
}