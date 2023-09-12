using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DomainModels.Restaurants;
using RestaurantReservation.Db.DomainModels.Reservations;

namespace RestaurantReservation.Db.DomainModels.Tables
{
    public class Table : ITable
    {

        public int TableId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int Capacity { get; set; }
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .HasOne(t => t.Restaurant)
                .WithMany(r => r.Tables)
                .HasForeignKey("RestaurantId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Table>()
                .HasMany(t => t.Reservations)
                .WithOne(res => res.Table)
                .HasForeignKey("TableId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
