﻿using Microsoft.EntityFrameworkCore;
using Soil.Models;
namespace Soil.Context;

public class AppDbContext : DbContext
{
    
    
    public AppDbContext(DbContextOptions<AppDbContext> ops) : base(ops)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}


