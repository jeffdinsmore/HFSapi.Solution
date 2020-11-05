using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HFSapi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Season = table.Column<int>(nullable: false),
                    Week = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    Team = table.Column<string>(nullable: true),
                    PassYards = table.Column<int>(nullable: false),
                    RecYards = table.Column<int>(nullable: false),
                    RushYards = table.Column<int>(nullable: false),
                    Interceptions = table.Column<int>(nullable: false),
                    Fumbles = table.Column<int>(nullable: false),
                    Receptions = table.Column<int>(nullable: false),
                    PassTDs = table.Column<int>(nullable: false),
                    RushTDs = table.Column<int>(nullable: false),
                    RecTDs = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    YearsPlayed = table.Column<int>(nullable: false),
                    Games = table.Column<int>(nullable: false),
                    AvgPoints = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
