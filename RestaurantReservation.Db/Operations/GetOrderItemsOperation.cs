﻿using RestaurantReservation.Db.DomainModels.OrderItems;
using RestaurantReservation.Db.DomainModels.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Operations
{
    public class GetOrderItemsOperation : IOperation
    {

        private readonly ReservationService _reservationService;

        public GetOrderItemsOperation()
        {
            _reservationService = Factory.CreateReservationService();
        }

        public void Execute()
        {
            ConsolePrinter.AskForReservationId();
            var id = Console.ReadLine();

            var validId = InputValidation.ValidateId(id);
            if (!validId)
            {
                ConsolePrinter.InvalidId();
                return;
            }

            var idParsed = int.Parse(id);
            
            var result = _reservationService.GetMenuItems(idParsed);
            if (!result.Any())
            {
                ConsolePrinter.NotFound();
                return;
            }

            ConsolePrinter.Print(result);
        }
    }
}
