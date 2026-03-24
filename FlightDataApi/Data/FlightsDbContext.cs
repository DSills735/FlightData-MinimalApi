using FlightDataApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightDataApi.Data
{
    public class FlightsDbContext : DbContext
    {
        public FlightsDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Flight> Flights { get; set; }
    }
}
