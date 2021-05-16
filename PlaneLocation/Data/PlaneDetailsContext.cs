using Microsoft.EntityFrameworkCore;
using PlaneLocation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneLocation.Data
{
    public class PlaneDetailsContext : DbContext
    {
        public PlaneDetailsContext(DbContextOptions<PlaneDetailsContext> options) : base(options)
        {
        }

        public DbSet<PlaneDetails> PlaneDetails { get; set; }

    }
}
