using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DataModels
{
    public class Order
    {
        public int OrderId { get; set; }
        public Reservation Reservation { get; set; }
        public Employee Employee { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Reservation)
                .WithMany()
                .HasForeignKey("OrderId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey("OrderId")
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Items)
                .WithOne(oi => oi.Order)
                .HasForeignKey("OrderId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
