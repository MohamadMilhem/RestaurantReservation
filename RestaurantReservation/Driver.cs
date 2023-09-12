using RestaurantReservation.Db;
using RestaurantReservation.Db.Operations;

namespace RestaurantReservation
{
    public class Driver
    {
        private readonly List<IOperation> _operations;
        public Driver(List<IOperation> operations)
        {
            _operations = operations;
        }


        public bool ProcessOption()
        {
            ConsolePrinter.DisplayMenu();

            var option = Console.ReadLine();

            var isValid = InputValidation.ValidateMenuOption(option);
            if (!isValid)
            {
                ConsolePrinter.InvalidOption();
                return true;
            }

            var choice = Converter.FromNumericStringToMenuChoice(option);

            if (choice.Equals(MenuChoice.Exit))
            {
                return false;
            }

            var operation = GetOperation(choice);

            operation.Execute();
            return true;

        }

        public IOperation GetOperation(MenuChoice choice)
        {
            int index = (int)(choice);
            return _operations.ElementAt(index - 1);
        }




    }
}
