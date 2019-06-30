using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pilots.Statistics.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    CompetitionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartDate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.CompetitionId);
                });

            migrationBuilder.CreateTable(
                name: "Rounds",
                columns: table => new
                {
                    RoundId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rounds", x => x.RoundId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Colour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    SeasonId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Division = table.Column<int>(nullable: false),
                    CompetitionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.SeasonId);
                    table.ForeignKey(
                        name: "FK_Seasons_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "CompetitionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    JerseyNumber = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTimeOffset>(nullable: false),
                    RoundId = table.Column<int>(nullable: false),
                    MatchStatisticId = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchId);
                    table.ForeignKey(
                        name: "FK_Matches_Rounds_RoundId",
                        column: x => x.RoundId,
                        principalTable: "Rounds",
                        principalColumn: "RoundId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matches_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HomeTeamScore = table.Column<int>(nullable: false),
                    AwayTeamScore = table.Column<int>(nullable: false),
                    MatchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchStatistics_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FieldGoalsAttempted = table.Column<int>(nullable: false),
                    FieldGoalsMade = table.Column<int>(nullable: false),
                    ThreePointsAttempted = table.Column<int>(nullable: false),
                    ThreePointsMade = table.Column<int>(nullable: false),
                    FreeThrowsAttempted = table.Column<int>(nullable: false),
                    FreeThrowsMade = table.Column<int>(nullable: false),
                    Assists = table.Column<int>(nullable: false),
                    Rebounds = table.Column<int>(nullable: false),
                    Steals = table.Column<int>(nullable: false),
                    Blocks = table.Column<int>(nullable: false),
                    Turnovers = table.Column<int>(nullable: false),
                    FoulsGiven = table.Column<int>(nullable: false),
                    FoulsDrawn = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    MatchId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerStatistics_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerStatistics_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "CompetitionId", "StartDate" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 1, "1" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 2, "2" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 3, "3" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 4, "4" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 5, "5" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 6, "6" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 7, "7" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 8, "8" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 9, "9" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 10, "10" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 11, "Semi Final" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 12, "Final" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 13, "Pre-Season" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundId", "Label" },
                values: new object[] { 14, "Friendly" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "Colour", "Name" },
                values: new object[] { 1, "#fce4ec", "Pilots" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "JerseyNumber", "Name", "TeamId" },
                values: new object[] { 1, 21, "Hussein Debel", 1 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "JerseyNumber", "Name", "TeamId" },
                values: new object[] { 2, 4, "Alvin Soh", 1 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "JerseyNumber", "Name", "TeamId" },
                values: new object[] { 3, 2, "Roy Aranda", 1 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "JerseyNumber", "Name", "TeamId" },
                values: new object[] { 4, 12, "Tavonga Nyoka", 1 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "JerseyNumber", "Name", "TeamId" },
                values: new object[] { 5, 3, "Khatami Chau", 1 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "JerseyNumber", "Name", "TeamId" },
                values: new object[] { 6, 0, "Usman Haidar", 1 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "JerseyNumber", "Name", "TeamId" },
                values: new object[] { 7, 99, "Jeremy Soh", 1 });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonId", "CompetitionId", "Division", "Name" },
                values: new object[] { 1, 1, 2, "Autumn 2019" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_RoundId",
                table: "Matches",
                column: "RoundId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_SeasonId",
                table: "Matches",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamId",
                table: "Matches",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchStatistics_MatchId",
                table: "MatchStatistics",
                column: "MatchId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistics_MatchId",
                table: "PlayerStatistics",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistics_PlayerId",
                table: "PlayerStatistics",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_CompetitionId",
                table: "Seasons",
                column: "CompetitionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchStatistics");

            migrationBuilder.DropTable(
                name: "PlayerStatistics");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Rounds");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Competitions");
        }
    }
}
