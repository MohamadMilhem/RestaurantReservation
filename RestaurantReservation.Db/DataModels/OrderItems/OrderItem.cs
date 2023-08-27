using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Db.DataModels.MenuItems;
using RestaurantReservation.Db.DataModels.Orders;

namespace RestaurantReservation.Db.DataModels.OrderItems
{
    public class OrderItem : IOrderItem
    {
        public int OrderItemId { get; set; }
        public Order Order { get; set; }
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.Items)
                .HasForeignKey("OrderItemId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.MenuItem)
                .WithMany()
                .HasForeignKey("MenuItemId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
