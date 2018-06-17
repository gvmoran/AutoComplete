namespace AutoComplete.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CountryModel : DbContext
    {
        public CountryModel()
            : base("name=CountryModel")
        {
        }

        public virtual DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);
        }
    }
}
