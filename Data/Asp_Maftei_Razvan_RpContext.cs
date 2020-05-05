using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Maftei_Razvan_Rp.Models;

namespace Asp_Maftei_Razvan_Rp.Data
{
    public class Asp_Maftei_Razvan_RpContext : DbContext
    {
        public Asp_Maftei_Razvan_RpContext (DbContextOptions<Asp_Maftei_Razvan_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Maftei_Razvan_Rp.Models.Movie> Movie { get; set; }
    }
}
