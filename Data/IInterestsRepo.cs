using System.Collections.Generic;
using SEBInterestRate.Models;

namespace SEBInterestRate.Data
{
    public interface IInterestsRepo
    {
        IEnumerable<Interest> GetAppInterests();
        Interest GetInteresById(int id);
    }
    public interface ICustomersRepo
    {
        IEnumerable<Customer> GetAppCustomers();
        Customer GetInteresById(int id);
    }
}