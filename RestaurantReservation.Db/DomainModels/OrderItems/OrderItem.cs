using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DomainModels.MenuItems;
using RestaurantReservation.Db.DomainModels.Orders;

namespace RestaurantReservation.Db.DomainModels.OrderItems
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
                .HasForeignKey("OrderId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.MenuItem)
                .WithMany()
                .HasForeignKey("MenuItemId")
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
