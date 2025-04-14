using AuctionService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<AuctionDbContext>(options => 
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // 
}

// going to run http, so no need it now.
// app.UseHttpsRedirection();

app.UseAuthentication();

/**
* middleware to map the controllers:
* Each one of the API controllers is going to have a route and this middleware allows the framework to 
* direct the Http request to the correct API endpoint.
*/
app.MapControllers();

app.Run();