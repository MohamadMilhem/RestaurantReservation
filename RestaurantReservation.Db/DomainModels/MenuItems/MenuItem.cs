﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Db.DomainModels.Restaurants;
using RestaurantReservation.Db.DomainModels.OrderItems;

namespace RestaurantReservation.Db.DomainModels.MenuItems
{
    public class MenuItem : IMenuItem
    {

        public int MenuItemId { get; set; }
        public Restaurant Restaurant { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItem>()
                .HasOne(mi => mi.Restaurant)
                .WithMany(r => r.MenuItems)
                .HasForeignKey("RestaurantId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MenuItem>()
                .HasMany<OrderItem>()
                .WithOne(oi => oi.MenuItem)
                .HasForeignKey("MenuItemId")
                .OnDelete(DeleteBehavior.ClientCascade);

        }
    }
}
