using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DogAndPeoples.Models
{
    public class Context : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<People> Peoples { get; set; }

        public Context() : base("default")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Dog>().ToTable("Dogs");
            modelBuilder.Entity<Dog>()
                       .HasRequired<People>(p => p.People)
                       .WithMany(d => d.Dogs)
                       .HasForeignKey<int>(d => d.PeopleId);

            modelBuilder.Entity<People>().ToTable("Peoples");


            base.OnModelCreating(modelBuilder);
        }


    }
}