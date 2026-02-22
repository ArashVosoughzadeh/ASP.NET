using ItShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ItShop.Data
{
    public class ITShopContext : DbContext
    {
        public ITShopContext(DbContextOptions<ITShopContext> options) : base(options)
        {

        }

        //public ITShopContext CreateDbContext(string[] args)
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<ITShopContext>();
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ItShop;Integrated Security=True;"); // Or retrieve from configuration
        //    return new ITShopContext(optionsBuilder.Options);
        //}

        public DbSet<Category> Categories { get; set; }
        public DbSet<CtegoryToProduct> CtegoryToProducts { get; set; }
        public DbSet<Product> products { get; set; }       
        public DbSet<Users> Users { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
  //      {

  //          //modelBuilder.Entity<Product>(
  //          //p =>
  //          //{
  //          //    p.HasKey(w => w.Id);
  //          //    p.OwnsOne<Item>(navigationExpression: w => w.Item);
  //          //    p.HasOne<Item>(navigationExpression: w => w.Item).WithOne(navigationExpression: w => w.product)
  //          //        .HasForeignKey<Item>(w => w.Id);
  //          //});

  //          //modelBuilder.Entity<Item>(
  //          //p =>
  //          //{
  //          //    p.HasKey(w => w.Id);
  //          //    p.Property(w => w.price).HasColumnType("Money");
  //          //});


  //          //#region Seed Data Caregory

  //          //modelBuilder.Entity<Category>().HasData(new Category()
  //          //{
  //          //    Id = 1,
  //          //    Name = "IT group",
  //          //    Description = "IT group3",
  //          //    ExtraDescription = ""
  //          //},
  //          //new Category()
  //          //{
  //          //    Id = 2,
  //          //    Name = "",
  //          //    Description = "گروه لوازم برقی",
  //          //    ExtraDescription = ""
  //          //},
  //          //new Category()
  //          //{
  //          //    Id = 3,
  //          //    Name = "فلش",
  //          //    Description = "ذخیره فایل",
  //          //    ExtraDescription = ""
  //          //},
  //          //new Category()
  //          //{
  //          //    Id = 4,
  //          //    Name = "کیبورد",
  //          //    Description = "لوازم کامپیوتر",
  //          //    ExtraDescription = ""
  //          //},
  //          //new Category()
  //          //{
  //          //    Id = 5,
  //          //    Name = "موس",
  //          //    Description = "لواز کامپیوتر",
  //          //    ExtraDescription = ""
  //          //},
  //          //new Category()
  //          //{
  //          //    Id = 6,
  //          //    Name = "کیس",
  //          //    Description = "اوازم کامپیوتر",
  //          //    ExtraDescription = ""
  //          //},
  //          //new Category()
  //          //{
  //          //    Id = 7,
  //          //    Name = "هارد",
  //          //    Description = "انواع هارد ",
  //          //    ExtraDescription = ""
  //          //},
  //          //new Category()
  //          //{
  //          //     Id =8,
  //          //     Name = "کامپیوتر",
  //          //     Description = "انواع هارد ",
  //          //     ExtraDescription = ""
  //          // },
  //          // new Category()
  //          //{
  //          //     Id =9,
  //          //     Name = "کامپیوتر",
  //          //     Description = "انواع کامپیوتر ",
  //          //     ExtraDescription = ""
  //          // },
  //          //new Category()
  //          //{
  //          //     Id =10,
  //          //     Name = "گوشی",
  //          //     Description = "انواع موبایل ",
  //          //     ExtraDescription = ""
  //          // },
  //          //new Category()
  //          //{
  //          //     Id =11,
  //          //     Name = "هدفون",
  //          //     Description = "انواع هدفون ",
  //          //     ExtraDescription = ""
  //          // },
  //          //new Category()
  //          //{
  //          //     Id =12,
  //          //     Name = "تبلت",
  //          //     Description = "انواع تبلت ",
  //          //     ExtraDescription = ""
  //          // },
  //          //new Category()
  //          //{
  //          //    Id = 13,
  //          //    Name = "لپتاپ",
  //          //    Description = "انواع لپتاپ",
  //          //    ExtraDescription = ""
  //          //}
  //          //);

  //          //modelBuilder.Entity<Item>().HasData(
  //          //    new Item()
  //          //    {
  //          //        Id = 1,
  //          //        price = 850.0M,
  //          //        QuantityInStock = 5
  //          //    },
  //          //new Item()
  //          //{
  //          //    Id = 2,
  //          //    price = 8040.0M,
  //          //    QuantityInStock = 8
  //          //},
  //          // new Item()
  //          // {
  //          //     Id = 3,
  //          //     price = 905.0M,
  //          //     QuantityInStock = 3
  //          // });
  //          //modelBuilder.Entity<Product>().HasData(new Product()
  //          //{
  //          //    Id = 2,
  //          //    ItemId = 1,
  //          //    Name = "اموزش پایتون",
  //          //    Description = "اموزش مقدماتی پایتون "
  //          //});

  //          //modelBuilder.Entity<CtegoryToProduct>().HasData(
  //          //    new CtegoryToProduct() { Id=1, CategoryId = 1, ProductId = 2, }
  //          //    );

  //          //#endregion

  //          //base.OnModelCreating(modelBuilder);
  //      }
    }
}
