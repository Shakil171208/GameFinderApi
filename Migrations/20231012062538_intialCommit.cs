using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameFinderApi.Migrations
{
    /// <inheritdoc />
    public partial class intialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouterLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopGames", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Description", "ImageUrl", "RouterLink", "Title" },
                values: new object[,]
                {
                    { 1, "Discover exciting new games coming soon.", "https://clutchpoints.com/_next/image?url=https%3A%2F%2Fwp.clutchpoints.com%2Fwp-content%2Fuploads%2F2022%2F12%2FTop-10-New-Games-of-Q1-2023.jpg&w=3840&q=75", "/upcoming", "Upcoming games" },
                    { 2, "Explore the top-grossing games of 2023.", "https://preview.redd.it/top-5-best-selling-games-of-2023-so-far-v0-q4pn027a4t8b1.png?auto=webp&s=4533166299f0bc7d7c2e7dadbe7531866ad91f98", "/top-grossing", "Top grossing" },
                    { 3, "Check out the latest game releases.", "https://d1fs8ljxwyzba6.cloudfront.net/assets/article/2022/12/08/2023-video-game-release-calendar-featured-image_feature.jpg", "/recently-released", "Recently released" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "TopGames");
        }
    }
}
