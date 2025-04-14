using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class AuctionDbContext : DbContext  
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {}

    // table name normally is plural format, that's why Auctions
    public DbSet<Auction> Auctions { get; set; }
}
