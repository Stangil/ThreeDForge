using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDForge.Infrastructure.Context
{
    public class ThreeDForgeDbContext : DbContext
    {
        public ThreeDForgeDbContext(DbContextOptions<ThreeDForgeDbContext> options) : base(options)
        {
            
        }
    }
}
