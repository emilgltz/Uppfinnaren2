using Microsoft.EntityFrameworkCore;

namespace Uppfinnar3n.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
            this.Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Träfigurer" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Tavlor" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Köksredskap" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Möbler" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Tillbehör" });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Bröderna Spik",
                Description = "Brödarparet som snickrar i vått och torrt, täljda för hand",
                Image = "brothers.jpg",
                Price = 200,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product

            {
                ProductId = 2,
                Name = "Trollflickorna",
                Description = "Trollflickorna som bor i Jämtlands djupaste skogar, täljda för hand",
                Image = "trolls.jpg",
                Price = 200,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Detetktiven Lenartsson",
                Description = "Privatdetektiven Carl Lennartsson, alltid på vift och lämnar inga stenar ovända, täljd för hand",
                Image = "detective.jpg",
                Price = 150,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Sjön",
                Description = "Målad en solig morgon vid den kristallklara sjön i Svenstavik",
                Image = "tavla1.jpg",
                Price = 499,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Glimten vid baksidan",
                Description = "Målning av den vackra ån som sträcker sig bakom Leffes baksidan",
                Image = "tavla3.jpg",
                Price = 499,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Betraktelsen",
                Description = "Djupet, dimensionen, skapelsen? Endast ditt sinne sätter gränserna, målad av Leffe",
                Image = "tavla2.jpg",
                Price = 599,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Köksslevar - SET",
                Description = "Handgjorda köksslevar i tre olika storlekar",
                Image = "spoons.jpg",
                Price = 199,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Skärbräda",
                Description = "Robust och rejäl skärbräda som klarar det mesta, ytbehandland med vår egen trälackering",
                Image = "board.jpg",
                Price = 299,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Serveringsbricka",
                Description = "Elegant bricka som passar pefekt till kaffestunden, ytbehandland med vår egen trälackering",
                Image = "tray.jpg",
                Price = 249,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Gungstol",
                Description = "Den klassiska gungstolen som passar i varje hem, delvis handgjord",
                Image = "chair.jpg",
                Price = 1499,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Pall",
                Description = "Stabil och praktisk pall som har fått en stilren grå lackering",
                Image = "stool.jpg",
                Price = 699,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Bokhylla",
                Description = "Vacker bokhylla som är ett måste i varje romanälskares hem",
                Image = "bookshelf.jpg",
                Price = 1299,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 13,
                Name = "Pensel",
                Description = "250mm pensel av den finaste kvaliten.",
                Image = "brush.jpg",
                Price = 149,
                CategoryId = 5
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 14,
                Name = "Leffes trälack",
                Description = "200ml av vår aldeles egna trälack, passar utmärkt till alla sorters träytor",
                Image = "oil.jpg",
                Price = 199,
                CategoryId = 5
            });
            
        }
    }
}
