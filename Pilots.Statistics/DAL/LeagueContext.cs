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
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<MatchStatistics> MatchStatistics { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Rounds
            modelBuilder.Entity<Rounds>().HasData(
                new Rounds() { RoundId = 1, Label = "1" },
                new Rounds() { RoundId = 2, Label = "2" },
                new Rounds() { RoundId = 3, Label = "3" },
                new Rounds() { RoundId = 4, Label = "4" },
                new Rounds() { RoundId = 5, Label = "5" },
                new Rounds() { RoundId = 6, Label = "6" },
                new Rounds() { RoundId = 7, Label = "7" },
                new Rounds() { RoundId = 8, Label = "8" },
                new Rounds() { RoundId = 9, Label = "9" },
                new Rounds() { RoundId = 10, Label = "10" },
                new Rounds() { RoundId = 11, Label = "Semi Final" },
                new Rounds() { RoundId = 12, Label = "Final" },
                new Rounds() { RoundId = 13, Label = "Pre-Season" },
                new Rounds() { RoundId = 14, Label = "Friendly" });

            // Seed Competition
            modelBuilder.Entity<Competition>().HasData(
                new Competition() { CompetitionId = 1, StartDate = DateTimeOffset.Parse("20/03/2019") });

            // Seed Seasons
            modelBuilder.Entity<Season>().HasData(
                new Season() { SeasonId = 1, Name = "Autumn 2019", Division = 2, CompetitionId = 1 });

            // Seed Teams
            modelBuilder.Entity<Team>().HasData(
                new Team() { TeamId = 1, Colour = "#fce4ec", Name = "Pilots" });

            // Seed Pilots Players
            modelBuilder.Entity<Player>().HasData(
                new Player() { PlayerId = 1, JerseyNumber = 21, Name = "Hussein Debel", TeamId = 1 },
                new Player() { PlayerId = 2, JerseyNumber = 4, Name = "Alvin Soh", TeamId = 1 },
                new Player() { PlayerId = 3, JerseyNumber = 2, Name = "Roy Aranda", TeamId = 1 },
                new Player() { PlayerId = 4, JerseyNumber = 12, Name = "Tavonga Nyoka", TeamId = 1 },
                new Player() { PlayerId = 5, JerseyNumber = 3, Name = "Khatami Chau", TeamId = 1 },
                new Player() { PlayerId = 6, JerseyNumber = 0, Name = "Usman Haidar", TeamId = 1 },
                new Player() { PlayerId = 7, JerseyNumber = 99, Name = "Jeremy Soh", TeamId = 1 });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=league.db");
        }
    }
}
