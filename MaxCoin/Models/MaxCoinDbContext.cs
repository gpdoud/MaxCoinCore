using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maxtrain.MaxCoin.Models {

    public class MaxCoinDbContext : DbContext {

        public MaxCoinDbContext(DbContextOptions<MaxCoinDbContext> context) : base(context) {}

        public DbSet<Block> Blocks { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
