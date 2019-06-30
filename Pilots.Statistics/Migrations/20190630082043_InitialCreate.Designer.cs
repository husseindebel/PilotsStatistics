﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pilots.Statistics.DAL;

namespace Pilots.Statistics.Migrations
{
    [DbContext(typeof(LeagueContext))]
    [Migration("20190630082043_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Pilots.Statistics.Models.Competition", b =>
                {
                    b.Property<int>("CompetitionId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("StartDate");

                    b.HasKey("CompetitionId");

                    b.ToTable("Competitions");

                    b.HasData(
                        new
                        {
                            CompetitionId = 1,
                            StartDate = new DateTimeOffset(new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("Pilots.Statistics.Models.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Date");

                    b.Property<int>("MatchStatisticId");

                    b.Property<int>("RoundId");

                    b.Property<int>("SeasonId");

                    b.Property<int?>("TeamId");

                    b.HasKey("MatchId");

                    b.HasIndex("RoundId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("TeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Pilots.Statistics.Models.MatchStatistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AwayTeamScore");

                    b.Property<int>("HomeTeamScore");

                    b.Property<int>("MatchId");

                    b.HasKey("Id");

                    b.HasIndex("MatchId")
                        .IsUnique();

                    b.ToTable("MatchStatistics");
                });

            modelBuilder.Entity("Pilots.Statistics.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("JerseyNumber");

                    b.Property<string>("Name");

                    b.Property<int>("TeamId");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            JerseyNumber = 21,
                            Name = "Hussein Debel",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 2,
                            JerseyNumber = 4,
                            Name = "Alvin Soh",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 3,
                            JerseyNumber = 2,
                            Name = "Roy Aranda",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 4,
                            JerseyNumber = 12,
                            Name = "Tavonga Nyoka",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 5,
                            JerseyNumber = 3,
                            Name = "Khatami Chau",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 6,
                            JerseyNumber = 0,
                            Name = "Usman Haidar",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 7,
                            JerseyNumber = 99,
                            Name = "Jeremy Soh",
                            TeamId = 1
                        });
                });

            modelBuilder.Entity("Pilots.Statistics.Models.PlayerStatistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Assists");

                    b.Property<int>("Blocks");

                    b.Property<int>("FieldGoalsAttempted");

                    b.Property<int>("FieldGoalsMade");

                    b.Property<int>("FoulsDrawn");

                    b.Property<int>("FoulsGiven");

                    b.Property<int>("FreeThrowsAttempted");

                    b.Property<int>("FreeThrowsMade");

                    b.Property<int>("MatchId");

                    b.Property<int>("PlayerId");

                    b.Property<int>("Rebounds");

                    b.Property<int>("Steals");

                    b.Property<int>("ThreePointsAttempted");

                    b.Property<int>("ThreePointsMade");

                    b.Property<int>("Turnovers");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerStatistics");
                });

            modelBuilder.Entity("Pilots.Statistics.Models.Rounds", b =>
                {
                    b.Property<int>("RoundId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("RoundId");

                    b.ToTable("Rounds");

                    b.HasData(
                        new
                        {
                            RoundId = 1,
                            Label = "1"
                        },
                        new
                        {
                            RoundId = 2,
                            Label = "2"
                        },
                        new
                        {
                            RoundId = 3,
                            Label = "3"
                        },
                        new
                        {
                            RoundId = 4,
                            Label = "4"
                        },
                        new
                        {
                            RoundId = 5,
                            Label = "5"
                        },
                        new
                        {
                            RoundId = 6,
                            Label = "6"
                        },
                        new
                        {
                            RoundId = 7,
                            Label = "7"
                        },
                        new
                        {
                            RoundId = 8,
                            Label = "8"
                        },
                        new
                        {
                            RoundId = 9,
                            Label = "9"
                        },
                        new
                        {
                            RoundId = 10,
                            Label = "10"
                        },
                        new
                        {
                            RoundId = 11,
                            Label = "Semi Final"
                        },
                        new
                        {
                            RoundId = 12,
                            Label = "Final"
                        },
                        new
                        {
                            RoundId = 13,
                            Label = "Pre-Season"
                        },
                        new
                        {
                            RoundId = 14,
                            Label = "Friendly"
                        });
                });

            modelBuilder.Entity("Pilots.Statistics.Models.Season", b =>
                {
                    b.Property<int>("SeasonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompetitionId");

                    b.Property<int>("Division");

                    b.Property<string>("Name");

                    b.HasKey("SeasonId");

                    b.HasIndex("CompetitionId");

                    b.ToTable("Seasons");

                    b.HasData(
                        new
                        {
                            SeasonId = 1,
                            CompetitionId = 1,
                            Division = 2,
                            Name = "Autumn 2019"
                        });
                });

            modelBuilder.Entity("Pilots.Statistics.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Colour");

                    b.Property<string>("Name");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            Colour = "#fce4ec",
                            Name = "Pilots"
                        });
                });

            modelBuilder.Entity("Pilots.Statistics.Models.Match", b =>
                {
                    b.HasOne("Pilots.Statistics.Models.Rounds", "Round")
                        .WithMany("Matches")
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pilots.Statistics.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pilots.Statistics.Models.Team")
                        .WithMany("Matches")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Pilots.Statistics.Models.MatchStatistics", b =>
                {
                    b.HasOne("Pilots.Statistics.Models.Match", "Match")
                        .WithOne("MatchStatistics")
                        .HasForeignKey("Pilots.Statistics.Models.MatchStatistics", "MatchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pilots.Statistics.Models.Player", b =>
                {
                    b.HasOne("Pilots.Statistics.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pilots.Statistics.Models.PlayerStatistic", b =>
                {
                    b.HasOne("Pilots.Statistics.Models.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pilots.Statistics.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pilots.Statistics.Models.Season", b =>
                {
                    b.HasOne("Pilots.Statistics.Models.Competition", "Competition")
                        .WithMany("Seasons")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
