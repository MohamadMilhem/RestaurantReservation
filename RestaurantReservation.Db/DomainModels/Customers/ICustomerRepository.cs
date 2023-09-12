namespace RestaurantReservation.Db.DomainModels.Customers
{
    public interface ICustomerRepository
    {
        int Create(Customer customer);
        int Delete(Customer customer);
        Customer GetByIdWithReservations(int id);
        IEnumerable<Customer> GetCustomersWithPartySizeGreaterThan(PartySize partySize);
        int Update(Customer customer);
    }
}