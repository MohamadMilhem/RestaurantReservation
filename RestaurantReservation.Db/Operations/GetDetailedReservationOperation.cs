using RestaurantReservation.Db.ViewsModels.DetailedReservations;

namespace RestaurantReservation.Db.Operations
{
    public class GetDetailedReservationOperation : IOperation
    {
        private readonly DetailedReservationService _detailedReservationService;
        public GetDetailedReservationOperation()
        {
            _detailedReservationService = Factory.CreateDetailedReservationService();
        }

        public void Execute()
        {
            ConsolePrinter.AskForReservationId();
            var id = Console.ReadLine();

            var isValid = InputValidation.ValidateId(id);
            if (!isValid)
            {
                ConsolePrinter.InvalidId();
                return;
            }

            var idParsed = int.Parse(id);

            var result = _detailedReservationService.GetDetailedReservation(idParsed);
            if (result == null)
            {
                ConsolePrinter.NotFound();
                return;
            }

            ConsolePrinter.Print(result);
        }
    }
}
