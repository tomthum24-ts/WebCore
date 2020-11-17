using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebCore.Data.Entities;

namespace WebCore.Data.EF
{
    public class WebDbContext : DbContext
    {
        public WebDbContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
