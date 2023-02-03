using DataAccess.Models;

namespace DataAccess.Data;
public interface ICustomerRepository
{
    Task DeleteCustomer(int id);
    Task<IEnumerable<CustomerModel>> GetCustomers();
    Task<CustomerModel> GetCustomer(int id);
    Task InsertCustomer(CustomerModel customer);
    Task UpdateCustomer(CustomerModel customer);
}