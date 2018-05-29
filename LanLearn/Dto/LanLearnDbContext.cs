using Dto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dto
{
    public class LanLearnDbContext : DbContext
    {
        public LanLearnDbContext()
        {
        }

        public LanLearnDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EnglishDictionary> EnglishDictionaries { get; set; }
        public DbSet<PartOfSpeech> PartsOfSpeech { get; set; }
        public DbSet<Result> Results { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PartOfSpeech>().ToTable("PartsOfSpeech");
            modelBuilder.Entity<EnglishDictionary>().ToTable("EnglishDictionaries");
            modelBuilder.Entity<Result>().ToTable("Results");
        }
    }
}
