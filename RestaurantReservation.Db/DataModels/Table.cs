using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DataModels
{
    public class Table
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
