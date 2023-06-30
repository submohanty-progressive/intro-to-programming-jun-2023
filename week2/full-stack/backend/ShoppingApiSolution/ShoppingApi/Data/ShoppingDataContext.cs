﻿using Microsoft.EntityFrameworkCore;

namespace ShoppingApi.Data;

public class ShoppingDataContext : DbContext
{

    public ShoppingDataContext(DbContextOptions<ShoppingDataContext> options): base(options) { }

    public DbSet<StatusEntity> StatusMessages { get; set; }

    public DbSet<ShoppingListEntity> ShoppingList { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       // modelBuilder.Entity<StatusEntity>().Property(s => s.Message).HasMaxLength(100).IsRequired();
    }

}
