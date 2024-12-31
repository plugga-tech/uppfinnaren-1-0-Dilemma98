using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace uppfinnaren_1_0_Dilemma98.Models;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        this.Database.EnsureCreated();
    }

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
           new Category { CategoryId = 1, Name = "Köksredskap" },
           new Category { CategoryId = 2, Name = "Leksaker" },
           new Category { CategoryId = 3, Name = "Inredning" },
           new Category { CategoryId = 4, Name = "Stolar" },
           new Category { CategoryId = 5, Name = "Bord" }
       );

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Köksslevar", Price = 200, Description = "Paket med tre slevar i olika storlekar." },
            new Product { ProductId = 2, CategoryId = 1, Name = "Skärbrädor", Price = 200, Description = "Ett kit med tre skärbrädor i olika storlekar." },
            new Product { ProductId = 3, CategoryId = 1, Name = "Skålar", Price = 350, Description = "Ett kit med 5st skålar." },
            new Product { ProductId = 4, CategoryId = 1, Name = "Tallrikar", Price = 250, Description = "Ett kit med 5 st tallrikar." },
            new Product { ProductId = 5, CategoryId = 2, Name = "Familjepussel", Price = 350, Description = "En liten pusseltavla av dig och din familj. Görs på beställning utefter önskemål." },
            new Product { ProductId = 6, CategoryId = 2, Name = "Leksakspaket", Price = 750, Description = "Ett paket med två elefanter, en regnbåge i delar, två fåglar, två kaniner och två träd." },
            new Product { ProductId = 7, CategoryId = 2, Name = "Räknetåg", Price = 550, Description = "Ett räknetåg för den lille att lära sig räkna." },
            new Product { ProductId = 8, CategoryId = 2, Name = "Byggklossar", Price = 250, Description = "Byggklossar för den lilla att bygga med." },
            new Product { ProductId = 9, CategoryId = 3, Name = "Skogsvarelser", Price = 150, Description = "Två söta skogsvarelser." },
            new Product { ProductId = 10, CategoryId = 3, Name = "Vaser", Price = 550, Description = "Vaser i olika former" },
            new Product { ProductId = 11, CategoryId = 3, Name = "Träd", Price = 250, Description = "Ett fint träd för dekoration" },
            new Product { ProductId = 12, CategoryId = 3, Name = "Skål", Price = 550, Description = "En fin skål för dekoration" },
            new Product { ProductId = 13, CategoryId = 4, Name = "Stolar med känsla", Price = 2500, Description = "Ett set om 4st stolar." },
            new Product { ProductId = 14, CategoryId = 4, Name = "Stolar med retro", Price = 2500, Description = "Ett set om 4st stolar." },
            new Product { ProductId = 15, CategoryId = 4, Name = "Stolar med stil", Price = 2500, Description = "Ett set om 4st stolar." },
            new Product { ProductId = 16, CategoryId = 4, Name = "Stolar med mjukt", Price = 2500, Description = "Ett set om 4st stolar." },
            new Product { ProductId = 17, CategoryId = 5, Name = "Kaffebord", Price = 500, Description = "Ett enkelt kaffebord." },
            new Product { ProductId = 18, CategoryId = 5, Name = "Simpla bord", Price = 1000, Description = "Ett simpelt bord." },
            new Product { ProductId = 19, CategoryId = 5, Name = "Runda bord", Price = 500, Description = "Ett runt bord." },
            new Product { ProductId = 20, CategoryId = 5, Name = "Fyrkantiga bord", Price = 1500, Description = "Ett fyrkantigt bord." }
        );
    }
}
