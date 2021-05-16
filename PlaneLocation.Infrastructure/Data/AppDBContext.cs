using Microsoft.EntityFrameworkCore;
using PlaneLocation.Domain.PlaneDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaneLocation.Infrastructure.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<PlaneDetails> PlaneDetails { get; set; }

    }
}
