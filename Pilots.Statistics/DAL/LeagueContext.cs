using System;
using Microsoft.EntityFrameworkCore;
using Pilots.Statistics.Models;

namespace Pilots.Statistics.DAL
{
    public class LeagueContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Rounds> Rounds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Rounds
            modelBuilder.Entity<Rounds>().HasData(
                new Rounds() { RoundID = 1, Label = "1" },
                new Rounds() { RoundID = 2, Label = "2" },
                new Rounds() { RoundID = 3, Label = "3" },
                new Rounds() { RoundID = 4, Label = "4" },
                new Rounds() { RoundID = 5, Label = "5" },
                new Rounds() { RoundID = 6, Label = "6" },
                new Rounds() { RoundID = 7, Label = "7" },
                new Rounds() { RoundID = 8, Label = "8" },
                new Rounds() { RoundID = 9, Label = "9" },
                new Rounds() { RoundID = 10, Label = "10" },
                new Rounds() { RoundID = 11, Label = "Semi-Final" },
                new Rounds() { RoundID = 12, Label = "Final" },
                new Rounds() { RoundID = 13, Label = "Pre-Season" },
                new Rounds() { RoundID = 14, Label = "Friendly" });

            // Seed Competition
            modelBuilder.Entity<Competition>().HasData(
                new Competition() { CompetitionID = 1, StartDate = DateTimeOffset.Parse("20/03/2019") });

            // Seed Seasons
            modelBuilder.Entity<Season>().HasData(
                new Season() { SeasonID = 1, Name = "Autumn 2019", Division = 2, CompetitionID = 1 });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=league.db");
        }
    }
}
