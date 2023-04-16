using HotelBookingApi.Models;
using Microsoft.EntityFrameworkCore;
namespace HotelBookingApi.Data
{
  
    public class ApiContext:DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options):base(options)
        {
            
        }
    }
}
