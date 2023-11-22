using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BaseEditor;

public partial class SurpriseStoreListContext : DbContext
{
    public SurpriseStoreListContext()
    {
    }

    public SurpriseStoreListContext(DbContextOptions<SurpriseStoreListContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\\\\\\\Users\\\\\\\\Sergey\\\\\\\\Documents\\\\\\\\Base\\\\\\\\SurpriseStoreList.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
