using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace DataAccess.Data
{
    public class RemovalistContext : DbContext
    {
        public RemovalistContext(DbContextOptions<RemovalistContext> options) : base(options)
        {
        }


        public DbSet<JobDetails> JobDetailses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Table Mapping
            modelBuilder.Entity<JobDetails>().ToTable("JobDetails");

            //Set Primary key
            modelBuilder.Entity<JobDetails>().HasKey(jobDetails => jobDetails.JobDetailsId);

            //Relationship Setup
        }
    }
}