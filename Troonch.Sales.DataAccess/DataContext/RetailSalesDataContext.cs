﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Troonch.Sales.Domain.Entities;

namespace Troonch.Sales.DataAccess
{
    public class RetailSalesDataContext : DbContext
    {
        public RetailSalesDataContext(DbContextOptions<RetailSalesDataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public  DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductGender> ProductGenders { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<ProductSizeOption> ProductSizeOptions { get; set; }
        public DbSet<ProductSizeType> ProductSizeTypes { get; set; }
        public DbSet<ProductTag> ProductTag { get; set; }
        public DbSet<ProductTag> ProductTagLookup { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}