using System;

using Microsoft.EntityFrameworkCore;
namespace MochiSweets.Models
{
  public class MyDbContext : DbContext
  {
    public DbSet<Product> Product { get; set; }
    public DbSet<Taste> Taste { get; set; }
    public DbSet<SaleOff> SaleOff { get; set; }
    public DbSet<Image> Image { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
    public DbSet<PaymentsMethod> PaymentsMethod { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Account> Account { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrdersProduct> OrdersProduct { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySql("server=127.0.0.1;uid=root;pwd=123456789;database=mochiSweets");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<Account>(entity =>
      {
        entity.HasKey(x => x.accountID);
        entity.Property(x => x.userName);
        entity.Property(x => x.passwordAccount);
        entity.Property(x => x.accountStatus);
      });

       modelBuilder.Entity<Category>(entity =>
      {
        entity.HasKey(x => x.categoryID);
        entity.Property(x => x.categoryName);
      });

      modelBuilder.Entity<Customer>(entity =>
      {
        entity.HasKey(x => x.customerID);
        entity.Property(x => x.userName);
        entity.Property(x => x.customerName);
        entity.Property(x => x.phonenumber);
        entity.Property(x => x.gender);
        entity.Property(x => x.birthDate);
        entity.Property(x => x.email);
        entity.Property(x => x.passwordCustomer);
      });

      modelBuilder.Entity<DeliveryAddress>(entity =>
      {
        entity.HasKey(x => x.addressID);
        entity.Property(x => x.phonenumber);
        entity.Property(x => x.phonenumber);
        entity.Property(x => x.city);
        entity.Property(x => x.district);
        entity.Property(x => x.address);
        entity.Property(x => x.customerName);
        entity.Property(x => x.addressStatus);
        entity.Property(x => x.addressDefault);
        entity.Property(x => x.customerID);
      });

      modelBuilder.Entity<Image>(entity =>
      {
        entity.HasKey(x => x.imageID);
        entity.Property(x => x.imageUrl);
        entity.Property(x => x.productID);
      });

      modelBuilder.Entity<News>(entity =>
      {
        entity.HasKey(x => x.newsID);
        entity.Property(x => x.title);
        entity.Property(x => x.content);
        entity.Property(x => x.postingTitle);
      });

      modelBuilder.Entity<Order>(entity =>
      {
        entity.HasKey(x => x.orderID);
        entity.Property(x => x.paymentMethodID);
        entity.Property(x => x.addressID);
        entity.Property(x => x.orderStatus);
        entity.Property(x => x.dateTime);
      });

      modelBuilder.Entity<OrdersProduct>(entity =>
      {
        entity.HasKey(x => new { x.orderID, x.productID });
        entity.Property(x => x.quantity);
        entity.Property(x => x.price);
        entity.Property(x => x.sale);
      });

      modelBuilder.Entity<PaymentsMethod>(entity =>
      {
        entity.HasKey(x => x.PaymentsMethodID);
        entity.Property(x => x.PaymentsMethodName);
      });

      modelBuilder.Entity<Product>(entity =>
      {
        entity.HasKey(x => x.productID);
        entity.Property(x => x.productName);
        entity.Property(x => x.price);
        entity.Property(x => x.detail);
        entity.Property(x => x.quantity);
        entity.Property(x => x.product_status);
        entity.Property(x => x.categoryID);
        entity.Property(x => x.numberOfCakes);
      });


      modelBuilder.Entity<SaleOff>(entity =>
      {
        entity.HasKey(x => x.saleID);
        entity.Property(x => x.sale);
        entity.Property(x => x.startTime);
        entity.Property(x => x.endTime);
      });
      modelBuilder.Entity<Taste>(entity =>
      {
        entity.HasKey(x => x.tasteID);
        entity.Property(x => x.tasteName);
        entity.Property(x => x.quantity);
        entity.Property(x => x.categoryID);
        entity.Property(x => x.image);
      });
     

    }
  }
}
