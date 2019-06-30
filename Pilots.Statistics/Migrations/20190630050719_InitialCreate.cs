using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pilots.Statistics.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competition",
                columns: table => new
                {
                    CompetitionID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartDate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competition", x => x.CompetitionID);
                });

            migrationBuilder.CreateTable(
                name: "Rounds",
                columns: table => new
                {
                    RoundID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rounds", x => x.RoundID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Colour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "Season",
                columns: table => new
                {
                    SeasonID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Division = table.Column<int>(nullable: false),
                    CompetitionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.SeasonID);
                    table.ForeignKey(
                        name: "FK_Season_Competition_CompetitionID",
                        column: x => x.CompetitionID,
                        principalTable: "Competition",
                        principalColumn: "CompetitionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTimeOffset>(nullable: false),
                    RoundID = table.Column<int>(nullable: true),
                    TeamID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchID);
                    table.ForeignKey(
                        name: "FK_Matches_Rounds_RoundID",
                        column: x => x.RoundID,
                        principalTable: "Rounds",
                        principalColumn: "RoundID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    JerseyNumber = table.Column<int>(nullable: false),
                    TeamID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerID);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Competition",
                columns: new[] { "CompetitionID", "StartDate" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 1, "1" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 2, "2" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 3, "3" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 4, "4" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 5, "5" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 6, "6" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 7, "7" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 8, "8" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 9, "9" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 10, "10" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 11, "Semi-Final" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 12, "Final" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 13, "Pre-Season" });

            migrationBuilder.InsertData(
                table: "Rounds",
                columns: new[] { "RoundID", "Label" },
                values: new object[] { 14, "Friendly" });

            migrationBuilder.InsertData(
                table: "Season",
                columns: new[] { "SeasonID", "CompetitionID", "Division", "Name" },
                values: new object[] { 1, 1, 2, "Autumn 2019" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_RoundID",
                table: "Matches",
                column: "RoundID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TeamID",
                table: "Matches",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamID",
                table: "Players",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Season_CompetitionID",
                table: "Season",
                column: "CompetitionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Season");

            migrationBuilder.DropTable(
                name: "Rounds");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Competition");
        }
    }
}
