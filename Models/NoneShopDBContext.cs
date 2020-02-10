using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommercebackend.Models
{
    public class NoneShopDBContext:DbContext
    {
        public DbSet<NoneApparel> NoneApparels { get; set; }
        public NoneShopDBContext(DbContextOptions<NoneShopDBContext> options):base(options)
        {

        }
    }
}
