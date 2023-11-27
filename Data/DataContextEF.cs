using HelloWorld.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

namespace HelloWorld.Data

{
    public class DataContextEF : DbContext
    {
        
            private IConfiguration _config;
            private string _connectionString;
            public DataContextEF(IConfiguration config)
            {
                _config = config;
            }
        public DbSet<Computer>? Computer {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {


            if(!options.IsConfigured)
            {
                options.UseSqlServer(_config.GetConnectionString("DefaultConnection"),
                options => options.EnableRetryOnFailure());

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TutorialAppSchema");

            modelBuilder.Entity<Computer>()
            // .HasNoKey();
            .HasKey(c => c.ComputerId);
                //.ToTable("TableName", "SchemaName");
                //.ToTable("Computer", "TutorialAppSchema");


        }

    }
}