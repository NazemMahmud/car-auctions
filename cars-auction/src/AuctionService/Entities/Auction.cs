namespace AuctionService.Entities;

public class Auction 
{
    public Guid Id { get; set; }
    public int ReservePrice { get; set; } = 0;
    public string Seller { get; set; }
    public string Winner { get; set; }
    public int? SoldAmount { get; set; }
    public int? CurrentHighBid { get; set; }

    // UTC is a standard international time format. 2nd reason: database server Postgres insists to use UTC values for the date time.
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime AuctionEnd { get; set; }
    public Status Status { get; set; }
    public Item Item { get; set; }


/**
Seller string (username from claim)
Winner? string (username of winner)

*/
}