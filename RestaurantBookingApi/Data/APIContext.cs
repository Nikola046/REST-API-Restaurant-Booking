using Microsoft.EntityFrameworkCore;
using RestaurantBookingApi.Model;

namespace RestaurantBookingApi.Data
{
    public class APIContext:DbContext
    {

        public DbSet<RestaurantBooking> Bookings { get; set; }

        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {

        }

    }
}
