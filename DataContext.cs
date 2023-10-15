using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class DataContext : DbContext
{


    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        Cards = Set<Card>();
        TopGames = Set<TopGame>();
    }
    public DbSet<Card> Cards { get; set; }
    public DbSet<TopGame> TopGames { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SeedData(modelBuilder);
    }

    private static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Card>().HasData(
           new Card { Id = 1, ImageUrl = "https://clutchpoints.com/_next/image?url=https%3A%2F%2Fwp.clutchpoints.com%2Fwp-content%2Fuploads%2F2022%2F12%2FTop-10-New-Games-of-Q1-2023.jpg&w=3840&q=75", Title = "Upcoming games", Description = "Discover exciting new games coming soon.", RouterLink = "/upcoming" },
           new Card { Id = 2, ImageUrl = "https://preview.redd.it/top-5-best-selling-games-of-2023-so-far-v0-q4pn027a4t8b1.png?auto=webp&s=4533166299f0bc7d7c2e7dadbe7531866ad91f98", Title = "Top grossing", Description = "Explore the top-grossing games of 2023.", RouterLink = "/top-grossing" },
           new Card { Id = 3, ImageUrl = "https://d1fs8ljxwyzba6.cloudfront.net/assets/article/2022/12/08/2023-video-game-release-calendar-featured-image_feature.jpg", Title = "Recently released", Description = "Check out the latest game releases.", RouterLink = "/recently-released" }
        );
    }
}
